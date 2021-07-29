// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: state.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ASCOM.DewPack.Proto
{

    /// <summary>Holder for reflection information generated from state.proto</summary>
    public static partial class StateReflection
    {

        #region Descriptor
        /// <summary>File descriptor for state.proto</summary>
        public static pbr::FileDescriptor Descriptor
        {
            get { return descriptor; }
        }
        private static pbr::FileDescriptor descriptor;

        static StateReflection()
        {
            byte[] descriptorData = global::System.Convert.FromBase64String(
                string.Concat(
                  "CgtzdGF0ZS5wcm90byJqCgtEZXZpY2VTdGF0ZRIlCg1jb25maWd1cmF0aW9u",
                  "GAEgASgLMg4uQ29uZmlndXJhdGlvbhIZCgR1c2IwGAIgASgLMgsuUG93ZXJT",
                  "dGF0ZRIZCgR1c2IxGAMgASgLMgsuUG93ZXJTdGF0ZSJTCg1Db25maWd1cmF0",
                  "aW9uEiAKC3VzYjBSZXN0b3JlGAEgASgLMgsuUG93ZXJTdGF0ZRIgCgt1c2Ix",
                  "UmVzdG9yZRgCIAEoCzILLlBvd2VyU3RhdGUiLgoKUG93ZXJTdGF0ZRINCgVw",
                  "b3dlchgBIAEoCBIRCglkdXR5Q3ljbGUYAiABKA1CFqoCE0FTQ09NLkRld1Bh",
                  "Y2suUHJvdG9iBnByb3RvMw=="));
            descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
                new pbr::FileDescriptor[] { },
                new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ASCOM.DewPack.Proto.DeviceState), global::ASCOM.DewPack.Proto.DeviceState.Parser, new[]{ "Configuration", "Usb0", "Usb1" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ASCOM.DewPack.Proto.Configuration), global::ASCOM.DewPack.Proto.Configuration.Parser, new[]{ "Usb0Restore", "Usb1Restore" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ASCOM.DewPack.Proto.PowerState), global::ASCOM.DewPack.Proto.PowerState.Parser, new[]{ "Power", "DutyCycle" }, null, null, null, null)
                }));
        }
        #endregion

    }
    #region Messages
    public sealed partial class DeviceState : pb::IMessage<DeviceState>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
