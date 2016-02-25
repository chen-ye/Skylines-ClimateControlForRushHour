﻿using System;
using System.Linq;
using ColossalFramework;
using ICities;
using Runaurufu.Utility;
using UnityEngine;

namespace Runaurufu.ClimateControl
{
  public class ChirpBox : IChirperMessage
  {
    private static DateTime lastChrip = DateTime.MinValue;

    public static void SendMessage(string senderName, string msg)
    {
      ChirpPanel cp = ChirpPanel.instance;
      if (cp == null)
        return;

      if (lastChrip == DateTime.MinValue)
        lastChrip = DateTime.Now.AddSeconds(10);

      DateTime now = DateTime.Now;
    //  if ((now - lastChrip).TotalSeconds > 5)
      {
        cp.AddMessage(new ChirpBox() { senderName = senderName, text = msg });
        lastChrip = now;
      }
    }

    public uint senderID
    {
      get
      {
        return 0;
      }
    }

    public string senderName
    {
      get; set;
    }

    public string text
    {
      get; set;
    }
  }

  
  internal class ClimatePreset
  {
    public String PresetName { get; set; }
    /// <summary>
    /// It must be unique climate code!
    /// </summary>
    public String PresetCode { get; set; }
    public ClimateControlProperties ClimateProperties { get; set; }
  }


  public class ClimateControlEngine
  {
    private static ClimateControlEngine instance = null;

    public static ClimateControlEngine Instance
    {
      get
      {
        if (instance == null)
          instance = new ClimateControlEngine();
        return instance;
      }
    }

    private ClimateControlEngine()
    {
      this.IsInitialized = false;
      this.random = new System.Random((int)DateTime.Now.TimeOfDay.TotalMinutes);
      this.InitializeManagers();
    }

    private WeatherManager weatherManager;
    private SimulationManager simulationManager;
    private NetManager netManager;
    private BuildingManager buildingManager;
    internal IThreading ThreadingManager { get; set; }

    public bool IsInitialized { get; private set; }

    public WeatherProperties CurrentWeatherProperties { get; private set; }
    public ClimateControlProperties ClimateControlProperties { get; private set; }
    public DefaultSettings DefaultSettings { get; private set; }

    private System.Random random = null;

    public bool Initialize(WeatherProperties weatherProperties)
    {
      if (weatherProperties == null)
        return false;

      if (this.InitializeManagers() == false)
        return false;

      this.CurrentWeatherProperties = weatherProperties;
      this.ClimateControlProperties = ClimateControlProperties.GetDefaults();
      this.weatherManager.InitializeProperties(weatherProperties);

      this.lastSimulationTimeUpdate = DateTime.MinValue;
      this.IsInitialized = true;

      return true;
    }

    public bool Initialize(ClimateControlProperties climateProperties)
    {
      if (climateProperties == null)
        return false;

      if (this.InitializeManagers() == false)
        return false;

      this.CurrentWeatherProperties = this.weatherManager.m_properties;
      this.ClimateControlProperties = climateProperties;

      this.lastSimulationTimeUpdate = DateTime.MinValue;
      this.IsInitialized = true;
      
      return true;
    }

    private bool InitializeManagers()
    {
      WeatherManager wm = Singleton<WeatherManager>.instance;
      if (wm == null)
        return false;

      SimulationManager sm = Singleton<SimulationManager>.instance;
      if (sm == null)
        return false;

      NetManager nm = Singleton<NetManager>.instance;
      if (nm == null)
        return false;

      BuildingManager bm = Singleton<BuildingManager>.instance;
      if (bm == null)
        return false;

      this.weatherManager = wm;
      this.simulationManager = sm;
      this.netManager = nm;
      this.buildingManager = bm;
      return true;
    }

    public void Uninitialize()
    {
      //MapThemeMetaData mapThemeMetaData = this.simulationManager.m_metaData.m_MapThemeMetaData;
      this.weatherManager.InitializeProperties(GetDefaultWeatherProperites());

      this.IsInitialized = false;
    }

    public static WeatherProperties GetDefaultWeatherProperites()
    {
      WeatherProperties weatherProperties = new WeatherProperties();
      weatherProperties.InvokeMethod("OverrideFromMapTheme");
      return weatherProperties;
    }

