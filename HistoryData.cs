using System;
using System.Collections.Generic;
using UnityEngine;

namespace Runaurufu.ClimateControl
{
  [Serializable]
  public class HistoryData
  {
    public HistoryData()
    {
      this.YearlyData = new List<YearlyStatisticData>();
    }

    public List<YearlyStatisticData> YearlyData { get; set; }

    public YearlyStatisticData GetYearData(DateTime dateTime, bool makeIfNotExist)
    {
      return this.GetYearData((ushort)dateTime.Year, makeIfNotExist);
    }

    public YearlyStatisticData GetYearData(ushort year, bool makeIfNotExist)
    {
      if (this.YearlyData == null)
        this.YearlyData = new List<YearlyStatisticData>();

      for (int i = 0; i < this.YearlyData.Count; i++)
      {
        if (this.YearlyData[i] == null)
        {
          this.YearlyData.RemoveAt(i);
          i--;
          continue;
        }

        if (this.YearlyData[i].Year == year)
          return this.YearlyData[i];
      }

      if (makeIfNotExist)
      {
        YearlyStatisticData data = new YearlyStatisticData(year);
        this.YearlyData.Add(data);
        return data;
      }
      return null;
    }

    public WeeklyStatisticData GetCombinedWeeklyData(ushort weekIndex, ushort ommitYear)
    {
      if (this.YearlyData == null)
        this.YearlyData = new List<YearlyStatisticData>();

      List<WeeklyStatisticData> weeklyData = new List<WeeklyStatisticData>();
      foreach (YearlyStatisticData yearItem in this.YearlyData)
      {
        if (yearItem.Year == ommitYear)
          continue;

        WeeklyStatisticData weekData = yearItem.GetWeekData(weekIndex, false);
        if (weekData != null)
          weeklyData.Add(weekData);
      }

      if (weeklyData.Count == 0)
        return null;

      WeeklyStatisticData combinedData = new WeeklyStatisticData() { WeekIndex = weekIndex };
      combinedData.TemperatureMin = float.MaxValue;
      combinedData.TemperatureMax = float.MinValue;

      double tempAverage = 0;
      double precipitationAmount = 0;
      double precipitationDuration = 0;
      double fogDuration = 0;
      foreach (WeeklyStatisticData weekItem in weeklyData)
      {
        combinedData.TemperatureMin = Math.Min(combinedData.TemperatureMin, weekItem.TemperatureMin);
        combinedData.TemperatureMax = Math.Max(combinedData.TemperatureMax, weekItem.TemperatureMax);
        tempAverage += weekItem.TemperatureAverage;

        precipitationAmount += weekItem.PrecipitationAmount;
        precipitationDuration += weekItem.PrecipitationDuration;

        fogDuration += weekItem.FogDuration;
      }

      combinedData.TemperatureAverage = (float)(tempAverage / weeklyData.Count);
      combinedData.PrecipitationAmount = (float)(precipitationAmount / weeklyData.Count);
      combinedData.PrecipitationDuration = (float)(precipitationDuration / weeklyData.Count);
      combinedData.FogDuration = (float)(fogDuration / weeklyData.Count);

      return combinedData;
    }
  }

  [Serializable]
  public class YearlyStatisticData
  {
    public ushort Year { get; set; }

    public WeeklyStatisticData[] WeeklyData { get; set; }

    public YearlyStatisticData()
    {
    }

    public YearlyStatisticData(ushort year)
    {
      this.Year = year;
      this.WeeklyData = new WeeklyStatisticData[53];
    }

    public WeeklyStatisticData GetWeekData(DateTime dateTime, bool makeIfNotExist)
    {
      int weekIndex = Mathf.FloorToInt(dateTime.DayOfYear / 7f);
      return this.GetWeekData((ushort)weekIndex, makeIfNotExist);
    }

    public WeeklyStatisticData GetWeekData(ushort weekIndex, bool makeIfNotExist)
    {
      if (this.WeeklyData == null)
        this.WeeklyData = new WeeklyStatisticData[53];

      if (WeeklyData.Length <= weekIndex || weekIndex < 0)
      {
        if (makeIfNotExist)
          throw new ArgumentOutOfRangeException("weekIndex");
        return null;
      }

      if (this.WeeklyData[weekIndex] == null && makeIfNotExist)
        this.WeeklyData[weekIndex] = new WeeklyStatisticData() { WeekIndex = weekIndex };

      return this.WeeklyData[weekIndex];
    }
  }

  [Serializable]
  public class WeeklyStatisticData
  {
    public ushort WeekIndex { get; set; }

    public float TemperatureMin { get; set; }
    public float TemperatureMax { get; set; }
    public float TemperatureAverage { get; set; }

    public float PrecipitationAmount { get; set; }
    public float PrecipitationDuration { get; set; }

    public float FogDuration { get; set; }
  }
}