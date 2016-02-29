using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Runaurufu.ClimateControl
{
  partial class ModSettings
  {
    public static readonly ClimatePreset[] AllPresets =
    {
      new ClimatePreset() { PresetName = "Default climate settings", PresetCode = DEFAULT_PRESET_CODE, ClimateProperties = null },
      //new ClimatePreset() { PresetName = "Custom climate settings", PresetCode = CUSTOM_PRESET_CODE, ClimateProperties = null },
      new ClimatePreset() { PresetName = "Companion mod climate settings", PresetCode = COMPANION_PRESET_CODE, ClimateProperties = null },
      #region North Pole
      // http://www.weatherbase.com/weather/weatherall.php3?s=110340&cityname=Closest+Data+for+North+Pole+-+440+mi%2F709+km%2C+Greenland&units=
      new ClimatePreset() { PresetName = "North Pole", PresetCode = "PRESET_NORTH_POLE", ClimateProperties = new ClimateControlProperties()
      {
        SnowFallTemperature = 2, SnowMeltTemperature = 10, SolarDayLength = 24.00f,
        ClimateData = new MonthlyClimateData[]
        {
          new MonthlyClimateData() // January
          {
            TemperatureAverage = -31,
            TemperatureHighAverage = -29, TemperatureLowAverage = -33,
            TemperatureHighest = -13, TemperatureLowest = -47,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 0,
            AverageWindSpeed= 27,
            FogDaysRatio = 0,
            DayLengthAverage = 0,
          },
          new MonthlyClimateData() // February
          {
            TemperatureAverage = -32,
            TemperatureHighAverage = -31, TemperatureLowAverage = -35,
            TemperatureHighest = -14, TemperatureLowest = -50,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 0,
            AverageWindSpeed= 27,
            FogDaysRatio = 0,
            DayLengthAverage = 0,
          },
          new MonthlyClimateData() // March
          {
            TemperatureAverage = -31,
            TemperatureHighAverage = -30, TemperatureLowAverage = -34,
            TemperatureHighest = -11, TemperatureLowest = -50,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 0,
            AverageWindSpeed= 27,
            FogDaysRatio = 0,
            DayLengthAverage = 18,
          },
          new MonthlyClimateData() // April
          {
            TemperatureAverage = -23,
            TemperatureHighAverage = -22, TemperatureLowAverage = -26,
            TemperatureHighest = -6, TemperatureLowest = -41,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 0,
            AverageWindSpeed= 27,
            FogDaysRatio = 0,
            DayLengthAverage = 23,
          },
          new MonthlyClimateData() // May
          {
            TemperatureAverage = -11,
            TemperatureHighAverage = -9, TemperatureLowAverage = -12,
            TemperatureHighest = 3, TemperatureLowest = -24,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 0,
            AverageWindSpeed= 25,
            FogDaysRatio = 0,
            DayLengthAverage = 24,
          },
          new MonthlyClimateData() // June
          {
            TemperatureAverage = -1,
            TemperatureHighAverage = 0, TemperatureLowAverage = -2,
            TemperatureHighest = 10, TemperatureLowest = -12,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 0,
            AverageWindSpeed= 22,
            FogDaysRatio = 0,
            DayLengthAverage = 24,
          },
          new MonthlyClimateData() // July
          {
            TemperatureAverage = 1,
            TemperatureHighAverage = 2, TemperatureLowAverage = 0,
            TemperatureHighest = 13, TemperatureLowest = -2,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 0,
            AverageWindSpeed= 27,
            FogDaysRatio = 0,
            DayLengthAverage = 24,
          },
          new MonthlyClimateData() // August
          {
            TemperatureAverage = 0,
            TemperatureHighAverage = 1, TemperatureLowAverage = -1,
            TemperatureHighest = 12, TemperatureLowest = -12,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 0,
            AverageWindSpeed= 25,
            FogDaysRatio = 0,
            DayLengthAverage = 22.5f,
          },
          new MonthlyClimateData() // September
          {
            TemperatureAverage = -9,
            TemperatureHighAverage = -7, TemperatureLowAverage = -11,
            TemperatureHighest = 7, TemperatureLowest = -31,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 0,
            AverageWindSpeed= 25,
            FogDaysRatio = 0,
            DayLengthAverage = 19.9f,
          },
          new MonthlyClimateData() // October
          {
            TemperatureAverage = -20,
            TemperatureHighAverage = 0, TemperatureLowAverage = -22,
            TemperatureHighest = -2, TemperatureLowest = -41,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 0,
            AverageWindSpeed= 25,
            FogDaysRatio = 0,
            DayLengthAverage = 3.3f,
          },
          new MonthlyClimateData() // November
          {
            TemperatureAverage = -27,
            TemperatureHighAverage = -25, TemperatureLowAverage = -30,
            TemperatureHighest = -8, TemperatureLowest = -41,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 0,
            AverageWindSpeed= 22,
            FogDaysRatio = 0,
            DayLengthAverage = 0,
          },
          new MonthlyClimateData() // December
          {
            TemperatureAverage = -28,
            TemperatureHighAverage = -26, TemperatureLowAverage = -31,
            TemperatureHighest = -6, TemperatureLowest = -47,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 0,
            AverageWindSpeed= 27,
            FogDaysRatio = 0,
            DayLengthAverage = 0,
          },
        }
      }},
      #endregion
      #region South Pole
      // http://www.weatherbase.com/weather/weatherall.php3?s=90098&cityname=South+Pole%2C+Antarctica&units=
      new ClimatePreset() { PresetName = "South Pole", PresetCode = "PRESET_SOUTH_POLE", ClimateProperties = new ClimateControlProperties()
      {
        SnowFallTemperature = 2, SnowMeltTemperature = 10, SolarDayLength = 24.00f,
        ClimateData = new MonthlyClimateData[]
        {
          new MonthlyClimateData() // January
          {
            TemperatureAverage = -26,
            TemperatureHighAverage = -25, TemperatureLowAverage = -28,
            TemperatureHighest = -14, TemperatureLowest = -41,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 0,
            AverageWindSpeed = 17,
            FogDaysRatio = 11f/30f,
            DayLengthAverage = 24,
          },
          new MonthlyClimateData() // February
          {
            TemperatureAverage = -38,
            TemperatureHighAverage = -37, TemperatureLowAverage = -42,
            TemperatureHighest = -20, TemperatureLowest = -57,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 0,
            AverageWindSpeed = 14,
            FogDaysRatio = 11f/30f,
            DayLengthAverage = 24,
          },
          new MonthlyClimateData() // March
          {
            TemperatureAverage = -52,
            TemperatureHighAverage = -50, TemperatureLowAverage = -56,
            TemperatureHighest = -26, TemperatureLowest = -71,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 0,
            AverageWindSpeed = 22,
            FogDaysRatio = 14f/30f,
            DayLengthAverage = 17.8f,
          },
          new MonthlyClimateData() // April
          {
            TemperatureAverage = -56,
            TemperatureHighAverage = -52, TemperatureLowAverage = -60,
            TemperatureHighest = -27, TemperatureLowest = -75,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 0,
            AverageWindSpeed = 17,
            FogDaysRatio = 9f/30f,
            DayLengthAverage = 0,
          },
          new MonthlyClimateData() // May
          {
            TemperatureAverage = -56,
            TemperatureHighAverage = -53, TemperatureLowAverage = -61,
            TemperatureHighest = -30, TemperatureLowest = -78,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 0,
            AverageWindSpeed = 27,
            FogDaysRatio = 6f/30f,
            DayLengthAverage = 0,
          },
          new MonthlyClimateData() // June
          {
            TemperatureAverage = -57,
            TemperatureHighAverage = -53, TemperatureLowAverage = -61,
            TemperatureHighest = -31, TemperatureLowest = -82,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 0,
            AverageWindSpeed = 28,
            FogDaysRatio = 4f/30f,
            DayLengthAverage = 0,
          },
          new MonthlyClimateData() // July
          {
            TemperatureAverage = -58,
            TemperatureHighAverage = -55, TemperatureLowAverage = -63,
            TemperatureHighest = -33, TemperatureLowest = -80,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 0,
            AverageWindSpeed = 27,
            FogDaysRatio = 4f/30f,
            DayLengthAverage = 0,
          },
          new MonthlyClimateData() // August
          {
            TemperatureAverage = -58,
            TemperatureHighAverage = -55, TemperatureLowAverage = -62,
            TemperatureHighest = -32, TemperatureLowest = -77,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 0,
            AverageWindSpeed = 27,
            FogDaysRatio = 4f/30f,
            DayLengthAverage = 0,
          },
          new MonthlyClimateData() // September
          {
            TemperatureAverage = -58,
            TemperatureHighAverage = -55, TemperatureLowAverage = -62,
            TemperatureHighest = -29, TemperatureLowest = -79,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 0,
            AverageWindSpeed = 27,
            FogDaysRatio = 10f/30f,
            DayLengthAverage = 17.2f,
          },
          new MonthlyClimateData() // October
          {
            TemperatureAverage = -50,
            TemperatureHighAverage = -47, TemperatureLowAverage = -53,
            TemperatureHighest = -29, TemperatureLowest = -71,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 0,
            AverageWindSpeed = 27,
            FogDaysRatio = 11f/30f,
            DayLengthAverage = 24,
          },
          new MonthlyClimateData() // November
          {
            TemperatureAverage = -37,
            TemperatureHighAverage = -36, TemperatureLowAverage = -39,
            TemperatureHighest = -18, TemperatureLowest = -55,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 0,
            AverageWindSpeed = 20,
            FogDaysRatio = 9f/30f,
            DayLengthAverage = 24,
          },
          new MonthlyClimateData() // December
          {
            TemperatureAverage = -26,
            TemperatureHighAverage = -26, TemperatureLowAverage = -28,
            TemperatureHighest = -13, TemperatureLowest = -38,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 0,
            AverageWindSpeed = 17,
            FogDaysRatio = 9f/30f,
            DayLengthAverage = 24,
          },
        }
      }},
      #endregion
      #region Planet Mars
      // https://en.wikipedia.org/wiki/Climate_of_Mars
      // http://quest.nasa.gov/aero/planetary/mars.html
      // http://www.alpo-astronomy.org/jbeish/General_Info_Mars.htm
      new ClimatePreset() { PresetName = "Planet Mars", PresetCode = "PRESET_PLANET_MARS", ClimateProperties = new ClimateControlProperties()
      {
        SnowFallTemperature = 100, SnowMeltTemperature = 200, SolarDayLength = 24.66f,
        ClimateData = new MonthlyClimateData[]
        {
          new MonthlyClimateData() // January
          {
            TemperatureAverage = float.NaN,
            TemperatureHighAverage = -7, TemperatureLowAverage = -82,
            TemperatureHighest = 6, TemperatureLowest = -95,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 0,
            AverageWindSpeed = 10,
            FogDaysRatio = 0.15f,
            DayLengthAverage = 12.33f,
          },
          new MonthlyClimateData() // February
          {
            TemperatureAverage = float.NaN,
            TemperatureHighAverage = -18, TemperatureLowAverage = -86,
            TemperatureHighest = 6, TemperatureLowest = -127,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 0,
            AverageWindSpeed = 10,
            FogDaysRatio = 0.15f,
            DayLengthAverage = 12.33f,
          },
          new MonthlyClimateData() // March
          {
            TemperatureAverage = float.NaN,
            TemperatureHighAverage = -23, TemperatureLowAverage = -88,
            TemperatureHighest = 1, TemperatureLowest = -114,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 0,
            AverageWindSpeed = 10,
            FogDaysRatio = 0.15f,
            DayLengthAverage = 12.33f,
          },
          new MonthlyClimateData() // April
          {
            TemperatureAverage = float.NaN,
            TemperatureHighAverage = -20, TemperatureLowAverage = -87,
            TemperatureHighest = 0, TemperatureLowest = -97,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 0,
            AverageWindSpeed = 10,
            FogDaysRatio = 0.15f,
            DayLengthAverage = 12.33f,
          },
          new MonthlyClimateData() // May
          {
            TemperatureAverage = float.NaN,
            TemperatureHighAverage = -4, TemperatureLowAverage = -85,
            TemperatureHighest = 7, TemperatureLowest = -98,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 0,
            AverageWindSpeed = 10,
            FogDaysRatio = 0.15f,
            DayLengthAverage = 12.33f,
          },
          new MonthlyClimateData() // June
          {
            TemperatureAverage = float.NaN,
            TemperatureHighAverage = 0, TemperatureLowAverage = -78,
            TemperatureHighest = 14, TemperatureLowest = -125,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 0,
            AverageWindSpeed = 10,
            FogDaysRatio = 0.15f,
            DayLengthAverage = 12.33f,
          },
          new MonthlyClimateData() // July
          {
            TemperatureAverage = float.NaN,
            TemperatureHighAverage = 2, TemperatureLowAverage = -76,
            TemperatureHighest = 20, TemperatureLowest = -84,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 0,
            AverageWindSpeed = 10,
            FogDaysRatio = 0.15f,
            DayLengthAverage = 12.33f,
          },
          new MonthlyClimateData() // August
          {
            TemperatureAverage = float.NaN,
            TemperatureHighAverage = 1, TemperatureLowAverage = -69,
            TemperatureHighest = 19, TemperatureLowest = -80,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 0,
            AverageWindSpeed = 10,
            FogDaysRatio = 0.15f,
            DayLengthAverage = 12.33f,
          },
          new MonthlyClimateData() // September
          {
            TemperatureAverage = float.NaN,
            TemperatureHighAverage = 1, TemperatureLowAverage = -68,
            TemperatureHighest = 7, TemperatureLowest = -78,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 0,
            AverageWindSpeed = 10,
            FogDaysRatio = 0.15f,
            DayLengthAverage = 12.33f,
          },
          new MonthlyClimateData() // October
          {
            TemperatureAverage = float.NaN,
            TemperatureHighAverage = 4, TemperatureLowAverage = -73,
            TemperatureHighest = 7, TemperatureLowest = -79,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 0,
            AverageWindSpeed = 10,
            FogDaysRatio = 0.15f,
            DayLengthAverage = 12.33f,
          },
          new MonthlyClimateData() // November
          {
            TemperatureAverage = float.NaN,
            TemperatureHighAverage = -1, TemperatureLowAverage = -73,
            TemperatureHighest = 8, TemperatureLowest = -83,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 0,
            AverageWindSpeed = 10,
            FogDaysRatio = 0.15f,
            DayLengthAverage = 12.33f,
          },
          new MonthlyClimateData() // December
          {
            TemperatureAverage = float.NaN,
            TemperatureHighAverage = -3, TemperatureLowAverage = -77,
            TemperatureHighest = 8, TemperatureLowest = -110,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 0,
            AverageWindSpeed = 10,
            FogDaysRatio = 0.15f,
            DayLengthAverage = 12.33f,
          },
        }
      }},
      #endregion
      #region England, London
      // http://www.weatherbase.com/weather/weatherall.php3?s=67730&cityname=London%2C+England%2C+United+Kingdom&units=
      new ClimatePreset() { PresetName = "England, London", PresetCode = "PRESET_ENGLAND_LONDON", ClimateProperties = new ClimateControlProperties()
      {
        SnowFallTemperature = 2, SnowMeltTemperature = 10, SolarDayLength = 24.00f,
        ClimateData = new MonthlyClimateData[]
        {
          new MonthlyClimateData() // January
          {
            TemperatureAverage = 4.3f,
            TemperatureHighAverage = 7.4f, TemperatureLowAverage = 1.2f,
            TemperatureHighest = 12, TemperatureLowest = -12,
            PrecipitationAverage = 70,
            PrecipitationDaysRatio = 0.76f,
            AverageWindSpeed = 12.4f,
            FogDaysRatio = 14f/30f,
            DayLengthAverage = 9.2f,
          },
          new MonthlyClimateData() // February
          {
            TemperatureAverage = 4.5f,
            TemperatureHighAverage = 7.9f, TemperatureLowAverage = 1,
            TemperatureHighest = 17, TemperatureLowest = -13,
            PrecipitationAverage = 50,
            PrecipitationDaysRatio = 0.63f,
            AverageWindSpeed = 13,
            FogDaysRatio = 13f/30f,
            DayLengthAverage = 10.6f,
          },
          new MonthlyClimateData() // March
          {
            TemperatureAverage = 6.9f,
            TemperatureHighAverage = 10.9f, TemperatureLowAverage = 2.8f,
            TemperatureHighest = 20, TemperatureLowest = -7,
            PrecipitationAverage = 60,
            PrecipitationDaysRatio = 0.7f,
            AverageWindSpeed = 14.4f,
            FogDaysRatio = 16f/30f,
            DayLengthAverage = 12.5f,
          },
          new MonthlyClimateData() // April
          {
            TemperatureAverage = 8.7f,
            TemperatureHighAverage = 13.7f, TemperatureLowAverage = 3.7f,
            TemperatureHighest = 22, TemperatureLowest = -5,
            PrecipitationAverage = 50,
            PrecipitationDaysRatio = 0.66f,
            AverageWindSpeed = 10.4f,
            FogDaysRatio = 14f/30f,
            DayLengthAverage = 14.5f,
          },
          new MonthlyClimateData() // May
          {
            TemperatureAverage = 12.1f,
            TemperatureHighAverage = 17.4f, TemperatureLowAverage = 6.8f,
            TemperatureHighest = 28, TemperatureLowest = -3,
            PrecipitationAverage = 50,
            PrecipitationDaysRatio = 0.6f,
            AverageWindSpeed = 10.6f,
            FogDaysRatio = 18f/30f,
            DayLengthAverage = 16.3f,
          },
          new MonthlyClimateData() // June
          {
            TemperatureAverage = 15.1f,
            TemperatureHighAverage = 20.5f, TemperatureLowAverage = 9.6f,
            TemperatureHighest = 32, TemperatureLowest = 1,
            PrecipitationAverage = 50,
            PrecipitationDaysRatio = 0.6f,
            AverageWindSpeed = 9.3f,
            FogDaysRatio = 19f/30f,
            DayLengthAverage = 17.3f,
          },
          new MonthlyClimateData() // July
          {
            TemperatureAverage = 17.3f,
            TemperatureHighAverage = 22.9f, TemperatureLowAverage = 11.7f,
            TemperatureHighest = 33, TemperatureLowest = 3,
            PrecipitationAverage = 40,
            PrecipitationDaysRatio = 0.56f,
            AverageWindSpeed = 8.7f,
            FogDaysRatio = 17f/30f,
            DayLengthAverage = 16.7f,
          },
          new MonthlyClimateData() // August
          {
            TemperatureAverage = 17,
            TemperatureHighAverage = 22.6f, TemperatureLowAverage = 11.4f,
            TemperatureHighest = 35, TemperatureLowest = 2,
            PrecipitationAverage = 50,
            PrecipitationDaysRatio = 0.56f,
            AverageWindSpeed = 11.1f,
            FogDaysRatio = 22f/30f,
            DayLengthAverage = 15.1f,
          },
          new MonthlyClimateData() // September
          {
            TemperatureAverage = 14.3f,
            TemperatureHighAverage = 19.2f, TemperatureLowAverage = 9.3f,
            TemperatureHighest = 27, TemperatureLowest = 1,
            PrecipitationAverage = 60,
            PrecipitationDaysRatio = 0.6f,
            AverageWindSpeed = 8.7f,
            FogDaysRatio = 20f/30f,
            DayLengthAverage = 13.2f,
          },
          new MonthlyClimateData() // October
          {
            TemperatureAverage = 10.9f,
            TemperatureHighAverage = 15.2f, TemperatureLowAverage = 6.6f,
            TemperatureHighest = 25, TemperatureLowest = -4,
            PrecipitationAverage = 70,
            PrecipitationDaysRatio = 0.70f,
            AverageWindSpeed = 9.8f,
            FogDaysRatio = 21f/30f,
            DayLengthAverage = 11.2f,
          },
          new MonthlyClimateData() // November
          {
            TemperatureAverage = 7.2f,
            TemperatureHighAverage = 10.7f, TemperatureLowAverage = 3.6f,
            TemperatureHighest = 17, TemperatureLowest = -7,
            PrecipitationAverage = 70,
            PrecipitationDaysRatio = 0.73f,
            AverageWindSpeed = 9.1f,
            FogDaysRatio = 17f/30f,
            DayLengthAverage = 9.5f,
          },
          new MonthlyClimateData() // December
          {
            TemperatureAverage = 4.7f,
            TemperatureHighAverage = 7.8f, TemperatureLowAverage = 1.6f,
            TemperatureHighest = 15, TemperatureLowest = -11,
            PrecipitationAverage = 70,
            PrecipitationDaysRatio = 0.73f,
            AverageWindSpeed = 10.9f,
            FogDaysRatio = 16f/30f,
            DayLengthAverage = 8.6f,
          },
        }
      }},
      #endregion
      #region Spain, Seville
      // http://www.weatherbase.com/weather/weatherall.php3?s=19380&cityname=Seville%2C+Andalusia%2C+Spain&units=
      new ClimatePreset() { PresetName = "Spain, Seville", PresetCode = "PRESET_SPAIN_SEVILLE", ClimateProperties = new ClimateControlProperties()
      {
        SnowFallTemperature = 2, SnowMeltTemperature = 10, SolarDayLength = 24.00f,
        ClimateData = new MonthlyClimateData[]
        {
          new MonthlyClimateData() // January
          {
            TemperatureAverage = 10.6f,
            TemperatureHighAverage = 15.9f, TemperatureLowAverage = 5.2f,
            TemperatureHighest = 23, TemperatureLowest = -3,
            PrecipitationAverage = 65,
            PrecipitationDaysRatio = 6f/30f,
            AverageWindSpeed = 12,
            FogDaysRatio = 4f/30f,
            DayLengthAverage = 10.4f,
          },
          new MonthlyClimateData() // February
          {
            TemperatureAverage = 12.2f,
            TemperatureHighAverage = 17.9f, TemperatureLowAverage = 6.7f,
            TemperatureHighest = 26, TemperatureLowest = -2,
            PrecipitationAverage = 54,
            PrecipitationDaysRatio = 6f/30f,
            AverageWindSpeed = 12,
            FogDaysRatio = 3f/30f,
            DayLengthAverage = 11.3f,
          },
          new MonthlyClimateData() // March
          {
            TemperatureAverage = 14.7f,
            TemperatureHighAverage = 21.2f, TemperatureLowAverage = 8.2f,
            TemperatureHighest = 31, TemperatureLowest = 0,
            PrecipitationAverage = 38,
            PrecipitationDaysRatio = 5f/30f,
            AverageWindSpeed = 12,
            FogDaysRatio = 3f/30f,
            DayLengthAverage = 12.4f,
          },
          new MonthlyClimateData() // April
          {
            TemperatureAverage = 16.4f,
            TemperatureHighAverage = 22.7f, TemperatureLowAverage = 10.1f,
            TemperatureHighest = 33, TemperatureLowest = 1,
            PrecipitationAverage = 57,
            PrecipitationDaysRatio = 7f/30f,
            AverageWindSpeed = 16,
            FogDaysRatio = 2f/30f,
            DayLengthAverage = 13.7f,
          },
          new MonthlyClimateData() // May
          {
            TemperatureAverage = 19.7f,
            TemperatureHighAverage = 26.4f, TemperatureLowAverage = 13.1f,
            TemperatureHighest = 38, TemperatureLowest = 6,
            PrecipitationAverage = 34,
            PrecipitationDaysRatio = 4f/30f,
            AverageWindSpeed = 16,
            FogDaysRatio = 1f/30f,
            DayLengthAverage = 14.7f,
          },
          new MonthlyClimateData() // June
          {
            TemperatureAverage = 23.9f,
            TemperatureHighAverage = 31, TemperatureLowAverage = 16.7f,
            TemperatureHighest = 43, TemperatureLowest = 7,
            PrecipitationAverage = 13,
            PrecipitationDaysRatio = 2f/30f,
            AverageWindSpeed = 16,
            FogDaysRatio = 1f/30f,
            DayLengthAverage = 15.2f,
          },
          new MonthlyClimateData() // July
          {
            TemperatureAverage = 27.4f,
            TemperatureHighAverage = 35.3f, TemperatureLowAverage = 19.4f,
            TemperatureHighest = 43, TemperatureLowest = 13,
            PrecipitationAverage = 2,
            PrecipitationDaysRatio = 0,
            AverageWindSpeed = 16,
            FogDaysRatio = 0,
            DayLengthAverage = 14.9f,
          },
          new MonthlyClimateData() // August
          {
            TemperatureAverage = 27.2f,
            TemperatureHighAverage = 35, TemperatureLowAverage = 19.5f,
            TemperatureHighest = 45, TemperatureLowest = 12,
            PrecipitationAverage = 6,
            PrecipitationDaysRatio = 0,
            AverageWindSpeed = 16,
            FogDaysRatio = 0,
            DayLengthAverage = 14,
          },
          new MonthlyClimateData() // September
          {
            TemperatureAverage = 24.5f,
            TemperatureHighAverage = 31.6f, TemperatureLowAverage = 17.5f,
            TemperatureHighest = 43, TemperatureLowest = 8,
            PrecipitationAverage = 23,
            PrecipitationDaysRatio = 2f/30f,
            AverageWindSpeed = 14,
            FogDaysRatio = 1f/30f,
            DayLengthAverage = 12.8f,
          },
          new MonthlyClimateData() // October
          {
            TemperatureAverage = 19.6f,
            TemperatureHighAverage = 25.6f, TemperatureLowAverage = 13.5f,
            TemperatureHighest = 36, TemperatureLowest = 3,
            PrecipitationAverage = 62,
            PrecipitationDaysRatio = 6f/30f,
            AverageWindSpeed = 12,
            FogDaysRatio = 2f/30f,
            DayLengthAverage = 11.6f,
          },
          new MonthlyClimateData() // November
          {
            TemperatureAverage = 14.8f,
            TemperatureHighAverage = 20.1f, TemperatureLowAverage = 9.3f,
            TemperatureHighest = 31, TemperatureLowest = -1,
            PrecipitationAverage = 84,
            PrecipitationDaysRatio = 6f/30f,
            AverageWindSpeed = 12,
            FogDaysRatio = 2f/30f,
            DayLengthAverage = 10.6f,
          },
          new MonthlyClimateData() // December
          {
            TemperatureAverage = 11.8f,
            TemperatureHighAverage = 16.6f, TemperatureLowAverage = 6.9f,
            TemperatureHighest = 23, TemperatureLowest = -5,
            PrecipitationAverage = 95,
            PrecipitationDaysRatio = 8f/30f,
            AverageWindSpeed = 12,
            FogDaysRatio = 3f/30f,
            DayLengthAverage = 10.1f,
          },
        }
      }},
      #endregion
      #region Sweden, Stockholm
      // http://www.weatherbase.com/weather/weatherall.php3?s=6420&cityname=Stockholm%2C+Stockholm%2C+Sweden&units=
      new ClimatePreset() { PresetName = "Sweden, Stockholm", PresetCode = "PRESET_SWEDEN_STOCKHOLM", ClimateProperties = new ClimateControlProperties()
      {
        SnowFallTemperature = 2, SnowMeltTemperature = 10, SolarDayLength = 24.00f,
        ClimateData = new MonthlyClimateData[]
        {
          new MonthlyClimateData() // January
          {
            TemperatureAverage = -2,
            TemperatureHighAverage = 0, TemperatureLowAverage = -5,
            TemperatureHighest = 10, TemperatureLowest = -27,
            PrecipitationAverage = 39,
            PrecipitationDaysRatio = 25f/30f,
            AverageWindSpeed = 14,
            FogDaysRatio = 16f/30f,
            DayLengthAverage = 7.8f,
          },
          new MonthlyClimateData() // February
          {
            TemperatureAverage = -3,
            TemperatureHighAverage = 0, TemperatureLowAverage = -6,
            TemperatureHighest = 12, TemperatureLowest = -27,
            PrecipitationAverage = 27,
            PrecipitationDaysRatio = 20f/30f,
            AverageWindSpeed = 12,
            FogDaysRatio = 15f/30f,
            DayLengthAverage = 10,
          },
          new MonthlyClimateData() // March
          {
            TemperatureAverage = 0,
            TemperatureHighAverage = 2, TemperatureLowAverage = -3,
            TemperatureHighest = 16, TemperatureLowest = -20,
            PrecipitationAverage = 26,
            PrecipitationDaysRatio = 21f/30f,
            AverageWindSpeed = 16,
            FogDaysRatio = 18f/30f,
            DayLengthAverage = 12.6f,
          },
          new MonthlyClimateData() // April
          {
            TemperatureAverage = 3,
            TemperatureHighAverage = 8, TemperatureLowAverage = 0,
            TemperatureHighest = 26, TemperatureLowest = -10,
            PrecipitationAverage = 30,
            PrecipitationDaysRatio = 20f/30f,
            AverageWindSpeed = 16,
            FogDaysRatio = 13f/30f,
            DayLengthAverage = 15.4f,
          },
          new MonthlyClimateData() // May
          {
            TemperatureAverage = 10,
            TemperatureHighAverage = 15, TemperatureLowAverage = 5,
            TemperatureHighest = 27, TemperatureLowest = -5,
            PrecipitationAverage = 30,
            PrecipitationDaysRatio = 17f/30f,
            AverageWindSpeed = 12,
            FogDaysRatio = 10f/30f,
            DayLengthAverage = 18.2f,
          },
          new MonthlyClimateData() // June
          {
            TemperatureAverage = 14,
            TemperatureHighAverage = 19, TemperatureLowAverage = 9,
            TemperatureHighest = 30, TemperatureLowest = 1,
            PrecipitationAverage = 45,
            PrecipitationDaysRatio = 18f/30f,
            AverageWindSpeed = 14,
            FogDaysRatio = 13f/30f,
            DayLengthAverage = 20.1f,
          },
          new MonthlyClimateData() // July
          {
            TemperatureAverage = 17,
            TemperatureHighAverage = 21, TemperatureLowAverage = 12,
            TemperatureHighest = 32, TemperatureLowest = 5,
            PrecipitationAverage = 72,
            PrecipitationDaysRatio = 20f/30f,
            AverageWindSpeed = 12,
            FogDaysRatio = 14f/30f,
            DayLengthAverage = 19,
          },
          new MonthlyClimateData() // August
          {
            TemperatureAverage = 16,
            TemperatureHighAverage = 20, TemperatureLowAverage = 11,
            TemperatureHighest = 35, TemperatureLowest = -1,
            PrecipitationAverage = 66,
            PrecipitationDaysRatio = 19f/30f,
            AverageWindSpeed = 12,
            FogDaysRatio = 17f/30f,
            DayLengthAverage = 16.3f,
          },
          new MonthlyClimateData() // September
          {
            TemperatureAverage = 11,
            TemperatureHighAverage = 14, TemperatureLowAverage = 7,
            TemperatureHighest = 26, TemperatureLowest = -5,
            PrecipitationAverage = 55,
            PrecipitationDaysRatio = 20f/30f,
            AverageWindSpeed = 14,
            FogDaysRatio = 15f/30f,
            DayLengthAverage = 13.5f,
          },
          new MonthlyClimateData() // October
          {
            TemperatureAverage = 6,
            TemperatureHighAverage = 8, TemperatureLowAverage = 3,
            TemperatureHighest = 20, TemperatureLowest = -11,
            PrecipitationAverage = 50,
            PrecipitationDaysRatio = 20f/30f,
            AverageWindSpeed = 9,
            FogDaysRatio = 17f/30f,
            DayLengthAverage = 10.8f,
          },
          new MonthlyClimateData() // November
          {
            TemperatureAverage = 1,
            TemperatureHighAverage = 3, TemperatureLowAverage = 0,
            TemperatureHighest = 12, TemperatureLowest = -15,
            PrecipitationAverage = 53,
            PrecipitationDaysRatio = 23f/30f,
            AverageWindSpeed = 12,
            FogDaysRatio = 14f/30f,
            DayLengthAverage = 8.4f,
          },
          new MonthlyClimateData() // December
          {
            TemperatureAverage = -2,
            TemperatureHighAverage = 0, TemperatureLowAverage = -5,
            TemperatureHighest = 10, TemperatureLowest = -26,
            PrecipitationAverage = 46,
            PrecipitationDaysRatio = 25f/30f,
            AverageWindSpeed = 12,
            FogDaysRatio = 15f/30f,
            DayLengthAverage = 7.1f,
          },
        }
      }},
      #endregion
      #region Finland, Helsinki
      // http://www.weatherbase.com/weather/weatherall.php3?s=47920&cityname=Helsinki%2C+Uusimaa%2C+Finland&units=
      new ClimatePreset() { PresetName = "Finland, Helsinki", PresetCode = "PRESET_FINLAND_HELSINKI", ClimateProperties = new ClimateControlProperties()
      {
        SnowFallTemperature = 2, SnowMeltTemperature = 10, SolarDayLength = 24.00f,
        ClimateData = new MonthlyClimateData[]
        {
          new MonthlyClimateData() // January
          {
            TemperatureAverage = -5,
            TemperatureHighAverage = -3, TemperatureLowAverage = -8,
            TemperatureHighest = 7, TemperatureLowest = -36,
            PrecipitationAverage = 40,
            PrecipitationDaysRatio = 16f/30f,
            AverageWindSpeed = 12,
            FogDaysRatio = 15f/30f,
            DayLengthAverage = 7.7f,
          },
          new MonthlyClimateData() // February
          {
            TemperatureAverage = -6,
            TemperatureHighAverage = -2, TemperatureLowAverage = -9,
            TemperatureHighest = 10, TemperatureLowest = -30,
            PrecipitationAverage = 30,
            PrecipitationDaysRatio = 11f/30f,
            AverageWindSpeed = 12,
            FogDaysRatio = 16f/30f,
            DayLengthAverage = 9.9f,
          },
          new MonthlyClimateData() // March
          {
            TemperatureAverage = -2,
            TemperatureHighAverage = 1, TemperatureLowAverage = -5,
            TemperatureHighest = 12, TemperatureLowest = -26,
            PrecipitationAverage = 30,
            PrecipitationDaysRatio = 12f/30f,
            AverageWindSpeed = 19,
            FogDaysRatio = 18f/30f,
            DayLengthAverage = 12.6f,
          },
          new MonthlyClimateData() // April
          {
            TemperatureAverage = 3,
            TemperatureHighAverage = 7, TemperatureLowAverage = 0,
            TemperatureHighest = 21, TemperatureLowest = -11,
            PrecipitationAverage = 30,
            PrecipitationDaysRatio = 13f/30f,
            AverageWindSpeed = 16,
            FogDaysRatio = 14f/30f,
            DayLengthAverage = 15.5f,
          },
          new MonthlyClimateData() // May
          {
            TemperatureAverage = 10,
            TemperatureHighAverage = 15, TemperatureLowAverage = 5,
            TemperatureHighest = 27, TemperatureLowest = -3,
            PrecipitationAverage = 40,
            PrecipitationDaysRatio = 14f/30f,
            AverageWindSpeed = 16,
            FogDaysRatio = 13f/30f,
            DayLengthAverage = 18.5f,
          },
          new MonthlyClimateData() // June
          {
            TemperatureAverage = 13,
            TemperatureHighAverage = 18, TemperatureLowAverage = 9,
            TemperatureHighest = 30, TemperatureLowest = -1,
            PrecipitationAverage = 40,
            PrecipitationDaysRatio = 17f/30f,
            AverageWindSpeed = 16,
            FogDaysRatio = 14f/30f,
            DayLengthAverage = 20.7f,
          },
          new MonthlyClimateData() // July
          {
            TemperatureAverage = 16,
            TemperatureHighAverage = 21, TemperatureLowAverage = 11,
            TemperatureHighest = 31, TemperatureLowest = 4,
            PrecipitationAverage = 60,
            PrecipitationDaysRatio = 15f/30f,
            AverageWindSpeed = 14,
            FogDaysRatio = 18f/30f,
            DayLengthAverage = 19.3f,
          },
          new MonthlyClimateData() // August
          {
            TemperatureAverage = 15,
            TemperatureHighAverage = 18, TemperatureLowAverage = 10,
            TemperatureHighest = 31, TemperatureLowest = 4,
            PrecipitationAverage = 70,
            PrecipitationDaysRatio = 17f/30f,
            AverageWindSpeed = 16,
            FogDaysRatio = 19f/30f,
            DayLengthAverage = 16.4f,
          },
          new MonthlyClimateData() // September
          {
            TemperatureAverage = 10,
            TemperatureHighAverage = 13, TemperatureLowAverage = 6,
            TemperatureHighest = 25, TemperatureLowest = -7,
            PrecipitationAverage = 60,
            PrecipitationDaysRatio = 15f/30f,
            AverageWindSpeed = 9,
            FogDaysRatio = 17f/30f,
            DayLengthAverage = 13.5f,
          },
          new MonthlyClimateData() // October
          {
            TemperatureAverage = 5,
            TemperatureHighAverage = 7, TemperatureLowAverage = 2,
            TemperatureHighest = 17, TemperatureLowest = -12,
            PrecipitationAverage = 60,
            PrecipitationDaysRatio = 20f/30f,
            AverageWindSpeed = 9,
            FogDaysRatio = 16f/30f,
            DayLengthAverage = 10.8f,
          },
          new MonthlyClimateData() // November
          {
            TemperatureAverage = 0,
            TemperatureHighAverage = 2, TemperatureLowAverage = -2,
            TemperatureHighest = 10, TemperatureLowest = -20,
            PrecipitationAverage = 60,
            PrecipitationDaysRatio = 17f/30f,
            AverageWindSpeed = 19,
            FogDaysRatio = 15f/30f,
            DayLengthAverage = 8.3f,
          },
          new MonthlyClimateData() // December
          {
            TemperatureAverage = -3,
            TemperatureHighAverage = -1, TemperatureLowAverage = -6,
            TemperatureHighest = 8, TemperatureLowest = -32,
            PrecipitationAverage = 50,
            PrecipitationDaysRatio = 16f/30f,
            AverageWindSpeed = 20,
            FogDaysRatio = 13f/30f,
            DayLengthAverage = 6.9f,
          },
        }
      }},
      #endregion
      #region Poland, Kraków
      // http://www.weatherbase.com/weather/weatherall.php3?s=66521&cityname=Krakow%2C+Lesser+Poland+Voivodeship%2C+Poland&units=
      new ClimatePreset() { PresetName = "Poland, Kraków", PresetCode = "PRESET_POLAND_KRAKÓW", ClimateProperties = new ClimateControlProperties()
      {
        SnowFallTemperature = 2, SnowMeltTemperature = 10, SolarDayLength = 24.00f,
        ClimateData = new MonthlyClimateData[]
        {
          new MonthlyClimateData() // January
          {
            TemperatureAverage = -2,
            TemperatureHighAverage = 0, TemperatureLowAverage = -5,
            TemperatureHighest = 15, TemperatureLowest = -30,
            PrecipitationAverage = 30,
            PrecipitationDaysRatio = 18f/30f,
            AverageWindSpeed = 14,
            FogDaysRatio = 24f/30f,
            DayLengthAverage = 9.3f,
          },
          new MonthlyClimateData() // February
          {
            TemperatureAverage = -1,
            TemperatureHighAverage = 1, TemperatureLowAverage = -4,
            TemperatureHighest = 18, TemperatureLowest = -27,
            PrecipitationAverage = 30,
            PrecipitationDaysRatio = 17f/30f,
            AverageWindSpeed = 14,
            FogDaysRatio = 22f/30f,
            DayLengthAverage = 10.7f,
          },
          new MonthlyClimateData() // March
          {
            TemperatureAverage = 3,
            TemperatureHighAverage = 7, TemperatureLowAverage = 0,
            TemperatureHighest = 22, TemperatureLowest = -17,
            PrecipitationAverage = 30,
            PrecipitationDaysRatio = 15f/30f,
            AverageWindSpeed = 16,
            FogDaysRatio = 23f/30f,
            DayLengthAverage = 12.5f,
          },
          new MonthlyClimateData() // April
          {
            TemperatureAverage = 7,
            TemperatureHighAverage = 12, TemperatureLowAverage = 3,
            TemperatureHighest = 28, TemperatureLowest = -7,
            PrecipitationAverage = 40,
            PrecipitationDaysRatio = 15f/30f,
            AverageWindSpeed = 14,
            FogDaysRatio = 19f/30f,
            DayLengthAverage = 14.4f,
          },
          new MonthlyClimateData() // May
          {
            TemperatureAverage = 12,
            TemperatureHighAverage = 17, TemperatureLowAverage = 7,
            TemperatureHighest = 30, TemperatureLowest = -2,
            PrecipitationAverage = 60,
            PrecipitationDaysRatio = 15f/30f,
            AverageWindSpeed = 12,
            FogDaysRatio = 19f/30f,
            DayLengthAverage = 16.1f,
          },
          new MonthlyClimateData() // June
          {
            TemperatureAverage = 16,
            TemperatureHighAverage = 20, TemperatureLowAverage = 11,
            TemperatureHighest = 31, TemperatureLowest = 1,
            PrecipitationAverage = 80,
            PrecipitationDaysRatio = 16f/30f,
            AverageWindSpeed = 12,
            FogDaysRatio = 20f/30f,
            DayLengthAverage = 17,
          },
          new MonthlyClimateData() // July
          {
            TemperatureAverage = 17,
            TemperatureHighAverage = 21, TemperatureLowAverage = 12,
            TemperatureHighest = 33, TemperatureLowest = 6,
            PrecipitationAverage = 60,
            PrecipitationDaysRatio = 14f/30f,
            AverageWindSpeed = 12,
            FogDaysRatio = 22f/30f,
            DayLengthAverage = 16.6f,
          },
          new MonthlyClimateData() // August
          {
            TemperatureAverage = 17,
            TemperatureHighAverage = 21, TemperatureLowAverage = 12,
            TemperatureHighest = 32, TemperatureLowest = 5,
            PrecipitationAverage = 70,
            PrecipitationDaysRatio = 13f/30f,
            AverageWindSpeed = 12,
            FogDaysRatio = 24f/30f,
            DayLengthAverage = 15,
          },
          new MonthlyClimateData() // September
          {
            TemperatureAverage = 13,
            TemperatureHighAverage = 17, TemperatureLowAverage = 8,
            TemperatureHighest = 28, TemperatureLowest = -2,
            PrecipitationAverage = 50,
            PrecipitationDaysRatio = 13f/30f,
            AverageWindSpeed = 12,
            FogDaysRatio = 25f/30f,
            DayLengthAverage = 13.1f,
          },
          new MonthlyClimateData() // October
          {
            TemperatureAverage = 8,
            TemperatureHighAverage = 12, TemperatureLowAverage = 4,
            TemperatureHighest = 26, TemperatureLowest = -7,
            PrecipitationAverage = 40,
            PrecipitationDaysRatio = 13f/30f,
            AverageWindSpeed = 14,
            FogDaysRatio = 24f/30f,
            DayLengthAverage = 11.2f,
          },
          new MonthlyClimateData() // November
          {
            TemperatureAverage = 2,
            TemperatureHighAverage = 5, TemperatureLowAverage = 0,
            TemperatureHighest = 18, TemperatureLowest = -17,
            PrecipitationAverage = 40,
            PrecipitationDaysRatio = 17f/30f,
            AverageWindSpeed = 14,
            FogDaysRatio = 23f/30f,
            DayLengthAverage = 9.6f,
          },
          new MonthlyClimateData() // December
          {
            TemperatureAverage = 0,
            TemperatureHighAverage = 2, TemperatureLowAverage = -3,
            TemperatureHighest = 17, TemperatureLowest = -22,
            PrecipitationAverage = 40,
            PrecipitationDaysRatio = 20f/30f,
            AverageWindSpeed = 16,
            FogDaysRatio = 23f/30f,
            DayLengthAverage = 8.8f,
          },
        }
      }},
      #endregion
      #region Egypt, Cairo
      // http://www.weatherbase.com/weather/weatherall.php3?s=66326&cityname=Cairo%2C+Muhafazat+al+Qahirah%2C+Egypt&units=
      new ClimatePreset() { PresetName = "Egypt, Cairo", PresetCode = "PRESET_EGYPT_CAIRO", ClimateProperties = new ClimateControlProperties()
      {
        SnowFallTemperature = 2, SnowMeltTemperature = 10, SolarDayLength = 24.00f,
        ClimateData = new MonthlyClimateData[]
        {
          new MonthlyClimateData() // January
          {
            TemperatureAverage = 13,
            TemperatureHighAverage = 18, TemperatureLowAverage = 9,
            TemperatureHighest = 30, TemperatureLowest = 0,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 5f/30f,
            AverageWindSpeed = 14,
            FogDaysRatio = 11f/30f,
            DayLengthAverage = 10.9f,
          },
          new MonthlyClimateData() // February
          {
            TemperatureAverage = 15,
            TemperatureHighAverage = 20, TemperatureLowAverage = 10,
            TemperatureHighest = 33, TemperatureLowest = 0,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 3f/30f,
            AverageWindSpeed = 16,
            FogDaysRatio = 7f/30f,
            DayLengthAverage = 11.6f,
          },
          new MonthlyClimateData() // March
          {
            TemperatureAverage = 17,
            TemperatureHighAverage = 22, TemperatureLowAverage = 12,
            TemperatureHighest = 37, TemperatureLowest = 2,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 2f/30f,
            AverageWindSpeed = 12,
            FogDaysRatio = 9f/30f,
            DayLengthAverage = 12.4f,
          },
          new MonthlyClimateData() // April
          {
            TemperatureAverage = 21,
            TemperatureHighAverage = 27, TemperatureLowAverage = 15,
            TemperatureHighest = 42, TemperatureLowest = 7,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 1f/30f,
            AverageWindSpeed = 14,
            FogDaysRatio = 7f/30f,
            DayLengthAverage = 13.3f,
          },
          new MonthlyClimateData() // May
          {
            TemperatureAverage = 25,
            TemperatureHighAverage = 31, TemperatureLowAverage = 17,
            TemperatureHighest = 43, TemperatureLowest = 12,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 1f/30f,
            AverageWindSpeed = 14,
            FogDaysRatio = 8f/30f,
            DayLengthAverage = 14.1f,
          },
          new MonthlyClimateData() // June
          {
            TemperatureAverage = 27,
            TemperatureHighAverage = 33, TemperatureLowAverage = 21,
            TemperatureHighest = 45, TemperatureLowest = 15,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 0,
            AverageWindSpeed = 14,
            FogDaysRatio = 11f/30f,
            DayLengthAverage = 14.5f,
          },
          new MonthlyClimateData() // July
          {
            TemperatureAverage = 28,
            TemperatureHighAverage = 33, TemperatureLowAverage = 22,
            TemperatureHighest = 42, TemperatureLowest = 17,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 0,
            AverageWindSpeed = 12,
            FogDaysRatio = 20f/30f,
            DayLengthAverage = 14.3f,
          },
          new MonthlyClimateData() // August
          {
            TemperatureAverage = 27,
            TemperatureHighAverage = 33, TemperatureLowAverage = 22,
            TemperatureHighest = 41, TemperatureLowest = 18,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 0,
            AverageWindSpeed = 12,
            FogDaysRatio = 23f/30f,
            DayLengthAverage = 13.6f,
          },
          new MonthlyClimateData() // September
          {
            TemperatureAverage = 26,
            TemperatureHighAverage = 32, TemperatureLowAverage = 20,
            TemperatureHighest = 43, TemperatureLowest = 16,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 0,
            AverageWindSpeed = 12,
            FogDaysRatio = 17f/30f,
            DayLengthAverage = 12.7f,
          },
          new MonthlyClimateData() // October
          {
            TemperatureAverage = 23,
            TemperatureHighAverage = 29, TemperatureLowAverage = 18,
            TemperatureHighest = 38, TemperatureLowest = 0,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 1f/30f,
            AverageWindSpeed = 12,
            FogDaysRatio = 15f/30f,
            DayLengthAverage = 11.8f,
          },
          new MonthlyClimateData() // November
          {
            TemperatureAverage = 19,
            TemperatureHighAverage = 23, TemperatureLowAverage = 14,
            TemperatureHighest = 35, TemperatureLowest = 2,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 1f/30f,
            AverageWindSpeed = 9,
            FogDaysRatio = 11f/30f,
            DayLengthAverage = 11.1f,
          },
          new MonthlyClimateData() // December
          {
            TemperatureAverage = 15,
            TemperatureHighAverage = 19, TemperatureLowAverage = 10,
            TemperatureHighest = 28, TemperatureLowest = 0,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 3f/30f,
            AverageWindSpeed = 12,
            FogDaysRatio = 12f/30f,
            DayLengthAverage = 10.7f,
          },
        }
      }},
      #endregion
      #region North Korea, Pyongyang
      // http://www.weatherbase.com/weather/weatherall.php3?s=85074&cityname=Pyongyang%2C+Pyongyang%2C+North+Korea&units=
      new ClimatePreset() { PresetName = "North Korea, Pyongyang", PresetCode = "PRESET_NORTH_KOREA_PYONGYANG", ClimateProperties = new ClimateControlProperties()
      {
        SnowFallTemperature = 2, SnowMeltTemperature = 10, SolarDayLength = 24.00f,
        ClimateData = new MonthlyClimateData[]
        {
          new MonthlyClimateData() // January
          {
            TemperatureAverage = -6,
            TemperatureHighAverage = -1, TemperatureLowAverage = -10,
            TemperatureHighest = 11, TemperatureLowest = -25,
            PrecipitationAverage = 10,
            PrecipitationDaysRatio = 3f/30f,
            AverageWindSpeed = 9,
            FogDaysRatio = 25f/30f,
            DayLengthAverage = 10.3f,
          },
          new MonthlyClimateData() // February
          {
            TemperatureAverage = -2,
            TemperatureHighAverage = 1, TemperatureLowAverage = -7,
            TemperatureHighest = 15, TemperatureLowest = -22,
            PrecipitationAverage = 10,
            PrecipitationDaysRatio = 3f/30f,
            AverageWindSpeed = 12,
            FogDaysRatio = 21f/30f,
            DayLengthAverage = 11.2f,
          },
          new MonthlyClimateData() // March
          {
            TemperatureAverage = 3,
            TemperatureHighAverage = 8, TemperatureLowAverage = -1,
            TemperatureHighest = 18, TemperatureLowest = -13,
            PrecipitationAverage = 20,
            PrecipitationDaysRatio = 5f/30f,
            AverageWindSpeed = 12,
            FogDaysRatio = 24f/30f,
            DayLengthAverage = 12.4f,
          },
          new MonthlyClimateData() // April
          {
            TemperatureAverage = 10,
            TemperatureHighAverage = 16, TemperatureLowAverage = 5,
            TemperatureHighest = 27, TemperatureLowest = -4,
            PrecipitationAverage = 40,
            PrecipitationDaysRatio = 8f/30f,
            AverageWindSpeed = 12,
            FogDaysRatio = 21f/30f,
            DayLengthAverage = 13.7f,
          },
          new MonthlyClimateData() // May
          {
            TemperatureAverage = 16,
            TemperatureHighAverage = 21, TemperatureLowAverage = 11,
            TemperatureHighest = 32, TemperatureLowest = 3,
            PrecipitationAverage = 60,
            PrecipitationDaysRatio = 10f/30f,
            AverageWindSpeed = 9,
            FogDaysRatio = 21f/30f,
            DayLengthAverage = 14.8f,
          },
          new MonthlyClimateData() // June
          {
            TemperatureAverage = 21,
            TemperatureHighAverage = 25, TemperatureLowAverage = 16,
            TemperatureHighest = 33, TemperatureLowest = 7,
            PrecipitationAverage = 70,
            PrecipitationDaysRatio = 11f/30f,
            AverageWindSpeed = 8,
            FogDaysRatio = 22f/30f,
            DayLengthAverage = 15.4f,
          },
          new MonthlyClimateData() // July
          {
            TemperatureAverage = 24,
            TemperatureHighAverage = 27, TemperatureLowAverage = 20,
            TemperatureHighest = 35, TemperatureLowest = 12,
            PrecipitationAverage = 250,
            PrecipitationDaysRatio = 16f/30f,
            AverageWindSpeed = 6,
            FogDaysRatio = 21f/30f,
            DayLengthAverage = 15.1f,
          },
          new MonthlyClimateData() // August
          {
            TemperatureAverage = 24,
            TemperatureHighAverage = 28, TemperatureLowAverage = 20,
            TemperatureHighest = 35, TemperatureLowest = 12,
            PrecipitationAverage = 230,
            PrecipitationDaysRatio = 12f/30f,
            AverageWindSpeed = 6,
            FogDaysRatio = 21f/30f,
            DayLengthAverage = 14.1f,
          },
          new MonthlyClimateData() // September
          {
            TemperatureAverage = 19,
            TemperatureHighAverage = 23, TemperatureLowAverage = 14,
            TemperatureHighest = 30, TemperatureLowest = 4,
            PrecipitationAverage = 110,
            PrecipitationDaysRatio = 8f/30f,
            AverageWindSpeed = 8,
            FogDaysRatio = 21f/30f,
            DayLengthAverage = 12.9f,
          },
          new MonthlyClimateData() // October
          {
            TemperatureAverage = 12,
            TemperatureHighAverage = 17, TemperatureLowAverage = 7,
            TemperatureHighest = 27, TemperatureLowest = -3,
            PrecipitationAverage = 40,
            PrecipitationDaysRatio = 7f/30f,
            AverageWindSpeed = 9,
            FogDaysRatio = 23f/30f,
            DayLengthAverage = 11.6f,
          },
          new MonthlyClimateData() // November
          {
            TemperatureAverage = 4,
            TemperatureHighAverage = 8, TemperatureLowAverage = 0,
            TemperatureHighest = 22, TemperatureLowest = -13,
            PrecipitationAverage = 40,
            PrecipitationDaysRatio = 8f/30f,
            AverageWindSpeed = 12,
            FogDaysRatio = 22f/30f,
            DayLengthAverage = 10.5f,
          },
          new MonthlyClimateData() // December
          {
            TemperatureAverage = -2,
            TemperatureHighAverage = 1, TemperatureLowAverage = -6,
            TemperatureHighest = 12, TemperatureLowest = -21,
            PrecipitationAverage = 20,
            PrecipitationDaysRatio = 4f/30f,
            AverageWindSpeed = 12,
            FogDaysRatio = 25f/30f,
            DayLengthAverage = 10,
          },
        }
      }},
      #endregion
      #region Russia, Moscow
      // http://www.weatherbase.com/weather/weatherall.php3?s=551572&cityname=Moscow%2C+Moscow%2C+Russia&units=
      new ClimatePreset() { PresetName = "Russia, Moscow", PresetCode = "PRESET_RUSSIA_MOSCOW", ClimateProperties = new ClimateControlProperties()
      {
        SnowFallTemperature = 2, SnowMeltTemperature = 10, SolarDayLength = 24.00f,
        ClimateData = new MonthlyClimateData[]
        {
          new MonthlyClimateData() // January
          {
            TemperatureAverage = -8,
            TemperatureHighAverage = -6, TemperatureLowAverage = -11,
            TemperatureHighest = 7, TemperatureLowest = -36,
            PrecipitationAverage = 30,
            PrecipitationDaysRatio = 6f/30f,
            AverageWindSpeed = 17,
            FogDaysRatio = 20f/30f,
            DayLengthAverage = 8.5f,
          },
          new MonthlyClimateData() // February
          {
            TemperatureAverage = -7,
            TemperatureHighAverage = -4, TemperatureLowAverage = -11,
            TemperatureHighest = 10, TemperatureLowest = -33,
            PrecipitationAverage = 20,
            PrecipitationDaysRatio = 5f/30f,
            AverageWindSpeed = 14,
            FogDaysRatio = 19f/30f,
            DayLengthAverage = 10.3f,
          },
          new MonthlyClimateData() // March
          {
            TemperatureAverage = -2,
            TemperatureHighAverage = 1, TemperatureLowAverage = -5,
            TemperatureHighest = 16, TemperatureLowest = -27,
            PrecipitationAverage = 30,
            PrecipitationDaysRatio = 7f/30f,
            AverageWindSpeed = 14,
            FogDaysRatio = 23f/30f,
            DayLengthAverage = 12.5f,
          },
          new MonthlyClimateData() // April
          {
            TemperatureAverage = 5,
            TemperatureHighAverage = 9, TemperatureLowAverage = 1,
            TemperatureHighest = 23, TemperatureLowest = -8,
            PrecipitationAverage = 30,
            PrecipitationDaysRatio = 10f/30f,
            AverageWindSpeed = 14,
            FogDaysRatio = 20f/30f,
            DayLengthAverage = 14.9f,
          },
          new MonthlyClimateData() // May
          {
            TemperatureAverage = 12,
            TemperatureHighAverage = 17, TemperatureLowAverage = 6,
            TemperatureHighest = 28, TemperatureLowest = -6,
            PrecipitationAverage = 50,
            PrecipitationDaysRatio = 12f/30f,
            AverageWindSpeed = 14,
            FogDaysRatio = 20f/30f,
            DayLengthAverage = 17.2f,
          },
          new MonthlyClimateData() // June
          {
            TemperatureAverage = 15,
            TemperatureHighAverage = 20, TemperatureLowAverage = 10,
            TemperatureHighest = 32, TemperatureLowest = 0,
            PrecipitationAverage = 60,
            PrecipitationDaysRatio = 12f/30f,
            AverageWindSpeed = 14,
            FogDaysRatio = 21f/30f,
            DayLengthAverage = 18.5f,
          },
          new MonthlyClimateData() // July
          {
            TemperatureAverage = 17,
            TemperatureHighAverage = 21, TemperatureLowAverage = 12,
            TemperatureHighest = 35, TemperatureLowest = 5,
            PrecipitationAverage = 80,
            PrecipitationDaysRatio = 11f/30f,
            AverageWindSpeed = 14,
            FogDaysRatio = 21f/30f,
            DayLengthAverage = 17.8f,
          },
          new MonthlyClimateData() // August
          {
            TemperatureAverage = 15,
            TemperatureHighAverage = 20, TemperatureLowAverage = 11,
            TemperatureHighest = 32, TemperatureLowest = 0,
            PrecipitationAverage = 70,
            PrecipitationDaysRatio = 11f/30f,
            AverageWindSpeed = 14,
            FogDaysRatio = 24f/30f,
            DayLengthAverage = 15.7f,
          },
          new MonthlyClimateData() // September
          {
            TemperatureAverage = 10,
            TemperatureHighAverage = 13, TemperatureLowAverage = 6,
            TemperatureHighest = 28, TemperatureLowest = -6,
            PrecipitationAverage = 50,
            PrecipitationDaysRatio = 11f/30f,
            AverageWindSpeed = 16,
            FogDaysRatio = 22f/30f,
            DayLengthAverage = 13.3f,
          },
          new MonthlyClimateData() // October
          {
            TemperatureAverage = 3,
            TemperatureHighAverage = 7, TemperatureLowAverage = 0,
            TemperatureHighest = 22, TemperatureLowest = -13,
            PrecipitationAverage = 50,
            PrecipitationDaysRatio = 15f/30f,
            AverageWindSpeed = 16,
            FogDaysRatio = 21f/30f,
            DayLengthAverage = 11,
          },
          new MonthlyClimateData() // November
          {
            TemperatureAverage = -2,
            TemperatureHighAverage = 0, TemperatureLowAverage = -4,
            TemperatureHighest = 10, TemperatureLowest = -25,
            PrecipitationAverage = 40,
            PrecipitationDaysRatio = 9f/30f,
            AverageWindSpeed = 16,
            FogDaysRatio = 20f/30f,
            DayLengthAverage = 8.9f,
          },
          new MonthlyClimateData() // December
          {
            TemperatureAverage = -6,
            TemperatureHighAverage = -3, TemperatureLowAverage = -8,
            TemperatureHighest = 10, TemperatureLowest = -42,
            PrecipitationAverage = 40,
            PrecipitationDaysRatio = 6f/30f,
            AverageWindSpeed = 17,
            FogDaysRatio = 19f/30f,
            DayLengthAverage = 7.9f,
          },
        }
      }},
      #endregion
      #region China, Beijing
      // http://www.weatherbase.com/weather/weatherall.php3?s=11545&cityname=Beijing%2C+Beijing%2C+China&units=
      new ClimatePreset() { PresetName = "China, Beijing", PresetCode = "PRESET_CHINA_BEIJING", ClimateProperties = new ClimateControlProperties()
      {
        SnowFallTemperature = 2, SnowMeltTemperature = 10, SolarDayLength = 24.00f,
        ClimateData = new MonthlyClimateData[]
        {
          new MonthlyClimateData() // January
          {
            TemperatureAverage = -3,
            TemperatureHighAverage = 1, TemperatureLowAverage = -8,
            TemperatureHighest = 12, TemperatureLowest = -17,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 2f/30f,
            AverageWindSpeed = 14,
            FogDaysRatio = 12f/30f,
            DayLengthAverage = 10.2f,
          },
          new MonthlyClimateData() // February
          {
            TemperatureAverage = 0,
            TemperatureHighAverage = 3, TemperatureLowAverage = -5,
            TemperatureHighest = 17, TemperatureLowest = -15,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 3f/30f,
            AverageWindSpeed = 19,
            FogDaysRatio = 10f/30f,
            DayLengthAverage = 11.2f,
          },
          new MonthlyClimateData() // March
          {
            TemperatureAverage = 6,
            TemperatureHighAverage = 11, TemperatureLowAverage = 0,
            TemperatureHighest = 27, TemperatureLowest = -8,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 4f/30f,
            AverageWindSpeed = 12,
            FogDaysRatio = 12f/30f,
            DayLengthAverage = 12.4f,
          },
          new MonthlyClimateData() // April
          {
            TemperatureAverage = 13,
            TemperatureHighAverage = 19, TemperatureLowAverage = 8,
            TemperatureHighest = 32, TemperatureLowest = -1,
            PrecipitationAverage = 10,
            PrecipitationDaysRatio = 5f/30f,
            AverageWindSpeed = 14,
            FogDaysRatio = 11f/30f,
            DayLengthAverage = 13.8f,
          },
          new MonthlyClimateData() // May
          {
            TemperatureAverage = 20,
            TemperatureHighAverage = 25, TemperatureLowAverage = 13,
            TemperatureHighest = 37, TemperatureLowest = 3,
            PrecipitationAverage = 30,
            PrecipitationDaysRatio = 6f/30f,
            AverageWindSpeed = 12,
            FogDaysRatio = 14f/30f,
            DayLengthAverage = 14.9f,
          },
          new MonthlyClimateData() // June
          {
            TemperatureAverage = 24,
            TemperatureHighAverage = 29, TemperatureLowAverage = 18,
            TemperatureHighest = 40, TemperatureLowest = 8,
            PrecipitationAverage = 70,
            PrecipitationDaysRatio = 9f/30f,
            AverageWindSpeed = 12,
            FogDaysRatio = 17f/30f,
            DayLengthAverage = 15.5f,
          },
          new MonthlyClimateData() // July
          {
            TemperatureAverage = 26,
            TemperatureHighAverage = 30, TemperatureLowAverage = 22,
            TemperatureHighest = 40, TemperatureLowest = 17,
            PrecipitationAverage = 220,
            PrecipitationDaysRatio = 14f/30f,
            AverageWindSpeed = 8,
            FogDaysRatio = 26f/30f,
            DayLengthAverage = 15.2f,
          },
          new MonthlyClimateData() // August
          {
            TemperatureAverage = 25,
            TemperatureHighAverage = 29, TemperatureLowAverage = 20,
            TemperatureHighest = 41, TemperatureLowest = 12,
            PrecipitationAverage = 170,
            PrecipitationDaysRatio = 12f/30f,
            AverageWindSpeed = 8,
            FogDaysRatio = 25f/30f,
            DayLengthAverage = 14.2f,
          },
          new MonthlyClimateData() // September
          {
            TemperatureAverage = 20,
            TemperatureHighAverage = 25, TemperatureLowAverage = 15,
            TemperatureHighest = 33, TemperatureLowest = 2,
            PrecipitationAverage = 50,
            PrecipitationDaysRatio = 7f/30f,
            AverageWindSpeed = 8,
            FogDaysRatio = 22f/30f,
            DayLengthAverage = 12.9f,
          },
          new MonthlyClimateData() // October
          {
            TemperatureAverage = 13,
            TemperatureHighAverage = 18, TemperatureLowAverage = 8,
            TemperatureHighest = 28, TemperatureLowest = -2,
            PrecipitationAverage = 10,
            PrecipitationDaysRatio = 6f/30f,
            AverageWindSpeed = 9,
            FogDaysRatio = 21f/30f,
            DayLengthAverage = 11.6f,
          },
          new MonthlyClimateData() // November
          {
            TemperatureAverage = 5,
            TemperatureHighAverage = 9, TemperatureLowAverage = 0,
            TemperatureHighest = 23, TemperatureLowest = -12,
            PrecipitationAverage = 10,
            PrecipitationDaysRatio = 5f/30f,
            AverageWindSpeed = 19,
            FogDaysRatio = 19f/30f,
            DayLengthAverage = 10.5f,
          },
          new MonthlyClimateData() // December
          {
            TemperatureAverage = -1,
            TemperatureHighAverage = 2, TemperatureLowAverage = -5,
            TemperatureHighest = 18, TemperatureLowest = -14,
            PrecipitationAverage = 0,
            PrecipitationDaysRatio = 2f/30f,
            AverageWindSpeed = 14,
            FogDaysRatio = 16f/30f,
            DayLengthAverage = 9.9f,
          },
        }
      }},
      #endregion
      #region Brazil, São Paulo
      // http://www.weatherbase.com/weather/weatherall.php3?s=8738&cityname=S%E3o+Paulo%2C+Sao+Paulo%2C+Brazil&units=
      new ClimatePreset() { PresetName = "Brazil, São Paulo", PresetCode = "PRESET_BRAZIL_SÃO_PAULO", ClimateProperties = new ClimateControlProperties()
      {
        SnowFallTemperature = 2, SnowMeltTemperature = 10, SolarDayLength = 24.00f,
        ClimateData = new MonthlyClimateData[]
        {
          new MonthlyClimateData() // January
          {
            TemperatureAverage = 23,
            TemperatureHighAverage = 27, TemperatureLowAverage = 19,
            TemperatureHighest = 33, TemperatureLowest = 12,
            PrecipitationAverage = 240,
            PrecipitationDaysRatio = 20f/30f,
            AverageWindSpeed = 12,
            FogDaysRatio = 30f/30f,
            DayLengthAverage = 13.8f,
          },
          new MonthlyClimateData() // February
          {
            TemperatureAverage = 23,
            TemperatureHighAverage = 28, TemperatureLowAverage = 19,
            TemperatureHighest = 37, TemperatureLowest = 13,
            PrecipitationAverage = 200,
            PrecipitationDaysRatio = 18f/30f,
            AverageWindSpeed = 12,
            FogDaysRatio = 27f/30f,
            DayLengthAverage = 13.3f,
          },
          new MonthlyClimateData() // March
          {
            TemperatureAverage = 23,
            TemperatureHighAverage = 27, TemperatureLowAverage = 18,
            TemperatureHighest = 38, TemperatureLowest = 12,
            PrecipitationAverage = 140,
            PrecipitationDaysRatio = 16f/30f,
            AverageWindSpeed = 12,
            FogDaysRatio = 31f/31f,
            DayLengthAverage = 12.6f,
          },
          new MonthlyClimateData() // April
          {
            TemperatureAverage = 21,
            TemperatureHighAverage = 25, TemperatureLowAverage = 17,
            TemperatureHighest = 32, TemperatureLowest = 8,
            PrecipitationAverage = 50,
            PrecipitationDaysRatio = 10f/30f,
            AverageWindSpeed = 12,
            FogDaysRatio = 30f/30f,
            DayLengthAverage = 11.9f,
          },
          new MonthlyClimateData() // May
          {
            TemperatureAverage = 18,
            TemperatureHighAverage = 23, TemperatureLowAverage = 15,
            TemperatureHighest = 29, TemperatureLowest = 2,
            PrecipitationAverage = 40,
            PrecipitationDaysRatio = 9f/30f,
            AverageWindSpeed = 9,
            FogDaysRatio = 30f/30f,
            DayLengthAverage = 11.4f,
          },
          new MonthlyClimateData() // June
          {
            TemperatureAverage = 17,
            TemperatureHighAverage = 21, TemperatureLowAverage = 13,
            TemperatureHighest = 28, TemperatureLowest = 2,
            PrecipitationAverage = 30,
            PrecipitationDaysRatio = 7f/30f,
            AverageWindSpeed = 9,
            FogDaysRatio = 29f/30f,
            DayLengthAverage = 11.1f,
          },
          new MonthlyClimateData() // July
          {
            TemperatureAverage = 17,
            TemperatureHighAverage = 21, TemperatureLowAverage = 12,
            TemperatureHighest = 28, TemperatureLowest = 2,
            PrecipitationAverage = 20,
            PrecipitationDaysRatio = 8f/30f,
            AverageWindSpeed = 9,
            FogDaysRatio = 29f/30f,
            DayLengthAverage = 11.3f,
          },
          new MonthlyClimateData() // August
          {
            TemperatureAverage = 18,
            TemperatureHighAverage = 22, TemperatureLowAverage = 13,
            TemperatureHighest = 33, TemperatureLowest = 3,
            PrecipitationAverage = 30,
            PrecipitationDaysRatio = 8f/30f,
            AverageWindSpeed = 12,
            FogDaysRatio = 29f/30f,
            DayLengthAverage = 11.7f,
          },
          new MonthlyClimateData() // September
          {
            TemperatureAverage = 18,
            TemperatureHighAverage = 22, TemperatureLowAverage = 13,
            TemperatureHighest = 35, TemperatureLowest = 3,
            PrecipitationAverage = 50,
            PrecipitationDaysRatio = 13f/30f,
            AverageWindSpeed = 14,
            FogDaysRatio = 29f/30f,
            DayLengthAverage = 12.4f,
          },
          new MonthlyClimateData() // October
          {
            TemperatureAverage = 20,
            TemperatureHighAverage = 25, TemperatureLowAverage = 15,
            TemperatureHighest = 34, TemperatureLowest = 7,
            PrecipitationAverage = 140,
            PrecipitationDaysRatio = 16f/30f,
            AverageWindSpeed = 14,
            FogDaysRatio = 30f/30f,
            DayLengthAverage = 13.1f,
          },
          new MonthlyClimateData() // November
          {
            TemperatureAverage = 21,
            TemperatureHighAverage = 25, TemperatureLowAverage = 17,
            TemperatureHighest = 35, TemperatureLowest = 10,
            PrecipitationAverage = 120,
            PrecipitationDaysRatio = 15f/30f,
            AverageWindSpeed = 14,
            FogDaysRatio = 28f/30f,
            DayLengthAverage = 13.7f,
          },
          new MonthlyClimateData() // December
          {
            TemperatureAverage = 22,
            TemperatureHighAverage = 26, TemperatureLowAverage = 18,
            TemperatureHighest = 32, TemperatureLowest = 12,
            PrecipitationAverage = 190,
            PrecipitationDaysRatio = 18f/30f,
            AverageWindSpeed = 14,
            FogDaysRatio = 30f/30f,
            DayLengthAverage = 14,
          },
        }
      }},
      #endregion
      #region USA, New York
      // http://www.weatherbase.com/weather/weatherall.php3?s=330527&cityname=New+York%2C+New+York%2C+United+States+of+America&units=
      new ClimatePreset() { PresetName = "USA, New York", PresetCode = "PRESET_USA_NEW_YORK", ClimateProperties = new ClimateControlProperties()
      {
        SnowFallTemperature = 2, SnowMeltTemperature = 10, SolarDayLength = 24.00f,
        ClimateData = new MonthlyClimateData[]
        {
          new MonthlyClimateData() // January
          {
            TemperatureAverage = 0.5f,
            TemperatureHighAverage = 4.1f, TemperatureLowAverage = -3,
            TemperatureHighest = 22.2f, TemperatureLowest = -21.1f,
            PrecipitationAverage = 81.3f,
            PrecipitationDaysRatio = 10f/30f,
            AverageWindSpeed = 21.1f,
            FogDaysRatio = 0,
            DayLengthAverage = 10.2f,
          },
          new MonthlyClimateData() // February
          {
            TemperatureAverage = 1.8f,
            TemperatureHighAverage = 5.7f, TemperatureLowAverage = -1.9f,
            TemperatureHighest = 23.9f, TemperatureLowest = -26.1f,
            PrecipitationAverage = 71.1f,
            PrecipitationDaysRatio = 9f/30f,
            AverageWindSpeed = 21.1f,
            FogDaysRatio = 0,
            DayLengthAverage = 11.2f,
          },
          new MonthlyClimateData() // March
          {
            TemperatureAverage = 5.7f,
            TemperatureHighAverage = 9.9f, TemperatureLowAverage = 1.4f,
            TemperatureHighest = 30, TemperatureLowest = -16.1f,
            PrecipitationAverage = 101.6f,
            PrecipitationDaysRatio = 11f/30f,
            AverageWindSpeed = 21.1f,
            FogDaysRatio = 0,
            DayLengthAverage = 12.5f,
          },
          new MonthlyClimateData() // April
          {
            TemperatureAverage = 11.5f,
            TemperatureHighAverage = 16.1f, TemperatureLowAverage = 6.9f,
            TemperatureHighest = 35.6f, TemperatureLowest = -11.1f,
            PrecipitationAverage = 101.6f,
            PrecipitationDaysRatio = 11f/30f,
            AverageWindSpeed = 19.8f,
            FogDaysRatio = 0,
            DayLengthAverage = 13.8f,
          },
          new MonthlyClimateData() // May
          {
            TemperatureAverage = 16.9f,
            TemperatureHighAverage = 21.8f, TemperatureLowAverage = 12.2f,
            TemperatureHighest = 37.2f, TemperatureLowest = 0,
            PrecipitationAverage = 96.5f,
            PrecipitationDaysRatio = 11f/30f,
            AverageWindSpeed = 17.9f,
            FogDaysRatio = 0,
            DayLengthAverage = 15,
          },
          new MonthlyClimateData() // June
          {
            TemperatureAverage = 22.3f,
            TemperatureHighAverage = 26.9f, TemperatureLowAverage = 17.7f,
            TemperatureHighest = 38.3f, TemperatureLowest = 6.7f,
            PrecipitationAverage = 99.1f,
            PrecipitationDaysRatio = 9f/30f,
            AverageWindSpeed = 16.7f,
            FogDaysRatio = 0,
            DayLengthAverage = 15.6f,
          },
          new MonthlyClimateData() // July
          {
            TemperatureAverage = 25.2f,
            TemperatureHighAverage = 29.6f, TemperatureLowAverage = 20.8f,
            TemperatureHighest = 41.1f, TemperatureLowest = 11.1f,
            PrecipitationAverage = 114.3f,
            PrecipitationDaysRatio = 8f/30f,
            AverageWindSpeed = 16.1f,
            FogDaysRatio = 0,
            DayLengthAverage = 15.3f,
          },
          new MonthlyClimateData() // August
          {
            TemperatureAverage = 24.6f,
            TemperatureHighAverage = 28.7f, TemperatureLowAverage = 20.5f,
            TemperatureHighest = 40, TemperatureLowest = 10,
            PrecipitationAverage = 104.1f,
            PrecipitationDaysRatio = 9f/30f,
            AverageWindSpeed = 15.9f,
            FogDaysRatio = 0,
            DayLengthAverage = 14.2f,
          },
          new MonthlyClimateData() // September
          {
            TemperatureAverage = 20.6f,
            TemperatureHighAverage = 24.6f, TemperatureLowAverage = 16.6f,
            TemperatureHighest = 38.9f, TemperatureLowest = 3.9f,
            PrecipitationAverage = 94,
            PrecipitationDaysRatio = 8f/30f,
            AverageWindSpeed = 17.1f,
            FogDaysRatio = 0,
            DayLengthAverage = 12.9f,
          },
          new MonthlyClimateData() // October
          {
            TemperatureAverage = 14.5f,
            TemperatureHighAverage = 18.4f, TemperatureLowAverage = 10.6f,
            TemperatureHighest = 34.4f, TemperatureLowest = -2.2f,
            PrecipitationAverage = 96.5f,
            PrecipitationDaysRatio = 7f/30f,
            AverageWindSpeed = 18,
            FogDaysRatio = 0,
            DayLengthAverage = 11.5f,
          },
          new MonthlyClimateData() // November
          {
            TemperatureAverage = 9.1f,
            TemperatureHighAverage = 12.6f, TemperatureLowAverage = 5.4f,
            TemperatureHighest = 28.9f, TemperatureLowest = -15,
            PrecipitationAverage = 86.4f,
            PrecipitationDaysRatio = 10f/30f,
            AverageWindSpeed = 19.8f,
            FogDaysRatio = 1f/30f,
            DayLengthAverage = 10.4f,
          },
          new MonthlyClimateData() // December
          {
            TemperatureAverage = 3.4f,
            TemperatureHighAverage = 6.8f, TemperatureLowAverage = 0.1f,
            TemperatureHighest = 23.9f, TemperatureLowest = -25,
            PrecipitationAverage = 91.4f,
            PrecipitationDaysRatio = 11f/30f,
            AverageWindSpeed = 20.8f,
            FogDaysRatio = 0,
            DayLengthAverage = 9.8f,
          },
        }
      }},
      #endregion

      #region Empty Pattern to use
      //// 
      //new ClimatePreset() { PresetName = "", PresetCode = "PRESET_", ClimateProperties = new ClimateControlProperties()
      //{
      //  SnowFallTemperature = , SnowMeltTemperature = , SolarDayLength = ,
      //  ClimateData = new MonthlyClimateData[]
      //  {
      //    new MonthlyClimateData() // January
      //    {
      //      TemperatureAverage = ,
      //      TemperatureHighAverage = , TemperatureLowAverage = ,
      //      TemperatureHighest = , TemperatureLowest = ,
      //      PrecipitationAverage = ,
      //      PrecipitationDaysRatio = ,
      //      AverageWindSpeed = ,
      //      FogDaysRatio = ,
      //      DayLengthAverage = ,
      //    },
      //    new MonthlyClimateData() // February
      //    {
      //      TemperatureAverage = ,
      //      TemperatureHighAverage = , TemperatureLowAverage = ,
      //      TemperatureHighest = , TemperatureLowest = ,
      //      PrecipitationAverage = ,
      //      PrecipitationDaysRatio = ,
      //      AverageWindSpeed = ,
      //      FogDaysRatio = ,
      //      DayLengthAverage = ,
      //    },
      //    new MonthlyClimateData() // March
      //    {
      //      TemperatureAverage = ,
      //      TemperatureHighAverage = , TemperatureLowAverage = ,
      //      TemperatureHighest = , TemperatureLowest = ,
      //      PrecipitationAverage = ,
      //      PrecipitationDaysRatio = ,
      //      AverageWindSpeed = ,
      //      FogDaysRatio = ,
      //      DayLengthAverage = ,
      //    },
      //    new MonthlyClimateData() // April
      //    {
      //      TemperatureAverage = ,
      //      TemperatureHighAverage = , TemperatureLowAverage = ,
      //      TemperatureHighest = , TemperatureLowest = ,
      //      PrecipitationAverage = ,
      //      PrecipitationDaysRatio = ,
      //      AverageWindSpeed = ,
      //      FogDaysRatio = ,
      //      DayLengthAverage = ,
      //    },
      //    new MonthlyClimateData() // May
      //    {
      //      TemperatureAverage = ,
      //      TemperatureHighAverage = , TemperatureLowAverage = ,
      //      TemperatureHighest = , TemperatureLowest = ,
      //      PrecipitationAverage = ,
      //      PrecipitationDaysRatio = ,
      //      AverageWindSpeed = ,
      //      FogDaysRatio = ,
      //      DayLengthAverage = ,
      //    },
      //    new MonthlyClimateData() // June
      //    {
      //      TemperatureAverage = ,
      //      TemperatureHighAverage = , TemperatureLowAverage = ,
      //      TemperatureHighest = , TemperatureLowest = ,
      //      PrecipitationAverage = ,
      //      PrecipitationDaysRatio = ,
      //      AverageWindSpeed = ,
      //      FogDaysRatio = ,
      //      DayLengthAverage = ,
      //    },
      //    new MonthlyClimateData() // July
      //    {
      //      TemperatureAverage = ,
      //      TemperatureHighAverage = , TemperatureLowAverage = ,
      //      TemperatureHighest = , TemperatureLowest = ,
      //      PrecipitationAverage = ,
      //      PrecipitationDaysRatio = ,
      //      AverageWindSpeed = ,
      //      FogDaysRatio = ,
      //      DayLengthAverage = ,
      //    },
      //    new MonthlyClimateData() // August
      //    {
      //      TemperatureAverage = ,
      //      TemperatureHighAverage = , TemperatureLowAverage = ,
      //      TemperatureHighest = , TemperatureLowest = ,
      //      PrecipitationAverage = ,
      //      PrecipitationDaysRatio = ,
      //      AverageWindSpeed = ,
      //      FogDaysRatio = ,
      //      DayLengthAverage = ,
      //    },
      //    new MonthlyClimateData() // September
      //    {
      //      TemperatureAverage = ,
      //      TemperatureHighAverage = , TemperatureLowAverage = ,
      //      TemperatureHighest = , TemperatureLowest = ,
      //      PrecipitationAverage = ,
      //      PrecipitationDaysRatio = ,
      //      AverageWindSpeed = ,
      //      FogDaysRatio = ,
      //      DayLengthAverage = ,
      //    },
      //    new MonthlyClimateData() // October
      //    {
      //      TemperatureAverage = ,
      //      TemperatureHighAverage = , TemperatureLowAverage = ,
      //      TemperatureHighest = , TemperatureLowest = ,
      //      PrecipitationAverage = ,
      //      PrecipitationDaysRatio = ,
      //      AverageWindSpeed = ,
      //      FogDaysRatio = ,
      //      DayLengthAverage = ,
      //    },
      //    new MonthlyClimateData() // November
      //    {
      //      TemperatureAverage = ,
      //      TemperatureHighAverage = , TemperatureLowAverage = ,
      //      TemperatureHighest = , TemperatureLowest = ,
      //      PrecipitationAverage = ,
      //      PrecipitationDaysRatio = ,
      //      AverageWindSpeed = ,
      //      FogDaysRatio = ,
      //      DayLengthAverage = ,
      //    },
      //    new MonthlyClimateData() // December
      //    {
      //      TemperatureAverage = ,
      //      TemperatureHighAverage = , TemperatureLowAverage = ,
      //      TemperatureHighest = , TemperatureLowest = ,
      //      PrecipitationAverage = ,
      //      PrecipitationDaysRatio = ,
      //      AverageWindSpeed = ,
      //      FogDaysRatio = ,
      //      DayLengthAverage = ,
      //    },
      //  }
      //}},
      #endregion
    };
  }
}
