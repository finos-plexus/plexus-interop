﻿namespace Plexus.Interop.Transport.Transmission.Streams.Internal
{
    using Plexus.Channels;
    using Plexus.Pools;
    using System;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    internal sealed class StreamTransmissionReader
    {
        private const int EndMessage = 65535;

        private readonly BufferedChannel<IPooledBuffer> _buffer = new BufferedChannel<IPooledBuffer>(3);
        private readonly byte[] _lengthBuffer = new byte[2];
        private readonly Stream _stream;
        private readonly CancellationToken _cancellationToken;
        private readonly ILogger _log;
        private long _count;

        public StreamTransmissionReader(
            UniqueId id, 
            Stream stream, 
            CancellationToken cancellationToken)
        {
            _log = LogManager.GetLogger<StreamTransmissionReader>(id.ToString());
            _stream = stream;
            _cancellationToken = cancellationToken;
            _buffer.Out.PropagateCompletionFrom(TaskRunner.RunInBackground(ProcessAsync));
            _buffer.Out.Completion.LogCompletion(_log);
        }

        public IReadOnlyChannel<IPooledBuffer> In => _buffer.In;

        private async Task ProcessAsync()
        {
            try
            {
                while (true)
                {
                    _log.Trace("Awaiting next message {0}", _count);
                    var length = await ReadLengthAsync().ConfigureAwait(false);
                    if (length == EndMessage)
                    {
                        _log.Trace("Completing receiving datagrams because <END> message received");
                        break;
                    }
                    _log.Trace("Reading message {0} of length {1}", _count, length);
                    var datagram = await PooledBuffer
                        .Get(_stream, length, _cancellationToken)
                        .ConfigureAwait(false);
                    try
                    {
                        await _buffer.Out.WriteAsync(datagram, _cancellationToken).ConfigureAwait(false);
                    }
                    catch
                    {
                        datagram.Dispose();
                        throw;
                    }
                    _log.Trace("Received message {0} of length {1}", _count, length);
                    _count++;
                }
                _buffer.Out.TryCompleteWriting();
            }
            catch (Exception ex)
            {
                _log.Trace("Process failed: {0}", ex.FormatTypeAndMessage());
                _buffer.Out.TryTerminateWriting(ex);
                _buffer.In.DisposeBufferedItems();
                throw;
            }
        }

        private async Task<int> ReadLengthAsync()
        {
#if NETSTANDARD1_3
            var length = await _stream.ReadAsync(_lengthBuffer, 0, 2, _cancellationToken).ConfigureAwait(false);
#else
            var length = await _stream.ReadAsync(_lengthBuffer, 0, 2, _cancellationToken).WithCancellation(_cancellationToken).ConfigureAwait(false);
#endif
            if (length != 2)
            {
                throw new InvalidOperationException("Stream completed unexpectedly");
            }
            return (_lengthBuffer[0] << 8) | _lengthBuffer[1];
        }
    }
}