    public float CurrentTemperature
    {
      get { return this.weatherManager.m_currentTemperature; }
      internal set { this.weatherManager.m_currentTemperature = value; }
    }

    public float TargetTemperature
    {
      get { return this.weatherManager.m_targetTemperature; }
      internal set
      {
        bool reinitializeProperties = true;

        if (this.IsNight(this.GetDateTime()))
        {
          if (value < this.weatherManager.m_properties.m_minTemperatureNight)
            this.weatherManager.m_properties.m_minTemperatureNight = value - 1.05f;
          else if (value > this.weatherManager.m_properties.m_maxTemperatureNight)
            this.weatherManager.m_properties.m_maxTemperatureNight = value + 1.05f;
          else
            reinitializeProperties = false;
        }
        else
        {
          if (value < this.weatherManager.m_properties.m_minTemperatureDay)
            this.weatherManager.m_properties.m_minTemperatureDay = value - 1.05f;
          else if (value > this.weatherManager.m_properties.m_maxTemperatureDay)
            this.weatherManager.m_properties.m_maxTemperatureDay = value + 1.05f;
          else
            reinitializeProperties = false;
        }

        if(reinitializeProperties)
          this.weatherManager.InitializeProperties(this.weatherManager.m_properties);

        this.weatherManager.m_targetTemperature = value;
      }
    }

    public float TemperatureSpeed
    {
      get { return this.weatherManager.m_temperatureSpeed; }
      internal set { this.weatherManager.m_temperatureSpeed = value; }
    }

    public float CurrentRain
    {
      get { return this.weatherManager.m_currentRain; }
      internal set { this.weatherManager.m_currentRain = value; }
    }

    public float TargetRain
    {
      get { return this.weatherManager.m_targetRain; }
      internal set { this.weatherManager.m_targetRain = value; }
    }

    public float CurrentFog
    {
      get { return this.weatherManager.m_currentFog; }
      internal set { this.weatherManager.m_currentFog = value; }
    }

    public float TargetFog
    {
      get { return this.weatherManager.m_targetFog; }
      internal set { this.weatherManager.m_targetFog = value; }
    }

    public float CurrentRainbow
    {
      get { return this.weatherManager.m_currentRainbow; }
      internal set { this.weatherManager.m_currentRainbow = value; }
    }

    public float TargetRainbow
    {
      get { return this.weatherManager.m_targetRainbow; }
      internal set { this.weatherManager.m_targetRainbow = value; }
    }

    public float CurrentNorthernLights
    {
      get { return this.weatherManager.m_currentNorthernLights; }
      internal set { this.weatherManager.m_currentNorthernLights = value; }
    }

    public float TargetNorthernLights
    {
      get { return this.weatherManager.m_targetNorthernLights; }
      internal set { this.weatherManager.m_targetNorthernLights = value; }
    }

    public float GroundWetness
    {
      get { return this.weatherManager.m_groundWetness; }
      internal set { this.weatherManager.m_groundWetness = value; }
    }

    public float DirectionSpeed
    {
      get { return this.weatherManager.m_directionSpeed; }
      internal set { this.weatherManager.m_directionSpeed = value; }
    }

    public float WindDirection
    {
      get { return this.weatherManager.m_windDirection; }
      internal set { this.weatherManager.m_windDirection = value; }
    }

    private SavedInt temperatureUnit = new SavedInt(Settings.temperatureUnit, Settings.gameSettingsFile, 0, true);

    public string GetLocalizedTemperature(float value, int decimals = 1)
    {
      int tempUnit = (int)temperatureUnit;

      if (tempUnit == 0)
        return string.Format("{0:0." + new String('0', decimals) + "}°C", value);
      else
        return string.Format("{0:0." + new String('0', decimals) + "}°F", value * 1.79999995231628 + 32.0);
    }

