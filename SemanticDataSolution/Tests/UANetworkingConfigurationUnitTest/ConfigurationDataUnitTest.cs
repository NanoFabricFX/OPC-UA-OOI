﻿
using CAS.UA.IServerConfiguration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml;
using UAOOI.DataBindings.Serializers;
using UAOOI.SemanticData.UANetworking.Configuration.Serialization;

namespace UAOOI.SemanticData.UANetworking.Configuration.UnitTest
{

  [TestClass]
  [DeploymentItem(@"TestData\", @"TestData\")]
  public class ConfigurationDataUnitTest
  {
    #region TestMethod
    [TestMethod]
    [TestCategory("Configuration_ConfigurationDataUnitTest")]
    public void LoadSaveTestMethod()
    {
      LocalConfigurationData _configuration = ConfigurationData.Load<LocalConfigurationData>(LocalConfigurationData.Loader, () => { });
      Assert.IsNotNull(_configuration);
      Assert.AreEqual<int>(1, _configuration.OnLoadedCount);
      Assert.AreEqual<int>(0, _configuration.OnSavingCount);
      LocalConfigurationData.Save<LocalConfigurationData>(_configuration, (x) => { Assert.AreEqual<int>(1, x.OnSavingCount); });
    }
    //[TestMethod]
    //[TestCategory("Configuration_SerializationUnitTest")]
    //public void ConfigurationDataConsumerXmlTestMethod()
    //{
    //  FileInfo _configFile = new FileInfo(@"TestData\ConfigurationDataConsumer.xml");
    //  Assert.IsTrue(_configFile.Exists);
    //  string _message = null;
    //  ConfigurationData _cd = ConfigurationData.Load<ConfigurationData>
    //    (() => XmlDataContractSerializers.Load<ConfigurationData>(_configFile, (x, y, z) => { _message = z; Assert.AreEqual<TraceEventType>(TraceEventType.Verbose, x); }), () => { });
    //  Console.WriteLine(_message);
    //  Assert.IsNotNull(_cd);
    //  Assert.IsFalse(String.IsNullOrEmpty(_message));
    //  Assert.IsTrue(_message.Contains(_configFile.FullName));
    //}
    //[TestMethod]
    //[TestCategory("Configuration_SerializationUnitTest")]
    //public void ConfigurationDataProducerXmlTestMethod()
    //{
    //  FileInfo _configFile = new FileInfo(@"TestData\ConfigurationDataProducer.xml");
    //  Assert.IsTrue(_configFile.Exists);
    //  string _message = null;
    //  ConfigurationData _cd = ConfigurationData.Load<ConfigurationData>
    //    (() => XmlDataContractSerializers.Load<ConfigurationData>(_configFile, (x, y, z) => { _message = z; Assert.AreEqual<TraceEventType>(TraceEventType.Verbose, x); }), () => { });
    //  Console.WriteLine(_message);
    //  Assert.IsNotNull(_cd);
    //  Assert.IsFalse(String.IsNullOrEmpty(_message));
    //  Assert.IsTrue(_message.Contains(_configFile.FullName));
    //}
    [TestMethod]
    [TestCategory("Configuration_ConfigurationDataUnitTest")]
    public void SaveLoadTestMethod()
    {
      SaveLoadConfigurationData(Role.Consumer, SerializerType.Xml);
      SaveLoadConfigurationData(Role.Consumer, SerializerType.Json);
      SaveLoadConfigurationData(Role.Producer, SerializerType.Xml);
      SaveLoadConfigurationData(Role.Producer, SerializerType.Json);
    }
    [TestMethod]
    [TestCategory("Configuration_SerializationUnitTest")]
    public void LoadUsingSerializerTestMethod()
    {
      LoadUsingSerializer(Role.Consumer, SerializerType.Xml);
      LoadUsingSerializer(Role.Consumer, SerializerType.Json);
      LoadUsingSerializer(Role.Producer, SerializerType.Xml);
      LoadUsingSerializer(Role.Producer, SerializerType.Json);
    }
    #endregion

    #region private
    private class LocalConfigurationData : ConfigurationData
    {
      #region test data
      internal int OnLoadedCount = 0;
      internal int OnSavingCount = 0;

      #endregion
      internal static LocalConfigurationData Loader()
      {
        return new LocalConfigurationData();
      }
      internal LocalConfigurationData() { }
      protected override void OnLoaded()
      {
        base.OnLoaded();
        OnLoadedCount++;
      }
      protected override void OnSaving()
      {
        base.OnSaving();
        OnSavingCount++;
      }
    }
    private void Compare(ConfigurationData _consumer, ConfigurationData _mirror)
    {
      Assert.AreEqual<int>(_consumer.DataSets.Length, _mirror.DataSets.Length);
      Assert.AreEqual<int>(_consumer.MessageHandlers.Length, _mirror.MessageHandlers.Length);
      Compare(_consumer.DataSets, _mirror.DataSets);
    }
    private void Compare(DataSetConfiguration[] dataSets1, DataSetConfiguration[] dataSets2)
    {
      Dictionary<string, DataSetConfiguration> _dataSets2Dictionary = dataSets2.ToDictionary<DataSetConfiguration, string>(x => x.AssociationName);
      foreach (DataSetConfiguration item in dataSets1)
        Compare(item, _dataSets2Dictionary[item.AssociationName]);
    }
    private void Compare(DataSetConfiguration item1, DataSetConfiguration item2)
    {
      Assert.AreEqual<AssociationRole>(item1.AssociationRole, item2.AssociationRole);
      Assert.AreEqual<string>(item1.DataSymbolicName, item2.DataSymbolicName);
      Assert.AreEqual<string>(item1.Guid, item2.Guid);
      Assert.AreEqual<string>(item1.InformationModelURI, item2.InformationModelURI);
      Assert.AreEqual<string>(item1.RepositoryGroup, item2.RepositoryGroup);
      Compare(item1.Root, item2.Root);
    }
    private void Compare(NodeDescriptor item1, NodeDescriptor item2)
    {
      if (item1 == null && item2 == null)
        return;
      Assert.IsNotNull(item1);
      Assert.IsNotNull(item2);
      Assert.AreEqual<string>(item1.BindingDescription, item2.BindingDescription);
      Assert.AreEqual<XmlQualifiedName>(item1.DataType, item2.DataType);
      Assert.AreEqual<bool>(item1.InstanceDeclaration, item2.InstanceDeclaration);
      Assert.AreEqual<InstanceNodeClassesEnum>(item1.NodeClass, item2.NodeClass);
      Assert.AreEqual<XmlQualifiedName>(item1.NodeIdentifier, item2.NodeIdentifier);
      Assert.AreEqual<string>(item1.ToString(), item2.ToString());
    }
    private enum Role { Producer, Consumer };
    private void SaveLoadConfigurationData(Role role, SerializerType serializer)
    {
      FileInfo _fileInfo = GetFileName(role, serializer, @"ConfigurationData{0}.{1}");
      ConfigurationData _configuration = null;
      switch (role)
      {
        case Role.Producer:
          _configuration = ReferenceConfiguration.LoadProducer();
          break;
        case Role.Consumer:
          _configuration = ReferenceConfiguration.LoadConsumer();
          break;
        default:
          break;
      }
      ConfigurationData.Save<ConfigurationData>(_configuration, serializer, _fileInfo, (x, y, z) => { Console.WriteLine(z); });
      _fileInfo.Refresh();
      Assert.IsTrue(_fileInfo.Exists);
      ConfigurationData _mirror = ConfigurationData.Load<ConfigurationData>(serializer, _fileInfo, (x, y, z) => { Console.WriteLine(z); }, () => { });
      Compare(_configuration, _mirror);
    }
    private void LoadUsingSerializer(Role role, SerializerType serializer)
    {
      FileInfo _fileInfo = GetFileName(role, serializer, @"TestData\ConfigurationData{0}.{1}");
      Assert.IsTrue(_fileInfo.Exists, _fileInfo.ToString());
      ConfigurationData _cd = null;
      string _message = null;
      switch (serializer)
      {
        case SerializerType.Json:
          _cd = ConfigurationData.Load<ConfigurationData>
            (() => JSONDataContractSerializers.Load<ConfigurationData>(_fileInfo, (x, y, z) => { _message = z; Assert.AreEqual<TraceEventType>(TraceEventType.Verbose, x); }), () => { });
          break;
        case SerializerType.Xml:
          _cd = ConfigurationData.Load<ConfigurationData>
            (() => XmlDataContractSerializers.Load<ConfigurationData>(_fileInfo, (x, y, z) => { _message = z; Assert.AreEqual<TraceEventType>(TraceEventType.Verbose, x); }), () => { });
          break;
      }
      Console.WriteLine(_message);
      Assert.IsNotNull(_cd);
      Assert.IsFalse(String.IsNullOrEmpty(_message));
      Assert.IsTrue(_message.Contains(_fileInfo.FullName));
    }
    private static FileInfo GetFileName(Role role, SerializerType serializer, string fileNameTemplate)
    {
      string _extension = serializer == SerializerType.Xml ? "xml" : "json";
      string _fileName = String.Format(fileNameTemplate, role, _extension);
      return new FileInfo(_fileName);
    }
    #endregion
  }
}
