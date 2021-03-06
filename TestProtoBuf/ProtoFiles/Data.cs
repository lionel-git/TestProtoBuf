// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Data.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from Data.proto</summary>
public static partial class DataReflection {

  #region Descriptor
  /// <summary>File descriptor for Data.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static DataReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CgpEYXRhLnByb3RvIicKCHN1YmZpZWxkEgoKAmlkGAEgASgFEg8KB2NvbnRl",
          "bnQYAiABKAwidwoNU2VhcmNoUmVxdWVzdBINCgVxdWVyeRgBIAEoCRITCgtw",
          "YWdlX251bWJlchgCIAEoBRIXCg9yZXN1bHRfcGVyX3BhZ2UYAyABKAUSDAoE",
          "ZGF0YRgEIAEoDBIbCghjb250ZW50cxgFIAMoCzIJLnN1YmZpZWxkIi0KB0Nv",
          "bnRlbnQSDQoFdmFsdWUYASABKAUSEwoLZGVzY3JpcHRpb24YAiABKAkiMgoG",
          "TXlEYXRhEgwKBG5hbWUYASABKAkSGgoIY29udGVudHMYAiADKAsyCC5Db250",
          "ZW50KjEKBk15RW51bRIKCgZEX1RFU1QQABIMCghEX01PTkRBWRABEg0KCURf",
          "VFVFU0RBWRACYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(new[] {typeof(global::MyEnum), }, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::subfield), global::subfield.Parser, new[]{ "Id", "Content" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::SearchRequest), global::SearchRequest.Parser, new[]{ "Query", "PageNumber", "ResultPerPage", "Data", "Contents" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::Content), global::Content.Parser, new[]{ "Value", "Description" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::MyData), global::MyData.Parser, new[]{ "Name", "Contents" }, null, null, null)
        }));
  }
  #endregion

}
#region Enums
public enum MyEnum {
  [pbr::OriginalName("D_TEST")] DTest = 0,
  [pbr::OriginalName("D_MONDAY")] DMonday = 1,
  [pbr::OriginalName("D_TUESDAY")] DTuesday = 2,
}

#endregion

#region Messages
public sealed partial class subfield : pb::IMessage<subfield> {
  private static readonly pb::MessageParser<subfield> _parser = new pb::MessageParser<subfield>(() => new subfield());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<subfield> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::DataReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public subfield() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public subfield(subfield other) : this() {
    id_ = other.id_;
    content_ = other.content_;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public subfield Clone() {
    return new subfield(this);
  }

  /// <summary>Field number for the "id" field.</summary>
  public const int IdFieldNumber = 1;
  private int id_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int Id {
    get { return id_; }
    set {
      id_ = value;
    }
  }

  /// <summary>Field number for the "content" field.</summary>
  public const int ContentFieldNumber = 2;
  private pb::ByteString content_ = pb::ByteString.Empty;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pb::ByteString Content {
    get { return content_; }
    set {
      content_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as subfield);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(subfield other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Id != other.Id) return false;
    if (Content != other.Content) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Id != 0) hash ^= Id.GetHashCode();
    if (Content.Length != 0) hash ^= Content.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Id != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(Id);
    }
    if (Content.Length != 0) {
      output.WriteRawTag(18);
      output.WriteBytes(Content);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Id != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
    }
    if (Content.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeBytesSize(Content);
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(subfield other) {
    if (other == null) {
      return;
    }
    if (other.Id != 0) {
      Id = other.Id;
    }
    if (other.Content.Length != 0) {
      Content = other.Content;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          input.SkipLastField();
          break;
        case 8: {
          Id = input.ReadInt32();
          break;
        }
        case 18: {
          Content = input.ReadBytes();
          break;
        }
      }
    }
  }

}