    private DateTime GetDateTime()
    {
      
      int realHour = (int)this.ThreadingManager.simulationDayTimeHour;
      int realMinute = (int)((this.ThreadingManager.simulationDayTimeHour - realHour) * 60);
      return new DateTime(this.ThreadingManager.simulationTime.Year, this.ThreadingManager.simulationTime.Month, this.ThreadingManager.simulationTime.Day, realHour, realMinute, 0);

      //switch (GlobalConfig.GetInstance().TimeToUse)
      //{
      //  case GlobalConfig.TimeType.SunTime:
      //    int realHour = (int)this.ThreadingManager.simulationDayTimeHour;
      //    int realMinute = (int)((this.ThreadingManager.simulationDayTimeHour - realHour) * 60);
      //    return new DateTime(this.ThreadingManager.simulationTime.Year, this.ThreadingManager.simulationTime.Month, this.ThreadingManager.simulationTime.Day, realHour, realMinute, 0);

      //  case GlobalConfig.TimeType.RealTime:
      //    DateTime workstationTime = DateTime.Now;
      //    return new DateTime(this.ThreadingManager.simulationTime.Year, this.ThreadingManager.simulationTime.Month, this.ThreadingManager.simulationTime.Day, workstationTime.Hour, workstationTime.Minute, workstationTime.Second);

      //  case GlobalConfig.TimeType.SimulationTime:
      //  default:
      //    return this.ThreadingManager.simulationTime;
      //}
    }

    private bool IsNight(DateTime dt)
    {
      return dt.Hour < SimulationManager.SUNRISE_HOUR || dt.Hour > SimulationManager.SUNSET_HOUR;
    }

    private MonthlyClimateData previousMonthlyClimateData = null;
    private float previousTemperature;
    private DateTime lastSimulationTimeUpdate;

