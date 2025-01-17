// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/securitycenter/v2/simulation.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.SecurityCenter.V2 {

  /// <summary>Holder for reflection information generated from google/cloud/securitycenter/v2/simulation.proto</summary>
  public static partial class SimulationReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/securitycenter/v2/simulation.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SimulationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9nb29nbGUvY2xvdWQvc2VjdXJpdHljZW50ZXIvdjIvc2ltdWxhdGlvbi5w",
            "cm90bxIeZ29vZ2xlLmNsb3VkLnNlY3VyaXR5Y2VudGVyLnYyGh9nb29nbGUv",
            "YXBpL2ZpZWxkX2JlaGF2aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNl",
            "LnByb3RvGi1nb29nbGUvY2xvdWQvc2VjdXJpdHljZW50ZXIvdjIvcmVzb3Vy",
            "Y2UucHJvdG8aNGdvb2dsZS9jbG91ZC9zZWN1cml0eWNlbnRlci92Mi92YWx1",
            "ZWRfcmVzb3VyY2UucHJvdG8aH2dvb2dsZS9wcm90b2J1Zi90aW1lc3RhbXAu",
            "cHJvdG8iygMKClNpbXVsYXRpb24SDAoEbmFtZRgBIAEoCRI0CgtjcmVhdGVf",
            "dGltZRgCIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXBCA+BBAxJk",
            "Ch9yZXNvdXJjZV92YWx1ZV9jb25maWdzX21ldGFkYXRhGAMgAygLMjsuZ29v",
            "Z2xlLmNsb3VkLnNlY3VyaXR5Y2VudGVyLnYyLlJlc291cmNlVmFsdWVDb25m",
            "aWdNZXRhZGF0YRJFCg5jbG91ZF9wcm92aWRlchgEIAEoDjItLmdvb2dsZS5j",
            "bG91ZC5zZWN1cml0eWNlbnRlci52Mi5DbG91ZFByb3ZpZGVyOsoB6kHGAQoo",
            "c2VjdXJpdHljZW50ZXIuZ29vZ2xlYXBpcy5jb20vU2ltdWxhdGlvbhI1b3Jn",
            "YW5pemF0aW9ucy97b3JnYW5pemF0aW9ufS9zaW11bGF0aW9ucy97c2ltdWxh",
            "dGlvbn0SSm9yZ2FuaXphdGlvbnMve29yZ2FuaXphdGlvbn0vbG9jYXRpb25z",
            "L3tsb2NhdGlvbn0vc2ltdWxhdGlvbnMve3NpbWx1YXRpb259KgtzaW11bGF0",
            "aW9uczIKc2ltdWxhdGlvbkLpAQoiY29tLmdvb2dsZS5jbG91ZC5zZWN1cml0",
            "eWNlbnRlci52MkIPU2ltdWxhdGlvblByb3RvUAFaSmNsb3VkLmdvb2dsZS5j",
            "b20vZ28vc2VjdXJpdHljZW50ZXIvYXBpdjIvc2VjdXJpdHljZW50ZXJwYjtz",
            "ZWN1cml0eWNlbnRlcnBiqgIeR29vZ2xlLkNsb3VkLlNlY3VyaXR5Q2VudGVy",
            "LlYyygIeR29vZ2xlXENsb3VkXFNlY3VyaXR5Q2VudGVyXFYy6gIhR29vZ2xl",
            "OjpDbG91ZDo6U2VjdXJpdHlDZW50ZXI6OlYyYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.SecurityCenter.V2.ResourceReflection.Descriptor, global::Google.Cloud.SecurityCenter.V2.ValuedResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.SecurityCenter.V2.Simulation), global::Google.Cloud.SecurityCenter.V2.Simulation.Parser, new[]{ "Name", "CreateTime", "ResourceValueConfigsMetadata", "CloudProvider" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Attack path simulation
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Simulation : pb::IMessage<Simulation>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Simulation> _parser = new pb::MessageParser<Simulation>(() => new Simulation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Simulation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.SecurityCenter.V2.SimulationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Simulation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Simulation(Simulation other) : this() {
      name_ = other.name_;
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      resourceValueConfigsMetadata_ = other.resourceValueConfigsMetadata_.Clone();
      cloudProvider_ = other.cloudProvider_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Simulation Clone() {
      return new Simulation(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Full resource name of the Simulation:
    /// organizations/123/simulations/456
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Output only. Time simulation was created
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    /// <summary>Field number for the "resource_value_configs_metadata" field.</summary>
    public const int ResourceValueConfigsMetadataFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Google.Cloud.SecurityCenter.V2.ResourceValueConfigMetadata> _repeated_resourceValueConfigsMetadata_codec
        = pb::FieldCodec.ForMessage(26, global::Google.Cloud.SecurityCenter.V2.ResourceValueConfigMetadata.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.SecurityCenter.V2.ResourceValueConfigMetadata> resourceValueConfigsMetadata_ = new pbc::RepeatedField<global::Google.Cloud.SecurityCenter.V2.ResourceValueConfigMetadata>();
    /// <summary>
    /// Resource value configurations' metadata used in this simulation. Maximum of
    /// 100.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Cloud.SecurityCenter.V2.ResourceValueConfigMetadata> ResourceValueConfigsMetadata {
      get { return resourceValueConfigsMetadata_; }
    }

    /// <summary>Field number for the "cloud_provider" field.</summary>
    public const int CloudProviderFieldNumber = 4;
    private global::Google.Cloud.SecurityCenter.V2.CloudProvider cloudProvider_ = global::Google.Cloud.SecurityCenter.V2.CloudProvider.Unspecified;
    /// <summary>
    /// Indicates which cloud provider was used in this simulation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.SecurityCenter.V2.CloudProvider CloudProvider {
      get { return cloudProvider_; }
      set {
        cloudProvider_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Simulation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Simulation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if(!resourceValueConfigsMetadata_.Equals(other.resourceValueConfigsMetadata_)) return false;
      if (CloudProvider != other.CloudProvider) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      hash ^= resourceValueConfigsMetadata_.GetHashCode();
      if (CloudProvider != global::Google.Cloud.SecurityCenter.V2.CloudProvider.Unspecified) hash ^= CloudProvider.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (createTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(CreateTime);
      }
      resourceValueConfigsMetadata_.WriteTo(output, _repeated_resourceValueConfigsMetadata_codec);
      if (CloudProvider != global::Google.Cloud.SecurityCenter.V2.CloudProvider.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) CloudProvider);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (createTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(CreateTime);
      }
      resourceValueConfigsMetadata_.WriteTo(ref output, _repeated_resourceValueConfigsMetadata_codec);
      if (CloudProvider != global::Google.Cloud.SecurityCenter.V2.CloudProvider.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) CloudProvider);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      size += resourceValueConfigsMetadata_.CalculateSize(_repeated_resourceValueConfigsMetadata_codec);
      if (CloudProvider != global::Google.Cloud.SecurityCenter.V2.CloudProvider.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) CloudProvider);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Simulation other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.createTime_ != null) {
        if (createTime_ == null) {
          CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreateTime.MergeFrom(other.CreateTime);
      }
      resourceValueConfigsMetadata_.Add(other.resourceValueConfigsMetadata_);
      if (other.CloudProvider != global::Google.Cloud.SecurityCenter.V2.CloudProvider.Unspecified) {
        CloudProvider = other.CloudProvider;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 26: {
            resourceValueConfigsMetadata_.AddEntriesFrom(input, _repeated_resourceValueConfigsMetadata_codec);
            break;
          }
          case 32: {
            CloudProvider = (global::Google.Cloud.SecurityCenter.V2.CloudProvider) input.ReadEnum();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 26: {
            resourceValueConfigsMetadata_.AddEntriesFrom(ref input, _repeated_resourceValueConfigsMetadata_codec);
            break;
          }
          case 32: {
            CloudProvider = (global::Google.Cloud.SecurityCenter.V2.CloudProvider) input.ReadEnum();
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