public sealed partial class SearchRequest : pb::IMessage<SearchRequest> {
  private static readonly pb::MessageParser<SearchRequest> _parser = new pb::MessageParser<SearchRequest>(() => new SearchRequest());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<SearchRequest> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::DataReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SearchRequest() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SearchRequest(SearchRequest other) : this() {
    query_ = other.query_;
    pageNumber_ = other.pageNumber_;
    resultPerPage_ = other.resultPerPage_;
    data_ = other.data_;
    contents_ = other.contents_.Clone();
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SearchRequest Clone() {
    return new SearchRequest(this);
  }

  /// <summary>Field number for the "query" field.</summary>
  public const int QueryFieldNumber = 1;
  private string query_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Query {
    get { return query_; }
    set {
      query_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "page_number" field.</summary>
  public const int PageNumberFieldNumber = 2;
  private int pageNumber_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int PageNumber {
    get { return pageNumber_; }
    set {
      pageNumber_ = value;
    }
  }

  /// <summary>Field number for the "result_per_page" field.</summary>
  public const int ResultPerPageFieldNumber = 3;
  private int resultPerPage_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int ResultPerPage {
    get { return resultPerPage_; }
    set {
      resultPerPage_ = value;
    }
  }

  /// <summary>Field number for the "data" field.</summary>
  public const int DataFieldNumber = 4;
  private pb::ByteString data_ = pb::ByteString.Empty;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pb::ByteString Data {
    get { return data_; }
    set {
      data_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "contents" field.</summary>
  public const int ContentsFieldNumber = 5;
  private static readonly pb::FieldCodec<global::subfield> _repeated_contents_codec
      = pb::FieldCodec.ForMessage(42, global::subfield.Parser);
  private readonly pbc::RepeatedField<global::subfield> contents_ = new pbc::RepeatedField<global::subfield>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::RepeatedField<global::subfield> Contents {
    get { return contents_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as SearchRequest);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(SearchRequest other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Query != other.Query) return false;
    if (PageNumber != other.PageNumber) return false;
    if (ResultPerPage != other.ResultPerPage) return false;
    if (Data != other.Data) return false;
    if(!contents_.Equals(other.contents_)) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Query.Length != 0) hash ^= Query.GetHashCode();
    if (PageNumber != 0) hash ^= PageNumber.GetHashCode();
    if (ResultPerPage != 0) hash ^= ResultPerPage.GetHashCode();
    if (Data.Length != 0) hash ^= Data.GetHashCode();
    hash ^= contents_.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Query.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Query);
    }
    if (PageNumber != 0) {
      output.WriteRawTag(16);
      output.WriteInt32(PageNumber);
    }
    if (ResultPerPage != 0) {
      output.WriteRawTag(24);
      output.WriteInt32(ResultPerPage);
    }
    if (Data.Length != 0) {
      output.WriteRawTag(34);
      output.WriteBytes(Data);
    }
    contents_.WriteTo(output, _repeated_contents_codec);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Query.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Query);
    }
    if (PageNumber != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(PageNumber);
    }
    if (ResultPerPage != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(ResultPerPage);
    }
    if (Data.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeBytesSize(Data);
    }
    size += contents_.CalculateSize(_repeated_contents_codec);
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(SearchRequest other) {
    if (other == null) {
      return;
    }
    if (other.Query.Length != 0) {
      Query = other.Query;
    }
    if (other.PageNumber != 0) {
      PageNumber = other.PageNumber;
    }
    if (other.ResultPerPage != 0) {
      ResultPerPage = other.ResultPerPage;
    }
    if (other.Data.Length != 0) {
      Data = other.Data;
    }
    contents_.Add(other.contents_);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          input.SkipLastField();
          break;
        case 10: {
          Query = input.ReadString();
          break;
        }
        case 16: {
          PageNumber = input.ReadInt32();
          break;
        }
        case 24: {
          ResultPerPage = input.ReadInt32();
          break;
        }
        case 34: {
          Data = input.ReadBytes();
          break;
        }
        case 42: {
          contents_.AddEntriesFrom(input, _repeated_contents_codec);
          break;
        }
      }
    }
  }

}

public sealed partial class Content : pb::IMessage<Content> {
  private static readonly pb::MessageParser<Content> _parser = new pb::MessageParser<Content>(() => new Content());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<Content> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::DataReflection.Descriptor.MessageTypes[2]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Content() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Content(Content other) : this() {
    value_ = other.value_;
    description_ = other.description_;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Content Clone() {
    return new Content(this);
  }

  /// <summary>Field number for the "value" field.</summary>
  public const int ValueFieldNumber = 1;
  private int value_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int Value {
    get { return value_; }
    set {
      value_ = value;
    }
  }

  /// <summary>Field number for the "description" field.</summary>
  public const int DescriptionFieldNumber = 2;
  private string description_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Description {
    get { return description_; }
    set {
      description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as Content);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(Content other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Value != other.Value) return false;
    if (Description != other.Description) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Value != 0) hash ^= Value.GetHashCode();
    if (Description.Length != 0) hash ^= Description.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Value != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(Value);
    }
    if (Description.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Description);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Value != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Value);
    }
    if (Description.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(Content other) {
    if (other == null) {
      return;
    }
    if (other.Value != 0) {
      Value = other.Value;
    }
    if (other.Description.Length != 0) {
      Description = other.Description;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          input.SkipLastField();
          break;
        case 8: {
          Value = input.ReadInt32();
          break;
        }
        case 18: {
          Description = input.ReadString();
          break;
        }
      }
    }
  }

}

public sealed partial class MyData : pb::IMessage<MyData> {
  private static readonly pb::MessageParser<MyData> _parser = new pb::MessageParser<MyData>(() => new MyData());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<MyData> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::DataReflection.Descriptor.MessageTypes[3]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public MyData() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public MyData(MyData other) : this() {
    name_ = other.name_;
    contents_ = other.contents_.Clone();
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public MyData Clone() {
    return new MyData(this);
  }

  /// <summary>Field number for the "name" field.</summary>
  public const int NameFieldNumber = 1;
  private string name_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Name {
    get { return name_; }
    set {
      name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "contents" field.</summary>
  public const int ContentsFieldNumber = 2;
  private static readonly pb::FieldCodec<global::Content> _repeated_contents_codec
      = pb::FieldCodec.ForMessage(18, global::Content.Parser);
  private readonly pbc::RepeatedField<global::Content> contents_ = new pbc::RepeatedField<global::Content>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::RepeatedField<global::Content> Contents {
    get { return contents_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as MyData);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(MyData other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Name != other.Name) return false;
    if(!contents_.Equals(other.contents_)) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Name.Length != 0) hash ^= Name.GetHashCode();
    hash ^= contents_.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Name.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Name);
    }
    contents_.WriteTo(output, _repeated_contents_codec);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Name.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
    }
    size += contents_.CalculateSize(_repeated_contents_codec);
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(MyData other) {
    if (other == null) {
      return;
    }
    if (other.Name.Length != 0) {
      Name = other.Name;
    }
    contents_.Add(other.contents_);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          input.SkipLastField();
          break;
        case 10: {
          Name = input.ReadString();
          break;
        }
        case 18: {
          contents_.AddEntriesFrom(input, _repeated_contents_codec);
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