    public void UpdateClimate()
    {
      if (this.IsInitialized == false)
        return;

      DateTime climateTime = this.GetDateTime();
      DateTime simulationTime = this.ThreadingManager.simulationTime;

      TimeSpan simulationTimeUpdateDelta = simulationTime - this.lastSimulationTimeUpdate;
      if (simulationTimeUpdateDelta.TotalMinutes < 15)
        return;

      bool needToReinitializeWeatherProperties = false;


      // DayNightProperties - related to lightning

      // ensure that we have proper reference!
      this.CurrentWeatherProperties = this.weatherManager.m_properties;      

      float currentTemperature = this.weatherManager.m_currentTemperature;
      float newTemperature = currentTemperature;

      if (this.ClimateControlProperties.ClimateData != null && this.ClimateControlProperties.ClimateData.Length > 0)
      {
        float daysPerClimateStage = 366f / this.ClimateControlProperties.ClimateData.Length;
        int dataIndex = (int)((climateTime.DayOfYear - 1) / daysPerClimateStage);

        // just to be sure...
        dataIndex = Math.Min(dataIndex, this.ClimateControlProperties.ClimateData.Length - 1);

        MonthlyClimateData monthlyData = this.ClimateControlProperties.ClimateData[dataIndex];

        // set climate date for current climate frame
        if (previousMonthlyClimateData == null || object.ReferenceEquals(previousMonthlyClimateData, monthlyData) == false)
        {
          float dayLengthRatio = monthlyData.DayLengthAverage / this.ClimateControlProperties.SolarDayLength;

          // Temperatures
          float average = monthlyData.TemperatureAverage == float.NaN ? monthlyData.TemperatureHighAverage * dayLengthRatio + monthlyData.TemperatureLowAverage * (1 - dayLengthRatio) : monthlyData.TemperatureAverage;

          float averageToHigh = monthlyData.TemperatureHighAverage - average;
          float averageToLow = average - monthlyData.TemperatureLowAverage;

          // double averages for greater temp variety!
          averageToHigh *= 2;
          averageToLow *= 2;

          float dayLow = monthlyData.TemperatureHighAverage - averageToHigh * (float)this.random.NextDouble();
          float dayHigh = monthlyData.TemperatureHighAverage + averageToHigh * (float)this.random.NextDouble();
          float nightLow = monthlyData.TemperatureLowAverage - averageToLow * (float)this.random.NextDouble();
          float nightHigh = monthlyData.TemperatureLowAverage + averageToLow * (float)this.random.NextDouble();

          // set values to weather properties!
          this.CurrentWeatherProperties.m_minTemperatureDay = Mathf.Max(monthlyData.TemperatureLowest, dayLow);
          this.CurrentWeatherProperties.m_maxTemperatureDay = Mathf.Min(monthlyData.TemperatureHighest, dayHigh);
          this.CurrentWeatherProperties.m_minTemperatureNight = Mathf.Max(monthlyData.TemperatureLowest, nightLow);
          this.CurrentWeatherProperties.m_maxTemperatureNight = Mathf.Min(monthlyData.TemperatureHighest, nightHigh);

          // Rainfall

          // this.CurrentWeatherProperties.m_minTemperatureRain
          // this.CurrentWeatherProperties.m_maxTemperatureRain

          // monthlyData.PrecipitationAverage
          this.CurrentWeatherProperties.m_rainProbabilityDay = (int)(monthlyData.PrecipitationDaysRatio * 70);
          this.CurrentWeatherProperties.m_rainProbabilityNight = (int)(monthlyData.PrecipitationDaysRatio * 30);

          // Fog

          // this.CurrentWeatherProperties.m_minTemperatureFog
          // this.CurrentWeatherProperties.m_maxTemperatureFog

          this.CurrentWeatherProperties.m_fogProbabilityDay = (int)(monthlyData.FogDaysRatio * 70);
          this.CurrentWeatherProperties.m_fogProbabilityNight = (int)(monthlyData.FogDaysRatio * 30);

          // wind speed range 0f - 2f
          // sampled wind speed range 0f - 1f

          // sun intensity...
          //float num = (float)Singleton<SimulationManager>.instance.m_dayTimeFrame * SimulationManager.DAYTIME_FRAME_TO_HOUR;
          //return Mathf.Clamp01((float)(0.5 + (double)Mathf.Min(num - SimulationManager.SUNRISE_HOUR, SimulationManager.SUNSET_HOUR - num) * 2.0)) * (float)(1.0 - (double)Mathf.Max(this.m_currentRain, this.m_currentFog) * 0.5);

          if (GlobalConfig.GetInstance().ChirpForecast)
          {
            ChirpBox.SendMessage("Weather Forecast", string.Format("Forecast for next {0:0} days:" + Environment.NewLine + "Day {1:0.0} - {2:0.0}" + Environment.NewLine + "Night {3:0.0} - {4:0.0}",
              daysPerClimateStage,
              this.CurrentWeatherProperties.m_minTemperatureDay,
              this.CurrentWeatherProperties.m_maxTemperatureDay,
              this.CurrentWeatherProperties.m_minTemperatureNight,
              this.CurrentWeatherProperties.m_maxTemperatureNight
              ));
          }

          previousMonthlyClimateData = monthlyData;

          // ensure that we move to temperature range!
          if (this.IsNight(climateTime))
          {
            if (currentTemperature < this.CurrentWeatherProperties.m_minTemperatureNight)
              this.weatherManager.m_targetTemperature = this.CurrentWeatherProperties.m_minTemperatureNight;
            else if (currentTemperature > this.CurrentWeatherProperties.m_maxTemperatureNight)
              this.weatherManager.m_targetTemperature = this.CurrentWeatherProperties.m_maxTemperatureNight;
          }
          else
          {
            if (currentTemperature < this.CurrentWeatherProperties.m_minTemperatureDay)
              this.weatherManager.m_targetTemperature = this.CurrentWeatherProperties.m_minTemperatureDay;
            else if (currentTemperature > this.CurrentWeatherProperties.m_maxTemperatureDay)
              this.weatherManager.m_targetTemperature = this.CurrentWeatherProperties.m_maxTemperatureDay;
          }
          
          needToReinitializeWeatherProperties = true;
        }
      }

      //this.weatherManager.m_targetTemperature = newTemperature;
      // this.weatherManager.m_currentTemperature = newTemperature;

      // rain/snow sets - keep it at the end!
      bool rainIsSnow = this.weatherManager.m_currentTemperature < this.ClimateControlProperties.SnowFallTemperature;
      if (rainIsSnow != this.CurrentWeatherProperties.m_rainIsSnow)
      {
        this.CurrentWeatherProperties.m_rainIsSnow = rainIsSnow;
        needToReinitializeWeatherProperties = true;
      }
      
      if (GlobalConfig.GetInstance().AlterSnowDumpSnowMelting)
      {
        this.HandleSnowDumps(simulationTimeUpdateDelta);
      }

      // does snow melt?
      if (this.weatherManager.m_currentTemperature > this.ClimateControlProperties.SnowMeltTemperature)
      {
        if(this.netManager.m_treatWetAsSnow == true)
        {
          // this instantly melt "road" snow away!
          this.netManager.m_treatWetAsSnow = false;
        }
      }
      else
      {
        if(this.netManager.m_treatWetAsSnow == false && rainIsSnow)
        {
          this.netManager.m_treatWetAsSnow = true;
        }
      }

      if (needToReinitializeWeatherProperties)
      {
        this.weatherManager.InitializeProperties(this.CurrentWeatherProperties);
      }

      this.lastSimulationTimeUpdate = simulationTime;
    }

