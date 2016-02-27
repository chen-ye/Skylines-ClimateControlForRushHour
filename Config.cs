using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using UnityEngine;

namespace Runaurufu.ClimateControl
{
  //public static class LocalConfig
  //{
  //  private static readonly string ConfigName = Assembly.GetExecutingAssembly().GetName().Name;
  //  private static readonly string ConfigNamePrefix = ConfigName + ".";

  //  private static int? _fontSize;

  //  public static int FontSize
  //  {
  //    get
  //    {
  //      if (!LocalConfig._fontSize.HasValue)
  //        LocalConfig._fontSize = new int?(PlayerPrefs.GetInt(ConfigNamePrefix + "FONT_SIZE", 0));
  //      return LocalConfig._fontSize.Value;
  //    }
  //    set
  //    {
  //      if (value > 2)
  //        throw new ArgumentOutOfRangeException();
  //      int num = value;
  //      int? nullable = LocalConfig._fontSize;
  //      int valueOrDefault = nullable.GetValueOrDefault();
  //      if ((num == valueOrDefault ? (nullable.HasValue ? 1 : 0) : 0) != 0)
  //        return;
  //      PlayerPrefs.SetInt("PE_FONT_SIZE", value);
  //      LocalConfig._fontSize = new int?(value);
  //    }
  //  }
  //}

  [Serializable]
  public class GlobalConfig //: IXmlSerializable
  {
    internal static readonly string ConfigName = Assembly.GetExecutingAssembly().GetName().Name;
    private static readonly string ConfigFileName = ConfigName + ".config";

    private static GlobalConfig instance;
    public static GlobalConfig GetInstance()
    {
      if (instance == null)
        LoadConfig();

      if (instance == null)
        instance = new GlobalConfig();

      return instance;
    }

    public GlobalConfig()
    {
      this.SelectedClimatePresetCode = ModSettings.DEFAULT_PRESET_CODE;
      this.ChirpForecast = true;
      this.AlterSnowDumpSnowMelting = true;
      this.ThundersFrequency = Frequency.OnAverage;
    //  this.WeatherAlterFires = false;
    }

    public string SelectedClimatePresetCode { get; set; }

    //public enum TimeType
    //{
    //  /// <summary>
    //  /// It is simulation time.
    //  /// </summary>
    //  SimulationTime = 0,
    //  /// <summary>
    //  /// It is day/night cycle time.
    //  /// </summary>
    //  SunTime = 1,
    //  /// <summary>
    //  /// It is your workstation time.
    //  /// </summary>
    //  RealTime = 2,
    //}
    ///// <summary>
    ///// What type of time should engine use to calculate day time.
    ///// </summary>
    //public TimeType TimeToUse { get; set; }

    /// <summary>
    /// Should forecast be chirped?
    /// </summary>
    public Boolean ChirpForecast { get; set; }

    /// <summary>
    /// Alter snowDump snow melting?
    /// </summary>
    public Boolean AlterSnowDumpSnowMelting { get; set; }

    /// <summary>
    /// How often thunders shall strike?
    /// </summary>
    public Frequency ThundersFrequency { get; set; }

    ///// <summary>
    ///// Should weather change how fires go?
    ///// </summary>
    //public Boolean WeatherAlterFires { get; set; }

    //#region IXmlSerializable
    //public XmlSchema GetSchema()
    //{
    //  return null;
    //}

    //public void ReadXml(System.Xml.XmlReader reader)
    //{
    //  bool wasEmpty = reader.IsEmptyElement;
    //  reader.Read();

    //  if (wasEmpty)
    //    return;

    //  XmlSerializer intSerializer = new XmlSerializer(typeof(int));
    //  XmlSerializer stringSerializer = new XmlSerializer(typeof(string));

    //  reader.ReadStartElement("__version__");
    //  int serializationVersion = (int)intSerializer.Deserialize(reader);
    //  reader.ReadEndElement();

    //  if (serializationVersion >= 1)
    //  {
    //    reader.ReadStartElement("SelectedClimatePresetCode");
    //    SelectedClimatePresetCode = (string)stringSerializer.Deserialize(reader);
    //    reader.ReadEndElement();

    //    reader.ReadStartElement("TimeToUse");
    //    TimeToUse = (TimeType)intSerializer.Deserialize(reader);
    //    reader.ReadEndElement();
    //  }

    //  reader.ReadEndElement();
    //}

    //public void WriteXml(System.Xml.XmlWriter writer)
    //{
    //  XmlSerializer intSerializer = new XmlSerializer(typeof(int));
    //  XmlSerializer stringSerializer = new XmlSerializer(typeof(string));

    //  Int64 serializationVersion = 1;
    //  writer.WriteStartElement("__version__");
    //  intSerializer.Serialize(writer, serializationVersion);
    //  writer.WriteEndElement();

    //  writer.WriteStartElement("SelectedClimatePresetCode");
    //  stringSerializer.Serialize(writer, SelectedClimatePresetCode);
    //  writer.WriteEndElement();

    //  writer.WriteStartElement("TimeToUse");
    //  intSerializer.Serialize(writer, (int)TimeToUse);
    //  writer.WriteEndElement();
    //}
    //#endregion

    public static void LoadConfig()
    {
      if (File.Exists(GlobalConfig.ConfigFileName) == false)
        return;

      try
      {
        XmlSerializer serializer = new XmlSerializer(typeof(GlobalConfig));
        using (XmlReader xmlReader = XmlReader.Create(GlobalConfig.ConfigFileName))
          instance = (GlobalConfig)serializer.Deserialize(xmlReader);

        //using (FileStream stream = File.Open(GlobalConfig.ConfigFileName, FileMode.Open))
        //{
        //  XmlSerializer serializer = new XmlSerializer(typeof(GlobalConfig));
        //  XmlReaderSettings settings = new XmlReaderSettings();
        //  // No settings need modifying here

        //  using (XmlReader xmlReader = XmlReader.Create(stream, settings))
        //  {
        //    return (GlobalConfig)serializer.Deserialize(xmlReader);
        //  }
        //}
      }
      catch (Exception ex)
      {
        instance = new GlobalConfig() { SelectedClimatePresetCode = ex.Message };
      }
    }

    public static bool SaveConfig()
    {
      if (instance == null)
        return false;

      try
      {
        XmlSerializer serializer = new XmlSerializer(typeof(GlobalConfig));
        using (XmlWriter xmlWriter = XmlWriter.Create(GlobalConfig.ConfigFileName))
          serializer.Serialize(xmlWriter, instance);

        //using (FileStream stream = File.Create(GlobalConfig.ConfigFileName))
        //{
        //  XmlSerializer serializer = new XmlSerializer(typeof(GlobalConfig));
        //  XmlWriterSettings settings = new XmlWriterSettings();
        //  settings.Encoding = new ASCIIEncoding();// new UnicodeEncoding(false, false); // no BOM in a .NET string
        //  settings.Indent = true;
        //  settings.OmitXmlDeclaration = false;

        //  using (XmlWriter xmlWriter = XmlWriter.Create(stream, settings))
        //  {
        //    serializer.Serialize(xmlWriter, instance);
        //  }
        //}
      }
      catch (Exception ex)
      {
        return false;
      }
      return true;
    }
  }
}
