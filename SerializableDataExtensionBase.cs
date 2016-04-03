﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using ICities;

namespace Runaurufu.ClimateControl
{
  public class ClimateControlSerializableData : SerializableDataExtensionBase
  {
    private const string KEY_HISTORY_DATA = "CLIMATE_CONTROL_HISTORICAL_DATA";
    private ISerializableData serializableData;

    public override void OnCreated(ISerializableData serializableData)
    {
      //base.OnCreated(serializableData);

      this.serializableData = serializableData;
    }

    public override void OnLoadData()
    {
      //base.OnLoadData();

      byte[] historyData = serializableData.LoadData(ClimateControlSerializableData.KEY_HISTORY_DATA);
      if(historyData != null && historyData.Length > 0)
      {
        HistoryData history = Deserialize<HistoryData>(historyData);
        if(history != null)
        {
          ClimateControlEngine.Instance.HistoricalData = history;

          //if (history.YearlyData != null)
          //{
          //  DebugOutputPanel.AddMessage(ColossalFramework.Plugins.PluginManager.MessageType.Message, history.YearlyData.Count.ToString());
          //  foreach (YearlyStatisticData yitem in history.YearlyData)
          //  {
          //    DebugOutputPanel.AddMessage(ColossalFramework.Plugins.PluginManager.MessageType.Message, "YEAR " + yitem.Year.ToString());
          //    if (yitem.WeeklyData != null)
          //    {
          //      foreach (WeeklyStatisticData witem in yitem.WeeklyData)
          //      {
          //        if (witem == null)
          //          continue;
          //        DebugOutputPanel.AddMessage(ColossalFramework.Plugins.PluginManager.MessageType.Message, "WEEK " + witem.WeekIndex.ToString());
          //        DebugOutputPanel.AddMessage(ColossalFramework.Plugins.PluginManager.MessageType.Message, "Tav " + witem.TemperatureAverage.ToString());
          //        DebugOutputPanel.AddMessage(ColossalFramework.Plugins.PluginManager.MessageType.Message, "P " + witem.PrecipitationAmount.ToString());
          //      }
          //    }
          //  }
          //}
        }
      }
    }

    public override void OnSaveData()
    {
      //base.OnSaveData();

      if (ClimateControlEngine.Instance.HistoricalData != null)
      {
        byte[] data = Serialize(ClimateControlEngine.Instance.HistoricalData);
        if (data != null)
        {
          serializableData.SaveData(ClimateControlSerializableData.KEY_HISTORY_DATA, data);
        }

        //if (ClimateControlEngine.Instance.HistoricalData.YearlyData != null)
        //{
        //  DebugOutputPanel.AddMessage(ColossalFramework.Plugins.PluginManager.MessageType.Message, ClimateControlEngine.Instance.HistoricalData.YearlyData.Count.ToString());
        //  foreach (YearlyStatisticData yitem in ClimateControlEngine.Instance.HistoricalData.YearlyData)
        //  {
        //    DebugOutputPanel.AddMessage(ColossalFramework.Plugins.PluginManager.MessageType.Message, "YEAR " + yitem.Year.ToString());
        //    if (yitem.WeeklyData != null)
        //    {
        //      foreach (WeeklyStatisticData witem in yitem.WeeklyData)
        //      {
        //        if (witem == null)
        //          continue;
        //        DebugOutputPanel.AddMessage(ColossalFramework.Plugins.PluginManager.MessageType.Message, "WEEK " + witem.WeekIndex.ToString());
        //        DebugOutputPanel.AddMessage(ColossalFramework.Plugins.PluginManager.MessageType.Message, "Tav " + witem.TemperatureAverage.ToString());
        //        DebugOutputPanel.AddMessage(ColossalFramework.Plugins.PluginManager.MessageType.Message, "P " + witem.PrecipitationAmount.ToString());
        //      }
        //    }
        //  }
        //}
      }
    }

    public static byte[] Serialize(object item)
    {
      BinaryFormatter binaryFormatter = new BinaryFormatter();
      using (MemoryStream memoryStream = new MemoryStream())
      {
        try
        {
          binaryFormatter.Serialize(memoryStream, item);
          memoryStream.Position = 0L;
          return memoryStream.ToArray();
        }
        catch(Exception ex)
        {

        }
        return null;
      }
    }

    public static T Deserialize<T>(byte[] data) where T : class
    {
      BinaryFormatter binaryFormatter = new BinaryFormatter();
      using (MemoryStream memoryStream = new MemoryStream())
      {
        memoryStream.Write(data, 0, data.Length);
        memoryStream.Position = 0L;
        try
        {
          return binaryFormatter.Deserialize(memoryStream) as T;
        }
        catch (Exception ex)
        {

        }
        return null;
      }
    }
  }
}