    private void HandleSnowDumps(TimeSpan timeDelta)
    {
      float tempDeltaFall = this.weatherManager.m_currentTemperature - this.ClimateControlProperties.SnowFallTemperature;
      float tempDeltaMelt = this.weatherManager.m_currentTemperature - this.ClimateControlProperties.SnowMeltTemperature;

      float snowMeltRatio = 1f;

      if (tempDeltaFall > 0)
        snowMeltRatio *= (1 + tempDeltaFall / 90);
      else // add extra snow?
        snowMeltRatio = 0;

      if (tempDeltaMelt > 0)
        snowMeltRatio *= (1 + tempDeltaMelt / 30);

      if (snowMeltRatio > 1)
        snowMeltRatio = (float)Math.Pow(snowMeltRatio, timeDelta.TotalHours);

      FastList<ushort> serviceBuildings = this.buildingManager.GetServiceBuildings(ItemClass.Service.Road);
      int num = serviceBuildings.m_size;
      ushort[] numArray = serviceBuildings.m_buffer;
      if (numArray != null && num <= numArray.Length)
      {
        for (int index = 0; index < num; ++index)
        {
          ushort buildingId = numArray[index];
          if ((int)buildingId != 0)
          {
            BuildingInfo info = this.buildingManager.m_buildings.m_buffer[(int)buildingId].Info;
            if (info.m_class.m_service == ItemClass.Service.Road)
            {
              SnowDumpAI snowDump = info.m_buildingAI as SnowDumpAI;
              if (snowDump != null)
              {
                int snowInDump = (int)this.buildingManager.m_buildings.m_buffer[(int)buildingId].m_customBuffer1 * 1000 + (int)this.buildingManager.m_buildings.m_buffer[(int)buildingId].m_garbageBuffer; // snowDump.GetSnowAmount(buildingId, ref bm.m_buildings.m_buffer[(int)buildingId]);
                int newSnowAmount = snowInDump;

                int rainOnArea = 0;
                //int rainOnArea = area * this.weatherManager.m_currentRain;

                if (snowMeltRatio > 1)
                {
                  int productionRate = (int)((snowMeltRatio /*- 1f*/) * 100f);

                  int a = (int)this.buildingManager.m_buildings.m_buffer[(int)buildingId].m_customBuffer1 * 1000 + (int)this.buildingManager.m_buildings.m_buffer[(int)buildingId].m_garbageBuffer;
                  int meltedSnow = Mathf.Min(a, (productionRate * snowDump.m_snowConsumption + 99) / 100);

                  if (meltedSnow > 0)
                  {
                    newSnowAmount = snowInDump - meltedSnow;
                    meltedSnow = meltedSnow + rainOnArea; // rain is washing that dirty snow and pollute your land!
                    Singleton<NaturalResourceManager>.instance.TryDumpResource(NaturalResourceManager.Resource.Pollution, meltedSnow * 100, meltedSnow * 100, this.buildingManager.m_buildings.m_buffer[(int)buildingId].m_position, snowDump.m_pollutionRadius);
                  }

                  newSnowAmount = newSnowAmount - rainOnArea;
                }
                else
                {
                  newSnowAmount = snowInDump + rainOnArea;
                }

                newSnowAmount = Math.Min(Math.Max(newSnowAmount, 0), snowDump.m_snowCapacity);

                // update snow in dump with new values if they have changed!
                if (snowInDump != newSnowAmount)
                {
                  this.buildingManager.m_buildings.m_buffer[(int)buildingId].m_customBuffer1 = (ushort)(newSnowAmount / 1000);
                  this.buildingManager.m_buildings.m_buffer[(int)buildingId].m_garbageBuffer = (ushort)(newSnowAmount - (int)this.buildingManager.m_buildings.m_buffer[(int)buildingId].m_customBuffer1 * 1000);
                }

                // snow amount
                //return Mathf.Min(this.m_snowCapacity, (int)data.m_customBuffer1 * 1000 + (int)data.m_garbageBuffer);

                // snow reduction per tick
                //int a = (int)buildingData.m_customBuffer1 * 1000 + (int)buildingData.m_garbageBuffer;
                //int num1 = Mathf.Min(a, (productionRate * this.m_snowConsumption + 99) / 100);
                //if (num1 > 0)
                //{
                //  a -= num1;
                //  buildingData.m_customBuffer1 = (ushort)(a / 1000);
                //  buildingData.m_garbageBuffer = (ushort)(a - (int)buildingData.m_customBuffer1 * 1000);
                //}

                // polution per tick
                //if ((int)buildingData.m_customBuffer1 >= 100)
                //{
                //  int num = ((int)buildingData.m_customBuffer1 / 100 * this.m_pollutionAccumulation + 99) / 100;
                //  if (num != 0)
                //    Singleton<NaturalResourceManager>.instance.TryDumpResource(NaturalResourceManager.Resource.Pollution, num, num, buildingData.m_position, this.m_pollutionRadius);
                //}
              }
            }
          }
        }
      }
    }
  }

