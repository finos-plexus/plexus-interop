/**
 * Copyright 2017-2018 Plexus Interop Deutsche Bank AG
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
// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: plexus/interop/testing/echo_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Plexus.Interop.Testing.Generated {

  /// <summary>Holder for reflection information generated from plexus/interop/testing/echo_service.proto</summary>
  public static partial class EchoServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for plexus/interop/testing/echo_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EchoServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CilwbGV4dXMvaW50ZXJvcC90ZXN0aW5nL2VjaG9fc2VydmljZS5wcm90bxIW",
            "cGxleHVzLmludGVyb3AudGVzdGluZxoVaW50ZXJvcC9vcHRpb25zLnByb3Rv",
            "IooECgtFY2hvUmVxdWVzdBIUCgxzdHJpbmdfZmllbGQYASABKAkSEwoLaW50",
            "NjRfZmllbGQYAiABKAMSFAoMdWludDMyX2ZpZWxkGAMgASgNEh0KFXJlcGVh",
            "dGVkX2RvdWJsZV9maWVsZBgEIAMoARI/CgplbnVtX2ZpZWxkGAUgASgOMisu",
            "cGxleHVzLmludGVyb3AudGVzdGluZy5FY2hvUmVxdWVzdC5TdWJFbnVtEkkK",
            "EXN1Yl9tZXNzYWdlX2ZpZWxkGAYgASgLMi4ucGxleHVzLmludGVyb3AudGVz",
            "dGluZy5FY2hvUmVxdWVzdC5TdWJNZXNzYWdlElIKGnJlcGVhdGVkX3N1Yl9t",
            "ZXNzYWdlX2ZpZWxkGAcgAygLMi4ucGxleHVzLmludGVyb3AudGVzdGluZy5F",
            "Y2hvUmVxdWVzdC5TdWJNZXNzYWdlGmoKClN1Yk1lc3NhZ2USEwoLYnl0ZXNf",
            "ZmllbGQYASABKAwSFAoMc3RyaW5nX2ZpZWxkGAIgASgJOjGS2wQtcGxleHVz",
            "LmludGVyb3AudGVzdGluZy5FY2hvUmVxdWVzdC5TdWJNZXNzYWdlIicKB1N1",
            "YkVudW0SDQoJdmFsdWVfb25lEAASDQoJdmFsdWVfdHdvEAE6JpLbBCJwbGV4",
            "dXMuaW50ZXJvcC50ZXN0aW5nLkVjaG9SZXF1ZXN0MqcDCgtFY2hvU2Vydmlj",
            "ZRJRCgVVbmFyeRIjLnBsZXh1cy5pbnRlcm9wLnRlc3RpbmcuRWNob1JlcXVl",
            "c3QaIy5wbGV4dXMuaW50ZXJvcC50ZXN0aW5nLkVjaG9SZXF1ZXN0El0KD1Nl",
            "cnZlclN0cmVhbWluZxIjLnBsZXh1cy5pbnRlcm9wLnRlc3RpbmcuRWNob1Jl",
            "cXVlc3QaIy5wbGV4dXMuaW50ZXJvcC50ZXN0aW5nLkVjaG9SZXF1ZXN0MAES",
            "XQoPQ2xpZW50U3RyZWFtaW5nEiMucGxleHVzLmludGVyb3AudGVzdGluZy5F",
            "Y2hvUmVxdWVzdBojLnBsZXh1cy5pbnRlcm9wLnRlc3RpbmcuRWNob1JlcXVl",
            "c3QoARJfCg9EdXBsZXhTdHJlYW1pbmcSIy5wbGV4dXMuaW50ZXJvcC50ZXN0",
            "aW5nLkVjaG9SZXF1ZXN0GiMucGxleHVzLmludGVyb3AudGVzdGluZy5FY2hv",
            "UmVxdWVzdCgBMAEaJpLbBCJwbGV4dXMuaW50ZXJvcC50ZXN0aW5nLkVjaG9T",
            "ZXJ2aWNlQiOqAiBQbGV4dXMuSW50ZXJvcC5UZXN0aW5nLkdlbmVyYXRlZGIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Plexus.Interop.Testing.Generated.OptionsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Plexus.Interop.Testing.Generated.EchoRequest), global::Plexus.Interop.Testing.Generated.EchoRequest.Parser, new[]{ "StringField", "Int64Field", "Uint32Field", "RepeatedDoubleField", "EnumField", "SubMessageField", "RepeatedSubMessageField" }, null, new[]{ typeof(global::Plexus.Interop.Testing.Generated.EchoRequest.Types.SubEnum) }, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Plexus.Interop.Testing.Generated.EchoRequest.Types.SubMessage), global::Plexus.Interop.Testing.Generated.EchoRequest.Types.SubMessage.Parser, new[]{ "BytesField", "StringField" }, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EchoRequest : pb::IMessage<EchoRequest> {
    private static readonly pb::MessageParser<EchoRequest> _parser = new pb::MessageParser<EchoRequest>(() => new EchoRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EchoRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Plexus.Interop.Testing.Generated.EchoServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EchoRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EchoRequest(EchoRequest other) : this() {
      stringField_ = other.stringField_;
      int64Field_ = other.int64Field_;
      uint32Field_ = other.uint32Field_;
      repeatedDoubleField_ = other.repeatedDoubleField_.Clone();
      enumField_ = other.enumField_;
      SubMessageField = other.subMessageField_ != null ? other.SubMessageField.Clone() : null;
      repeatedSubMessageField_ = other.repeatedSubMessageField_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EchoRequest Clone() {
      return new EchoRequest(this);
    }

    /// <summary>Field number for the "string_field" field.</summary>
    public const int StringFieldFieldNumber = 1;
    private string stringField_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string StringField {
      get { return stringField_; }
      set {
        stringField_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "int64_field" field.</summary>
    public const int Int64FieldFieldNumber = 2;
    private long int64Field_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Int64Field {
      get { return int64Field_; }
      set {
        int64Field_ = value;
      }
    }

    /// <summary>Field number for the "uint32_field" field.</summary>
    public const int Uint32FieldFieldNumber = 3;
    private uint uint32Field_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Uint32Field {
      get { return uint32Field_; }
      set {
        uint32Field_ = value;
      }
    }

    /// <summary>Field number for the "repeated_double_field" field.</summary>
    public const int RepeatedDoubleFieldFieldNumber = 4;
    private static readonly pb::FieldCodec<double> _repeated_repeatedDoubleField_codec
        = pb::FieldCodec.ForDouble(34);
    private readonly pbc::RepeatedField<double> repeatedDoubleField_ = new pbc::RepeatedField<double>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<double> RepeatedDoubleField {
      get { return repeatedDoubleField_; }
    }

    /// <summary>Field number for the "enum_field" field.</summary>
    public const int EnumFieldFieldNumber = 5;
    private global::Plexus.Interop.Testing.Generated.EchoRequest.Types.SubEnum enumField_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Plexus.Interop.Testing.Generated.EchoRequest.Types.SubEnum EnumField {
      get { return enumField_; }
      set {
        enumField_ = value;
      }
    }

    /// <summary>Field number for the "sub_message_field" field.</summary>
    public const int SubMessageFieldFieldNumber = 6;
    private global::Plexus.Interop.Testing.Generated.EchoRequest.Types.SubMessage subMessageField_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Plexus.Interop.Testing.Generated.EchoRequest.Types.SubMessage SubMessageField {
      get { return subMessageField_; }
      set {
        subMessageField_ = value;
      }
    }

    /// <summary>Field number for the "repeated_sub_message_field" field.</summary>
    public const int RepeatedSubMessageFieldFieldNumber = 7;
    private static readonly pb::FieldCodec<global::Plexus.Interop.Testing.Generated.EchoRequest.Types.SubMessage> _repeated_repeatedSubMessageField_codec
        = pb::FieldCodec.ForMessage(58, global::Plexus.Interop.Testing.Generated.EchoRequest.Types.SubMessage.Parser);
    private readonly pbc::RepeatedField<global::Plexus.Interop.Testing.Generated.EchoRequest.Types.SubMessage> repeatedSubMessageField_ = new pbc::RepeatedField<global::Plexus.Interop.Testing.Generated.EchoRequest.Types.SubMessage>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Plexus.Interop.Testing.Generated.EchoRequest.Types.SubMessage> RepeatedSubMessageField {
      get { return repeatedSubMessageField_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EchoRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EchoRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StringField != other.StringField) return false;
      if (Int64Field != other.Int64Field) return false;
      if (Uint32Field != other.Uint32Field) return false;
      if(!repeatedDoubleField_.Equals(other.repeatedDoubleField_)) return false;
      if (EnumField != other.EnumField) return false;
      if (!object.Equals(SubMessageField, other.SubMessageField)) return false;
      if(!repeatedSubMessageField_.Equals(other.repeatedSubMessageField_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (StringField.Length != 0) hash ^= StringField.GetHashCode();
      if (Int64Field != 0L) hash ^= Int64Field.GetHashCode();
      if (Uint32Field != 0) hash ^= Uint32Field.GetHashCode();
      hash ^= repeatedDoubleField_.GetHashCode();
      if (EnumField != 0) hash ^= EnumField.GetHashCode();
      if (subMessageField_ != null) hash ^= SubMessageField.GetHashCode();
      hash ^= repeatedSubMessageField_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (StringField.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(StringField);
      }
      if (Int64Field != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Int64Field);
      }
      if (Uint32Field != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Uint32Field);
      }
      repeatedDoubleField_.WriteTo(output, _repeated_repeatedDoubleField_codec);
      if (EnumField != 0) {
        output.WriteRawTag(40);
        output.WriteEnum((int) EnumField);
      }
      if (subMessageField_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(SubMessageField);
      }
      repeatedSubMessageField_.WriteTo(output, _repeated_repeatedSubMessageField_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (StringField.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StringField);
      }
      if (Int64Field != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Int64Field);
      }
      if (Uint32Field != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uint32Field);
      }
      size += repeatedDoubleField_.CalculateSize(_repeated_repeatedDoubleField_codec);
      if (EnumField != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) EnumField);
      }
      if (subMessageField_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SubMessageField);
      }
      size += repeatedSubMessageField_.CalculateSize(_repeated_repeatedSubMessageField_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EchoRequest other) {
      if (other == null) {
        return;
      }
      if (other.StringField.Length != 0) {
        StringField = other.StringField;
      }
      if (other.Int64Field != 0L) {
        Int64Field = other.Int64Field;
      }
      if (other.Uint32Field != 0) {
        Uint32Field = other.Uint32Field;
      }
      repeatedDoubleField_.Add(other.repeatedDoubleField_);
      if (other.EnumField != 0) {
        EnumField = other.EnumField;
      }
      if (other.subMessageField_ != null) {
        if (subMessageField_ == null) {
          subMessageField_ = new global::Plexus.Interop.Testing.Generated.EchoRequest.Types.SubMessage();
        }
        SubMessageField.MergeFrom(other.SubMessageField);
      }
      repeatedSubMessageField_.Add(other.repeatedSubMessageField_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            StringField = input.ReadString();
            break;
          }
          case 16: {
            Int64Field = input.ReadInt64();
            break;
          }
          case 24: {
            Uint32Field = input.ReadUInt32();
            break;
          }
          case 34:
          case 33: {
            repeatedDoubleField_.AddEntriesFrom(input, _repeated_repeatedDoubleField_codec);
            break;
          }
          case 40: {
            enumField_ = (global::Plexus.Interop.Testing.Generated.EchoRequest.Types.SubEnum) input.ReadEnum();
            break;
          }
          case 50: {
            if (subMessageField_ == null) {
              subMessageField_ = new global::Plexus.Interop.Testing.Generated.EchoRequest.Types.SubMessage();
            }
            input.ReadMessage(subMessageField_);
            break;
          }
          case 58: {
            repeatedSubMessageField_.AddEntriesFrom(input, _repeated_repeatedSubMessageField_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the EchoRequest message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum SubEnum {
        [pbr::OriginalName("value_one")] ValueOne = 0,
        [pbr::OriginalName("value_two")] ValueTwo = 1,
      }

      public sealed partial class SubMessage : pb::IMessage<SubMessage> {
        private static readonly pb::MessageParser<SubMessage> _parser = new pb::MessageParser<SubMessage>(() => new SubMessage());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<SubMessage> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Plexus.Interop.Testing.Generated.EchoRequest.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public SubMessage() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public SubMessage(SubMessage other) : this() {
          bytesField_ = other.bytesField_;
          stringField_ = other.stringField_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public SubMessage Clone() {
          return new SubMessage(this);
        }

        /// <summary>Field number for the "bytes_field" field.</summary>
        public const int BytesFieldFieldNumber = 1;
        private pb::ByteString bytesField_ = pb::ByteString.Empty;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pb::ByteString BytesField {
          get { return bytesField_; }
          set {
            bytesField_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "string_field" field.</summary>
        public const int StringFieldFieldNumber = 2;
        private string stringField_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string StringField {
          get { return stringField_; }
          set {
            stringField_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as SubMessage);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(SubMessage other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (BytesField != other.BytesField) return false;
          if (StringField != other.StringField) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (BytesField.Length != 0) hash ^= BytesField.GetHashCode();
          if (StringField.Length != 0) hash ^= StringField.GetHashCode();
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          if (BytesField.Length != 0) {
            output.WriteRawTag(10);
            output.WriteBytes(BytesField);
          }
          if (StringField.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(StringField);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (BytesField.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeBytesSize(BytesField);
          }
          if (StringField.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(StringField);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(SubMessage other) {
          if (other == null) {
            return;
          }
          if (other.BytesField.Length != 0) {
            BytesField = other.BytesField;
          }
          if (other.StringField.Length != 0) {
            StringField = other.StringField;
          }
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 10: {
                BytesField = input.ReadBytes();
                break;
              }
              case 18: {
                StringField = input.ReadString();
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