#endif
    {
        private static readonly pb::MessageParser<DeviceState> _parser = new pb::MessageParser<DeviceState>(() => new DeviceState());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<DeviceState> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::ASCOM.DewPack.Proto.StateReflection.Descriptor.MessageTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public DeviceState()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public DeviceState(DeviceState other) : this()
        {
            configuration_ = other.configuration_ != null ? other.configuration_.Clone() : null;
            usb0_ = other.usb0_ != null ? other.usb0_.Clone() : null;
            usb1_ = other.usb1_ != null ? other.usb1_.Clone() : null;
            _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public DeviceState Clone()
        {
            return new DeviceState(this);
        }

        /// <summary>Field number for the "configuration" field.</summary>
        public const int ConfigurationFieldNumber = 1;
        private global::ASCOM.DewPack.Proto.Configuration configuration_;
        /// <summary>
        /// default startup power states
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::ASCOM.DewPack.Proto.Configuration Configuration
        {
            get { return configuration_; }
            set
            {
                configuration_ = value;
            }
        }

        /// <summary>Field number for the "usb0" field.</summary>
        public const int Usb0FieldNumber = 2;
        private global::ASCOM.DewPack.Proto.PowerState usb0_;
        /// <summary>
        /// top usb port power state
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::ASCOM.DewPack.Proto.PowerState Usb0
        {
            get { return usb0_; }
            set
            {
                usb0_ = value;
            }
        }

        /// <summary>Field number for the "usb1" field.</summary>
        public const int Usb1FieldNumber = 3;
        private global::ASCOM.DewPack.Proto.PowerState usb1_;
        /// <summary>
        /// bottom usb port power state
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::ASCOM.DewPack.Proto.PowerState Usb1
        {
            get { return usb1_; }
            set
            {
                usb1_ = value;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other)
        {
            return Equals(other as DeviceState);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(DeviceState other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!object.Equals(Configuration, other.Configuration)) return false;
            if (!object.Equals(Usb0, other.Usb0)) return false;
            if (!object.Equals(Usb1, other.Usb1)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode()
        {
            int hash = 1;
            if (configuration_ != null) hash ^= Configuration.GetHashCode();
            if (usb0_ != null) hash ^= Usb0.GetHashCode();
            if (usb1_ != null) hash ^= Usb1.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void WriteTo(pb::CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (configuration_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Configuration);
      }
      if (usb0_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Usb0);
      }
      if (usb1_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Usb1);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output)
        {
            if (configuration_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(Configuration);
            }
            if (usb0_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(Usb0);
            }
            if (usb1_ != null)
            {
                output.WriteRawTag(26);
                output.WriteMessage(Usb1);
            }
            if (_unknownFields != null)
            {
                _unknownFields.WriteTo(ref output);
            }
        }
#endif

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public int CalculateSize()
        {
            int size = 0;
            if (configuration_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(Configuration);
            }
            if (usb0_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(Usb0);
            }
            if (usb1_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(Usb1);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(DeviceState other)
        {
            if (other == null)
            {
                return;
            }
            if (other.configuration_ != null)
            {
                if (configuration_ == null)
                {
                    Configuration = new global::ASCOM.DewPack.Proto.Configuration();
                }
                Configuration.MergeFrom(other.Configuration);
            }
            if (other.usb0_ != null)
            {
                if (usb0_ == null)
                {
                    Usb0 = new global::ASCOM.DewPack.Proto.PowerState();
                }
                Usb0.MergeFrom(other.Usb0);
            }
            if (other.usb1_ != null)
            {
                if (usb1_ == null)
                {
                    Usb1 = new global::ASCOM.DewPack.Proto.PowerState();
                }
                Usb1.MergeFrom(other.Usb1);
            }
            _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(pb::CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (configuration_ == null) {
              Configuration = new global::ASCOM.DewPack.Proto.Configuration();
            }
            input.ReadMessage(Configuration);
            break;
          }
          case 18: {
            if (usb0_ == null) {
              Usb0 = new global::ASCOM.DewPack.Proto.PowerState();
            }
            input.ReadMessage(Usb0);
            break;
          }
          case 26: {
            if (usb1_ == null) {
              Usb1 = new global::ASCOM.DewPack.Proto.PowerState();
            }
            input.ReadMessage(Usb1);
            break;
          }
        }
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        break;
                    case 10:
                        {
                            if (configuration_ == null)
                            {
                                Configuration = new global::ASCOM.DewPack.Proto.Configuration();
                            }
                            input.ReadMessage(Configuration);
                            break;
                        }
                    case 18:
                        {
                            if (usb0_ == null)
                            {
                                Usb0 = new global::ASCOM.DewPack.Proto.PowerState();
                            }
                            input.ReadMessage(Usb0);
                            break;
                        }
                    case 26:
                        {
                            if (usb1_ == null)
                            {
                                Usb1 = new global::ASCOM.DewPack.Proto.PowerState();
                            }
                            input.ReadMessage(Usb1);
                            break;
                        }
                }
            }
        }
#endif

    }

    public sealed partial class Configuration : pb::IMessage<Configuration>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
#endif
    {
        private static readonly pb::MessageParser<Configuration> _parser = new pb::MessageParser<Configuration>(() => new Configuration());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<Configuration> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::ASCOM.DewPack.Proto.StateReflection.Descriptor.MessageTypes[1]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Configuration()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Configuration(Configuration other) : this()
        {
            usb0Restore_ = other.usb0Restore_ != null ? other.usb0Restore_.Clone() : null;
            usb1Restore_ = other.usb1Restore_ != null ? other.usb1Restore_.Clone() : null;
            _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Configuration Clone()
        {
            return new Configuration(this);
        }

        /// <summary>Field number for the "usb0Restore" field.</summary>
        public const int Usb0RestoreFieldNumber = 1;
        private global::ASCOM.DewPack.Proto.PowerState usb0Restore_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::ASCOM.DewPack.Proto.PowerState Usb0Restore
        {
            get { return usb0Restore_; }
            set
            {
                usb0Restore_ = value;
            }
        }

        /// <summary>Field number for the "usb1Restore" field.</summary>
        public const int Usb1RestoreFieldNumber = 2;
        private global::ASCOM.DewPack.Proto.PowerState usb1Restore_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::ASCOM.DewPack.Proto.PowerState Usb1Restore
        {
            get { return usb1Restore_; }
            set
            {
                usb1Restore_ = value;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other)
        {
            return Equals(other as Configuration);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(Configuration other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!object.Equals(Usb0Restore, other.Usb0Restore)) return false;
            if (!object.Equals(Usb1Restore, other.Usb1Restore)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode()
        {
            int hash = 1;
            if (usb0Restore_ != null) hash ^= Usb0Restore.GetHashCode();
            if (usb1Restore_ != null) hash ^= Usb1Restore.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void WriteTo(pb::CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (usb0Restore_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Usb0Restore);
      }
      if (usb1Restore_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Usb1Restore);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output)
        {
            if (usb0Restore_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(Usb0Restore);
            }
            if (usb1Restore_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(Usb1Restore);
            }
            if (_unknownFields != null)
            {
                _unknownFields.WriteTo(ref output);
            }
        }
#endif

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public int CalculateSize()
        {
            int size = 0;
            if (usb0Restore_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(Usb0Restore);
            }
            if (usb1Restore_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(Usb1Restore);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(Configuration other)
        {
            if (other == null)
            {
                return;
            }
            if (other.usb0Restore_ != null)
            {
                if (usb0Restore_ == null)
                {
                    Usb0Restore = new global::ASCOM.DewPack.Proto.PowerState();
                }
                Usb0Restore.MergeFrom(other.Usb0Restore);
            }
            if (other.usb1Restore_ != null)
            {
                if (usb1Restore_ == null)
                {
                    Usb1Restore = new global::ASCOM.DewPack.Proto.PowerState();
                }
                Usb1Restore.MergeFrom(other.Usb1Restore);
            }
            _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(pb::CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (usb0Restore_ == null) {
              Usb0Restore = new global::ASCOM.DewPack.Proto.PowerState();
            }
            input.ReadMessage(Usb0Restore);
            break;
          }
          case 18: {
            if (usb1Restore_ == null) {
              Usb1Restore = new global::ASCOM.DewPack.Proto.PowerState();
            }
            input.ReadMessage(Usb1Restore);
            break;
          }
        }
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        break;
                    case 10:
                        {
                            if (usb0Restore_ == null)
                            {
                                Usb0Restore = new global::ASCOM.DewPack.Proto.PowerState();
                            }
                            input.ReadMessage(Usb0Restore);
                            break;
                        }
                    case 18:
                        {
                            if (usb1Restore_ == null)
                            {
                                Usb1Restore = new global::ASCOM.DewPack.Proto.PowerState();
                            }
                            input.ReadMessage(Usb1Restore);
                            break;
                        }
                }
            }
        }
#endif

    }

    public sealed partial class PowerState : pb::IMessage<PowerState>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
#endif
    {
        private static readonly pb::MessageParser<PowerState> _parser = new pb::MessageParser<PowerState>(() => new PowerState());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<PowerState> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::ASCOM.DewPack.Proto.StateReflection.Descriptor.MessageTypes[2]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public PowerState()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public PowerState(PowerState other) : this()
        {
            power_ = other.power_;
            dutyCycle_ = other.dutyCycle_;
            _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public PowerState Clone()
        {
            return new PowerState(this);
        }

        /// <summary>Field number for the "power" field.</summary>
        public const int PowerFieldNumber = 1;
        private bool power_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Power
        {
            get { return power_; }
            set
            {
                power_ = value;
            }
        }

        /// <summary>Field number for the "dutyCycle" field.</summary>
        public const int DutyCycleFieldNumber = 2;
        private uint dutyCycle_;
        /// <summary>
        /// 0-255 duty cycle
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public uint DutyCycle
        {
            get { return dutyCycle_; }
            set
            {
                dutyCycle_ = value;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other)
        {
            return Equals(other as PowerState);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(PowerState other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Power != other.Power) return false;
            if (DutyCycle != other.DutyCycle) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode()
        {
            int hash = 1;
            if (Power != false) hash ^= Power.GetHashCode();
            if (DutyCycle != 0) hash ^= DutyCycle.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void WriteTo(pb::CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Power != false) {
        output.WriteRawTag(8);
        output.WriteBool(Power);
      }
      if (DutyCycle != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(DutyCycle);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output)
        {
            if (Power != false)
            {
                output.WriteRawTag(8);
                output.WriteBool(Power);
            }
            if (DutyCycle != 0)
            {
                output.WriteRawTag(16);
                output.WriteUInt32(DutyCycle);
            }
            if (_unknownFields != null)
            {
                _unknownFields.WriteTo(ref output);
            }
        }
#endif

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public int CalculateSize()
        {
            int size = 0;
            if (Power != false)
            {
                size += 1 + 1;
            }
            if (DutyCycle != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DutyCycle);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(PowerState other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Power != false)
            {
                Power = other.Power;
            }
            if (other.DutyCycle != 0)
            {
                DutyCycle = other.DutyCycle;
            }
            _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(pb::CodedInputStream input)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Power = input.ReadBool();
            break;
          }
          case 16: {
            DutyCycle = input.ReadUInt32();
            break;
          }
        }
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        break;
                    case 8:
                        {
                            Power = input.ReadBool();
                            break;
                        }
                    case 16:
                        {
                            DutyCycle = input.ReadUInt32();
                            break;
                        }
                }
            }
        }
#endif

    }

    #endregion

}

#endregion Designer generated code