  public class DefaultSettings
  {

    public Vector3 TerrainManager_GrassFertilityColorOffset { get; set; }
    public Vector3 TerrainManager_GrassFieldColorOffset { get; set; }
    public Vector3 TerrainManager_GrassForestColorOffset { get; set; }
    public Vector3 TerrainManager_GrassPollutionColorOffset { get; set; }
  }

  public class ClimateControlProperties
  {
    /// <summary>
    /// If temperature falls below that value you will get snow instead of rain.
    /// </summary>
    public float SnowFallTemperature { get; set; }

    /// <summary>
    /// If temperature falls below that value all your snow should melt away.
    /// </summary>
    public float SnowMeltTemperature { get; set; }

    /// <summary>
    /// How many earth hours day takes? For Earth = 24.0f!
    /// </summary>
    public float SolarDayLength { get; set; }

    /// <summary>
    /// Climate date for months to come. Set this to null to use only weather properties for temperature calculation.
    /// </summary>
    public MonthlyClimateData[] ClimateData { get; set; }

    internal static ClimateControlProperties GetDefaults()
    {
      ClimateControlProperties properties = new ClimateControlProperties();
      properties.SnowFallTemperature = 2;
      properties.SnowMeltTemperature = 10;
      properties.SolarDayLength = 24.0f;
      properties.ClimateData = null;

      return properties;
    }
  }

  public class MonthlyClimateData
  {
    // Temperature

    /// <summary>
    /// [C]
    /// </summary>
    public float TemperatureHighest { get; set; }
    public float TemperatureHighAverage { get; set; }
    public float TemperatureAverage { get; set; }
    public float TemperatureLowAverage { get; set; }
    public float TemperatureLowest { get; set; }

    // Precipitation: Rainfall & Snowfall

    /// <summary>
    /// [mm]
    /// </summary>
    public float PrecipitationAverage { get; set; }
    /// <summary>
    /// 0 - no rain/snow, 1 - rain/snow all time
    /// </summary>
    public float PrecipitationDaysRatio { get; set; }

    // Wind

    /// <summary>
    /// [km / h]
    /// </summary>
    public float AverageWindSpeed { get; set; }

    // Fog

    /// <summary>
    /// 0 - no fog, 1 - fog all time
    /// </summary>
    public float FogDaysRatio { get; set; }

    // Solar

    /// <summary>
    /// [h]
    /// </summary>
    public float DayLengthAverage { get; set; }

    //public float DayStartHour { get; set; }
    //public float NightStartHour { get; set; }
  }
}