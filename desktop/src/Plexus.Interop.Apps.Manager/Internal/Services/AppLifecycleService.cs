﻿/**
 * Copyright 2017-2020 Plexus Interop Deutsche Bank AG
 * SPDX-License-Identifier: Apache-2.0
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
namespace Plexus.Interop.Apps.Internal.Services
{
    using System;
    using System.Threading.Tasks;
    using Google.Protobuf.WellKnownTypes;
    using Plexus.Channels;
    using Plexus.Interop.Apps.Internal.Generated;
    using AppConnectionDescriptor = Plexus.Interop.Apps.AppConnectionDescriptor;

    internal class AppLifecycleService : IAppLifecycleService
    {
        private ILogger Log { get; } = LogManager.GetLogger<AppLifecycleService>();

        private readonly IAppLifecycleManager _appLifecycleManager;

        private readonly EventBroadcaster<AppLifecycleEvent> _appLifecycleEventBroadcaster
            = new EventBroadcaster<AppLifecycleEvent>();

        private readonly EventBroadcaster<InvocationEvent> _invocationEventBroadcaster
            = new EventBroadcaster<InvocationEvent>();

        public AppLifecycleService(IAppLifecycleManager appLifecycleManager)
        {
            _appLifecycleManager = appLifecycleManager;

            appLifecycleManager.AppConnected += OnAppConnected;
            appLifecycleManager.AppDisconnected += OnAppDisconnected;
        }

        public void OnInvocationStarted(InvocationStartedEventDescriptor eventData)
        {
            _invocationEventBroadcaster.BroadcastEvent(new InvocationEvent
            {
                InvocationStarted = new InvocationStartedEvent
                {
                    InvocationDescriptor = eventData.InvocationDescriptor.ToProto()
                }
            });
        }

        public void OnInvocationFinished(InvocationFinishedEventDescriptor eventData)
        {
            _invocationEventBroadcaster.BroadcastEvent(new InvocationEvent
            {
                InvocationFinished = new InvocationFinishedEvent
                {
                    InvocationDescriptor = eventData.MethodCallDescriptor.ToProto(),
                    Result = eventData.Result.ToProto(),
                    DurationMs = eventData.DurationMs
                }
            });
        }

        private void OnAppConnected(AppConnectionDescriptor connectionDescriptor)
        {
            _appLifecycleEventBroadcaster.BroadcastEvent(new AppLifecycleEvent
            {
                Connected = new AppConnectedEvent
                {
                    ConnectionDescriptor = connectionDescriptor.ToProto(),
                }
            });
        }

        private void OnAppDisconnected(AppConnectionDescriptor connectionDescriptor)
        {
            _appLifecycleEventBroadcaster.BroadcastEvent(new AppLifecycleEvent
            {
                Disconnected = new AppDisconnectedEvent
                {
                    ConnectionDescriptor = connectionDescriptor.ToProto(),
                }
            });
        }

        public async Task<ResolveAppResponse> ResolveApp(ResolveAppRequest request, MethodCallContext context)
        {
            Log.Info("Resolving app by request {{{0}}} from {{{1}}}", request, context);
            var referrerConnectionInfo = new AppConnectionDescriptor(
                context.ConsumerConnectionId,
                context.ConsumerApplicationId,
                context.ConsumerApplicationInstanceId);
            var resolvedConnection = await _appLifecycleManager.ResolveConnectionAsync(
                request.AppId, Convert(request.AppResolveMode), referrerConnectionInfo).ConfigureAwait(false);
            var info = resolvedConnection.AppConnection.Info;
            Log.Info("App connection {{{0}}} resolved by request from {{{1}}}", resolvedConnection, context);
            var response = new ResolveAppResponse
            {
                AppConnectionId = new UniqueId
                {
                    Hi = info.ConnectionId.Hi,
                    Lo = info.ConnectionId.Lo
                },
                AppInstanceId = new UniqueId
                {
                    Hi = info.ApplicationInstanceId.Hi,
                    Lo = info.ApplicationInstanceId.Lo
                },
                IsNewInstanceLaunched = resolvedConnection.IsNewInstance
            };
            return response;
        }

        public Task GetLifecycleEventStream(Empty request, IWritableChannel<AppLifecycleEvent> responseStream, MethodCallContext context)
        {
            return _appLifecycleEventBroadcaster.Subscribe(responseStream, context);
        }

        public Task GetInvocationEventStream(Empty request, IWritableChannel<InvocationEvent> responseStream, MethodCallContext context)
        {
            return _invocationEventBroadcaster.Subscribe(responseStream, context);
        }

        private static ResolveMode Convert(AppLaunchMode launchMode)
        {
            switch (launchMode)
            {
                case AppLaunchMode.SingleInstance:
                    return ResolveMode.SingleInstance;
                case AppLaunchMode.MultiInstance:
                    return ResolveMode.MultiInstance;
                default:
                    throw new ArgumentOutOfRangeException(nameof(launchMode), launchMode, null);
            }
        }
    }
}
