﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.0.30319.33440.
// 
#pragma warning disable 1591

namespace UAOOI.SemanticData.UANodeSetValidation
{
  using System.Xml.Serialization;


  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd", IsNullable = false)]
  public partial class UANodeSet
  {

    private string[] namespaceUrisField;

    private string[] serverUrisField;

    private NodeIdAlias[] aliasesField;

    private System.Xml.XmlElement[] extensionsField;

    private UANode[] itemsField;

    private string versionField;

    private System.DateTime lastModifiedField;

    private bool lastModifiedFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Uri", IsNullable = false)]
    public string[] NamespaceUris
    {
      get
      {
        return this.namespaceUrisField;
      }
      set
      {
        this.namespaceUrisField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Uri", IsNullable = false)]
    public string[] ServerUris
    {
      get
      {
        return this.serverUrisField;
      }
      set
      {
        this.serverUrisField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Alias", IsNullable = false)]
    public NodeIdAlias[] Aliases
    {
      get
      {
        return this.aliasesField;
      }
      set
      {
        this.aliasesField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Extension", IsNullable = false)]
    public System.Xml.XmlElement[] Extensions
    {
      get
      {
        return this.extensionsField;
      }
      set
      {
        this.extensionsField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("UADataType", typeof(UADataType))]
    [System.Xml.Serialization.XmlElementAttribute("UAMethod", typeof(UAMethod))]
    [System.Xml.Serialization.XmlElementAttribute("UAObject", typeof(UAObject))]
    [System.Xml.Serialization.XmlElementAttribute("UAObjectType", typeof(UAObjectType))]
    [System.Xml.Serialization.XmlElementAttribute("UAReferenceType", typeof(UAReferenceType))]
    [System.Xml.Serialization.XmlElementAttribute("UAVariable", typeof(UAVariable))]
    [System.Xml.Serialization.XmlElementAttribute("UAVariableType", typeof(UAVariableType))]
    [System.Xml.Serialization.XmlElementAttribute("UAView", typeof(UAView))]
    public UANode[] Items
    {
      get
      {
        return this.itemsField;
      }
      set
      {
        this.itemsField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Version
    {
      get
      {
        return this.versionField;
      }
      set
      {
        this.versionField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime LastModified
    {
      get
      {
        return this.lastModifiedField;
      }
      set
      {
        this.lastModifiedField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool LastModifiedSpecified
    {
      get
      {
        return this.lastModifiedFieldSpecified;
      }
      set
      {
        this.lastModifiedFieldSpecified = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
  public partial class NodeIdAlias
  {

    private string aliasField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Alias
    {
      get
      {
        return this.aliasField;
      }
      set
      {
        this.aliasField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
  public partial class DataTypeField
  {

    private LocalizedText[] descriptionField;

    private DataTypeDefinition definitionField;

    private string nameField;

    private string symbolicNameField;

    private string dataTypeField;

    private int valueRankField;

    private int valueField;

    public DataTypeField()
    {
      this.dataTypeField = "i=24";
      this.valueRankField = -1;
      this.valueField = -1;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Description")]
    public LocalizedText[] Description
    {
      get
      {
        return this.descriptionField;
      }
      set
      {
        this.descriptionField = value;
      }
    }

    /// <remarks/>
    public DataTypeDefinition Definition
    {
      get
      {
        return this.definitionField;
      }
      set
      {
        this.definitionField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name
    {
      get
      {
        return this.nameField;
      }
      set
      {
        this.nameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SymbolicName
    {
      get
      {
        return this.symbolicNameField;
      }
      set
      {
        this.symbolicNameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute("i=24")]
    public string DataType
    {
      get
      {
        return this.dataTypeField;
      }
      set
      {
        this.dataTypeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(-1)]
    public int ValueRank
    {
      get
      {
        return this.valueRankField;
      }
      set
      {
        this.valueRankField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(-1)]
    public int Value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
  public partial class LocalizedText
  {

    private string localeField;

    private string valueField;

    public LocalizedText()
    {
      this.localeField = "";
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute("")]
    public string Locale
    {
      get
      {
        return this.localeField;
      }
      set
      {
        this.localeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
  public partial class DataTypeDefinition
  {

    private DataTypeField[] fieldField;

    private string nameField;

    private string baseTypeField;

    private string symbolicNameField;

    public DataTypeDefinition()
    {
      this.baseTypeField = "";
      this.symbolicNameField = "";
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Field")]
    public DataTypeField[] Field
    {
      get
      {
        return this.fieldField;
      }
      set
      {
        this.fieldField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name
    {
      get
      {
        return this.nameField;
      }
      set
      {
        this.nameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute("")]
    public string BaseType
    {
      get
      {
        return this.baseTypeField;
      }
      set
      {
        this.baseTypeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute("")]
    public string SymbolicName
    {
      get
      {
        return this.symbolicNameField;
      }
      set
      {
        this.symbolicNameField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
  public partial class StructureTranslationType
  {

    private LocalizedText[] textField;

    private string nameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Text")]
    public LocalizedText[] Text
    {
      get
      {
        return this.textField;
      }
      set
      {
        this.textField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name
    {
      get
      {
        return this.nameField;
      }
      set
      {
        this.nameField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
  public partial class TranslationType
  {

    private object[] itemsField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Field", typeof(StructureTranslationType))]
    [System.Xml.Serialization.XmlElementAttribute("Text", typeof(LocalizedText))]
    public object[] Items
    {
      get
      {
        return this.itemsField;
      }
      set
      {
        this.itemsField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
  public partial class Reference
  {

    private string referenceTypeField;

    private bool isForwardField;

    private string valueField;

    public Reference()
    {
      this.isForwardField = true;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ReferenceType
    {
      get
      {
        return this.referenceTypeField;
      }
      set
      {
        this.referenceTypeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool IsForward
    {
      get
      {
        return this.isForwardField;
      }
      set
      {
        this.isForwardField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(UAType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(UAReferenceType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(UADataType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(UAVariableType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(UAObjectType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(UAInstance))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(UAView))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(UAMethod))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(UAVariable))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(UAObject))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
  public partial class UANode
  {

    private LocalizedText[] displayNameField;

    private LocalizedText[] descriptionField;

    private Reference[] referencesField;

    private System.Xml.XmlElement[] extensionsField;

    private string nodeIdField;

    private string browseNameField;

    private uint writeMaskField;

    private uint userWriteMaskField;

    private string symbolicNameField;

    public UANode()
    {
      this.writeMaskField = ((uint)(0));
      this.userWriteMaskField = ((uint)(0));
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DisplayName")]
    public LocalizedText[] DisplayName
    {
      get
      {
        return this.displayNameField;
      }
      set
      {
        this.displayNameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Description")]
    public LocalizedText[] Description
    {
      get
      {
        return this.descriptionField;
      }
      set
      {
        this.descriptionField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
    public Reference[] References
    {
      get
      {
        return this.referencesField;
      }
      set
      {
        this.referencesField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Extension", IsNullable = false)]
    public System.Xml.XmlElement[] Extensions
    {
      get
      {
        return this.extensionsField;
      }
      set
      {
        this.extensionsField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NodeId
    {
      get
      {
        return this.nodeIdField;
      }
      set
      {
        this.nodeIdField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string BrowseName
    {
      get
      {
        return this.browseNameField;
      }
      set
      {
        this.browseNameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
    public uint WriteMask
    {
      get
      {
        return this.writeMaskField;
      }
      set
      {
        this.writeMaskField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
    public uint UserWriteMask
    {
      get
      {
        return this.userWriteMaskField;
      }
      set
      {
        this.userWriteMaskField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SymbolicName
    {
      get
      {
        return this.symbolicNameField;
      }
      set
      {
        this.symbolicNameField = value;
      }
    }
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(UAReferenceType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(UADataType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(UAVariableType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(UAObjectType))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
  public partial class UAType : UANode
  {

    private bool isAbstractField;

    public UAType()
    {
      this.isAbstractField = false;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool IsAbstract
    {
      get
      {
        return this.isAbstractField;
      }
      set
      {
        this.isAbstractField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
  public partial class UAReferenceType : UAType
  {

    private LocalizedText[] inverseNameField;

    private bool symmetricField;

    public UAReferenceType()
    {
      this.symmetricField = false;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("InverseName")]
    public LocalizedText[] InverseName
    {
      get
      {
        return this.inverseNameField;
      }
      set
      {
        this.inverseNameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool Symmetric
    {
      get
      {
        return this.symmetricField;
      }
      set
      {
        this.symmetricField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
  public partial class UADataType : UAType
  {

    private DataTypeDefinition definitionField;

    /// <remarks/>
    public DataTypeDefinition Definition
    {
      get
      {
        return this.definitionField;
      }
      set
      {
        this.definitionField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
  public partial class UAVariableType : UAType
  {

    private System.Xml.XmlElement valueField;

    private string dataTypeField;

    private int valueRankField;

    private string arrayDimensionsField;

    public UAVariableType()
    {
      this.dataTypeField = "i=24";
      this.valueRankField = -1;
      this.arrayDimensionsField = "";
    }

    /// <remarks/>
    public System.Xml.XmlElement Value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute("i=24")]
    public string DataType
    {
      get
      {
        return this.dataTypeField;
      }
      set
      {
        this.dataTypeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(-1)]
    public int ValueRank
    {
      get
      {
        return this.valueRankField;
      }
      set
      {
        this.valueRankField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
    [System.ComponentModel.DefaultValueAttribute("")]
    public string ArrayDimensions
    {
      get
      {
        return this.arrayDimensionsField;
      }
      set
      {
        this.arrayDimensionsField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
  public partial class UAObjectType : UAType
  {
  }

  /// <remarks/>
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(UAView))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(UAMethod))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(UAVariable))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(UAObject))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
  public partial class UAInstance : UANode
  {

    private string parentNodeIdField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ParentNodeId
    {
      get
      {
        return this.parentNodeIdField;
      }
      set
      {
        this.parentNodeIdField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
  public partial class UAView : UAInstance
  {

    private bool containsNoLoopsField;

    private byte eventNotifierField;

    public UAView()
    {
      this.containsNoLoopsField = false;
      this.eventNotifierField = ((byte)(0));
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool ContainsNoLoops
    {
      get
      {
        return this.containsNoLoopsField;
      }
      set
      {
        this.containsNoLoopsField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(typeof(byte), "0")]
    public byte EventNotifier
    {
      get
      {
        return this.eventNotifierField;
      }
      set
      {
        this.eventNotifierField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
  public partial class UAMethod : UAInstance
  {

    private bool executableField;

    private bool userExecutableField;

    private string methodDeclarationIdField;

    public UAMethod()
    {
      this.executableField = true;
      this.userExecutableField = true;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool Executable
    {
      get
      {
        return this.executableField;
      }
      set
      {
        this.executableField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool UserExecutable
    {
      get
      {
        return this.userExecutableField;
      }
      set
      {
        this.userExecutableField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string MethodDeclarationId
    {
      get
      {
        return this.methodDeclarationIdField;
      }
      set
      {
        this.methodDeclarationIdField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
  public partial class UAVariable : UAInstance
  {

    private System.Xml.XmlElement valueField;

    private TranslationType[] translationField;

    private string dataTypeField;

    private int valueRankField;

    private string arrayDimensionsField;

    private byte accessLevelField;

    private byte userAccessLevelField;

    private double minimumSamplingIntervalField;

    private bool historizingField;

    public UAVariable()
    {
      this.dataTypeField = "i=24";
      this.valueRankField = -1;
      this.arrayDimensionsField = "";
      this.accessLevelField = ((byte)(1));
      this.userAccessLevelField = ((byte)(1));
      this.minimumSamplingIntervalField = 0D;
      this.historizingField = false;
    }

    /// <remarks/>
    public System.Xml.XmlElement Value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Translation")]
    public TranslationType[] Translation
    {
      get
      {
        return this.translationField;
      }
      set
      {
        this.translationField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute("i=24")]
    public string DataType
    {
      get
      {
        return this.dataTypeField;
      }
      set
      {
        this.dataTypeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(-1)]
    public int ValueRank
    {
      get
      {
        return this.valueRankField;
      }
      set
      {
        this.valueRankField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
    [System.ComponentModel.DefaultValueAttribute("")]
    public string ArrayDimensions
    {
      get
      {
        return this.arrayDimensionsField;
      }
      set
      {
        this.arrayDimensionsField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(typeof(byte), "1")]
    public byte AccessLevel
    {
      get
      {
        return this.accessLevelField;
      }
      set
      {
        this.accessLevelField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(typeof(byte), "1")]
    public byte UserAccessLevel
    {
      get
      {
        return this.userAccessLevelField;
      }
      set
      {
        this.userAccessLevelField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(0D)]
    public double MinimumSamplingInterval
    {
      get
      {
        return this.minimumSamplingIntervalField;
      }
      set
      {
        this.minimumSamplingIntervalField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool Historizing
    {
      get
      {
        return this.historizingField;
      }
      set
      {
        this.historizingField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
  public partial class UAObject : UAInstance
  {

    private byte eventNotifierField;

    public UAObject()
    {
      this.eventNotifierField = ((byte)(0));
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(typeof(byte), "0")]
    public byte EventNotifier
    {
      get
      {
        return this.eventNotifierField;
      }
      set
      {
        this.eventNotifierField = value;
      }
    }
  }
}
#pragma warning restore 1591