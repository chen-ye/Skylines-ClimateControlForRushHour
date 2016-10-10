namespace Runaurufu.ClimateControl
{
  partial class ModSettings
  {
    private const float DaysInMonthJanuary = 31;
    private const float DaysInMonthFebruary = 28.25f;
    private const float DaysInMonthMarch = 31;
    private const float DaysInMonthApril = 30;
    private const float DaysInMonthMay = 31;
    private const float DaysInMonthJune = 30;
    private const float DaysInMonthJuly = 31;
    private const float DaysInMonthAugust = 31;
    private const float DaysInMonthSeptember = 30;
    private const float DaysInMonthOctober = 31;
    private const float DaysInMonthNovember = 30;
    private const float DaysInMonthDecember = 31;

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
            PrecipitationAverage = 0f/DaysInMonthJanuary,
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
            PrecipitationAverage = 0f/DaysInMonthFebruary,
            PrecipitationDaysRatio = 0f/DaysInMonthFebruary,
            AverageWindSpeed= 27,
            FogDaysRatio = 0f/DaysInMonthFebruary,
            DayLengthAverage = 0,
          },
          new MonthlyClimateData() // March
          {
            TemperatureAverage = -31,
            TemperatureHighAverage = -30, TemperatureLowAverage = -34,
            TemperatureHighest = -11, TemperatureLowest = -50,
            PrecipitationAverage = 0f/DaysInMonthMarch,
            PrecipitationDaysRatio = 0f/DaysInMonthMarch,
            AverageWindSpeed= 27,
            FogDaysRatio = 0f/DaysInMonthMarch,
            DayLengthAverage = 18,
          },
          new MonthlyClimateData() // April
          {
            TemperatureAverage = -23,
            TemperatureHighAverage = -22, TemperatureLowAverage = -26,
            TemperatureHighest = -6, TemperatureLowest = -41,
            PrecipitationAverage = 0f/DaysInMonthApril,
            PrecipitationDaysRatio = 0f/DaysInMonthApril,
            AverageWindSpeed= 27,
            FogDaysRatio = 0f/DaysInMonthApril,
            DayLengthAverage = 23,
          },
          new MonthlyClimateData() // May
          {
            TemperatureAverage = -11,
            TemperatureHighAverage = -9, TemperatureLowAverage = -12,
            TemperatureHighest = 3, TemperatureLowest = -24,
            PrecipitationAverage = 0f/DaysInMonthMay,
            PrecipitationDaysRatio = 0f/DaysInMonthMay,
            AverageWindSpeed= 25,
            FogDaysRatio = 0f/DaysInMonthMay,
            DayLengthAverage = 24,
          },
          new MonthlyClimateData() // June
          {
            TemperatureAverage = -1,
            TemperatureHighAverage = 0, TemperatureLowAverage = -2,
            TemperatureHighest = 10, TemperatureLowest = -12,
            PrecipitationAverage = 0f/DaysInMonthJune,
            PrecipitationDaysRatio = 0f/DaysInMonthJune,
            AverageWindSpeed= 22,
            FogDaysRatio = 0f/DaysInMonthJune,
            DayLengthAverage = 24,
          },
          new MonthlyClimateData() // July
          {
            TemperatureAverage = 1,
            TemperatureHighAverage = 2, TemperatureLowAverage = 0,
            TemperatureHighest = 13, TemperatureLowest = -2,
            PrecipitationAverage = 0f/DaysInMonthJuly,
            PrecipitationDaysRatio = 0f/DaysInMonthJuly,
            AverageWindSpeed= 27,
            FogDaysRatio = 0f/DaysInMonthJuly,
            DayLengthAverage = 24,
          },
          new MonthlyClimateData() // August
          {
            TemperatureAverage = 0,
            TemperatureHighAverage = 1, TemperatureLowAverage = -1,
            TemperatureHighest = 12, TemperatureLowest = -12,
            PrecipitationAverage = 0f/DaysInMonthAugust,
            PrecipitationDaysRatio = 0f/DaysInMonthAugust,
            AverageWindSpeed= 25,
            FogDaysRatio = 0f/DaysInMonthAugust,
            DayLengthAverage = 22.5f,
          },
          new MonthlyClimateData() // September
          {
            TemperatureAverage = -9,
            TemperatureHighAverage = -7, TemperatureLowAverage = -11,
            TemperatureHighest = 7, TemperatureLowest = -31,
            PrecipitationAverage = 0f/DaysInMonthSeptember,
            PrecipitationDaysRatio = 0f/DaysInMonthSeptember,
            AverageWindSpeed= 25,
            FogDaysRatio = 0f/DaysInMonthSeptember,
            DayLengthAverage = 19.9f,
          },
          new MonthlyClimateData() // October
          {
            TemperatureAverage = -20,
            TemperatureHighAverage = 0, TemperatureLowAverage = -22,
            TemperatureHighest = -2, TemperatureLowest = -41,
            PrecipitationAverage = 0f/DaysInMonthOctober,
            PrecipitationDaysRatio = 0f/DaysInMonthOctober,
            AverageWindSpeed= 25,
            FogDaysRatio = 0f/DaysInMonthOctober,
            DayLengthAverage = 3.3f,
          },
          new MonthlyClimateData() // November
          {
            TemperatureAverage = -27,
            TemperatureHighAverage = -25, TemperatureLowAverage = -30,
            TemperatureHighest = -8, TemperatureLowest = -41,
            PrecipitationAverage = 0f/DaysInMonthNovember,
            PrecipitationDaysRatio = 0f/DaysInMonthNovember,
            AverageWindSpeed= 22,
            FogDaysRatio = 0f/DaysInMonthNovember,
            DayLengthAverage = 0,
          },
          new MonthlyClimateData() // December
          {
            TemperatureAverage = -28,
            TemperatureHighAverage = -26, TemperatureLowAverage = -31,
            TemperatureHighest = -6, TemperatureLowest = -47,
            PrecipitationAverage = 0f/DaysInMonthDecember,
            PrecipitationDaysRatio = 0f/DaysInMonthDecember,
            AverageWindSpeed= 27,
            FogDaysRatio = 0f/DaysInMonthDecember,
            DayLengthAverage = 0,
          },
        }
      }},

      #endregion North Pole

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
            PrecipitationAverage = 0f/DaysInMonthJanuary,
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
            PrecipitationAverage = 0f/DaysInMonthFebruary,
            PrecipitationDaysRatio = 0f/DaysInMonthFebruary,
            AverageWindSpeed = 14,
            FogDaysRatio = 11f/DaysInMonthFebruary,
            DayLengthAverage = 24,
          },
          new MonthlyClimateData() // March
          {
            TemperatureAverage = -52,
            TemperatureHighAverage = -50, TemperatureLowAverage = -56,
            TemperatureHighest = -26, TemperatureLowest = -71,
            PrecipitationAverage = 0f/DaysInMonthMarch,
            PrecipitationDaysRatio = 0f/DaysInMonthMarch,
            AverageWindSpeed = 22,
            FogDaysRatio = 14f/DaysInMonthMarch,
            DayLengthAverage = 17.8f,
          },
          new MonthlyClimateData() // April
          {
            TemperatureAverage = -56,
            TemperatureHighAverage = -52, TemperatureLowAverage = -60,
            TemperatureHighest = -27, TemperatureLowest = -75,
            PrecipitationAverage = 0f/DaysInMonthApril,
            PrecipitationDaysRatio = 0f/DaysInMonthApril,
            AverageWindSpeed = 17,
            FogDaysRatio = 9f/DaysInMonthApril,
            DayLengthAverage = 0,
          },
          new MonthlyClimateData() // May
          {
            TemperatureAverage = -56,
            TemperatureHighAverage = -53, TemperatureLowAverage = -61,
            TemperatureHighest = -30, TemperatureLowest = -78,
            PrecipitationAverage = 0f/DaysInMonthMay,
            PrecipitationDaysRatio = 0f/DaysInMonthMay,
            AverageWindSpeed = 27,
            FogDaysRatio = 6f/DaysInMonthMay,
            DayLengthAverage = 0,
          },
          new MonthlyClimateData() // June
          {
            TemperatureAverage = -57,
            TemperatureHighAverage = -53, TemperatureLowAverage = -61,
            TemperatureHighest = -31, TemperatureLowest = -82,
            PrecipitationAverage = 0f/DaysInMonthJune,
            PrecipitationDaysRatio = 0f/DaysInMonthJune,
            AverageWindSpeed = 28,
            FogDaysRatio = 4f/DaysInMonthJune,
            DayLengthAverage = 0,
          },
          new MonthlyClimateData() // July
          {
            TemperatureAverage = -58,
            TemperatureHighAverage = -55, TemperatureLowAverage = -63,
            TemperatureHighest = -33, TemperatureLowest = -80,
            PrecipitationAverage = 0f/DaysInMonthJuly,
            PrecipitationDaysRatio = 0f/DaysInMonthJuly,
            AverageWindSpeed = 27,
            FogDaysRatio = 4f/DaysInMonthJuly,
            DayLengthAverage = 0,
          },
          new MonthlyClimateData() // August
          {
            TemperatureAverage = -58,
            TemperatureHighAverage = -55, TemperatureLowAverage = -62,
            TemperatureHighest = -32, TemperatureLowest = -77,
            PrecipitationAverage = 0f/DaysInMonthAugust,
            PrecipitationDaysRatio = 0f/DaysInMonthAugust,
            AverageWindSpeed = 27,
            FogDaysRatio = 4f/DaysInMonthAugust,
            DayLengthAverage = 0,
          },
          new MonthlyClimateData() // September
          {
            TemperatureAverage = -58,
            TemperatureHighAverage = -55, TemperatureLowAverage = -62,
            TemperatureHighest = -29, TemperatureLowest = -79,
            PrecipitationAverage = 0f/DaysInMonthSeptember,
            PrecipitationDaysRatio = 0f/DaysInMonthSeptember,
            AverageWindSpeed = 27,
            FogDaysRatio = 10f/DaysInMonthSeptember,
            DayLengthAverage = 17.2f,
          },
          new MonthlyClimateData() // October
          {
            TemperatureAverage = -50,
            TemperatureHighAverage = -47, TemperatureLowAverage = -53,
            TemperatureHighest = -29, TemperatureLowest = -71,
            PrecipitationAverage = 0f/DaysInMonthOctober,
            PrecipitationDaysRatio = 0f/DaysInMonthOctober,
            AverageWindSpeed = 27,
            FogDaysRatio = 11f/DaysInMonthOctober,
            DayLengthAverage = 24,
          },
          new MonthlyClimateData() // November
          {
            TemperatureAverage = -37,
            TemperatureHighAverage = -36, TemperatureLowAverage = -39,
            TemperatureHighest = -18, TemperatureLowest = -55,
            PrecipitationAverage = 0f/DaysInMonthNovember,
            PrecipitationDaysRatio = 0f/DaysInMonthNovember,
            AverageWindSpeed = 20,
            FogDaysRatio = 9f/DaysInMonthNovember,
            DayLengthAverage = 24,
          },
          new MonthlyClimateData() // December
          {
            TemperatureAverage = -26,
            TemperatureHighAverage = -26, TemperatureLowAverage = -28,
            TemperatureHighest = -13, TemperatureLowest = -38,
            PrecipitationAverage = 0f/DaysInMonthDecember,
            PrecipitationDaysRatio = 0f/DaysInMonthDecember,
            AverageWindSpeed = 17,
            FogDaysRatio = 9f/DaysInMonthDecember,
            DayLengthAverage = 24,
          },
        }
      }},

      #endregion South Pole

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
            PrecipitationAverage = 0f/DaysInMonthJanuary,
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
            PrecipitationAverage = 0f/DaysInMonthFebruary,
            PrecipitationDaysRatio = 0f/DaysInMonthFebruary,
            AverageWindSpeed = 10,
            FogDaysRatio = 0.15f,
            DayLengthAverage = 12.33f,
          },
          new MonthlyClimateData() // March
          {
            TemperatureAverage = float.NaN,
            TemperatureHighAverage = -23, TemperatureLowAverage = -88,
            TemperatureHighest = 1, TemperatureLowest = -114,
            PrecipitationAverage = 0f/DaysInMonthMarch,
            PrecipitationDaysRatio = 0f/DaysInMonthMarch,
            AverageWindSpeed = 10,
            FogDaysRatio = 0.15f,
            DayLengthAverage = 12.33f,
          },
          new MonthlyClimateData() // April
          {
            TemperatureAverage = float.NaN,
            TemperatureHighAverage = -20, TemperatureLowAverage = -87,
            TemperatureHighest = 0, TemperatureLowest = -97,
            PrecipitationAverage = 0f/DaysInMonthApril,
            PrecipitationDaysRatio = 0f/DaysInMonthApril,
            AverageWindSpeed = 10,
            FogDaysRatio = 0.15f,
            DayLengthAverage = 12.33f,
          },
          new MonthlyClimateData() // May
          {
            TemperatureAverage = float.NaN,
            TemperatureHighAverage = -4, TemperatureLowAverage = -85,
            TemperatureHighest = 7, TemperatureLowest = -98,
            PrecipitationAverage = 0f/DaysInMonthMay,
            PrecipitationDaysRatio = 0f/DaysInMonthMay,
            AverageWindSpeed = 10,
            FogDaysRatio = 0.15f,
            DayLengthAverage = 12.33f,
          },
          new MonthlyClimateData() // June
          {
            TemperatureAverage = float.NaN,
            TemperatureHighAverage = 0, TemperatureLowAverage = -78,
            TemperatureHighest = 14, TemperatureLowest = -125,
            PrecipitationAverage = 0f/DaysInMonthJune,
            PrecipitationDaysRatio = 0f/DaysInMonthJune,
            AverageWindSpeed = 10,
            FogDaysRatio = 0.15f,
            DayLengthAverage = 12.33f,
          },
          new MonthlyClimateData() // July
          {
            TemperatureAverage = float.NaN,
            TemperatureHighAverage = 2, TemperatureLowAverage = -76,
            TemperatureHighest = 20, TemperatureLowest = -84,
            PrecipitationAverage = 0f/DaysInMonthJuly,
            PrecipitationDaysRatio = 0f/DaysInMonthJuly,
            AverageWindSpeed = 10,
            FogDaysRatio = 0.15f,
            DayLengthAverage = 12.33f,
          },
          new MonthlyClimateData() // August
          {
            TemperatureAverage = float.NaN,
            TemperatureHighAverage = 1, TemperatureLowAverage = -69,
            TemperatureHighest = 19, TemperatureLowest = -80,
            PrecipitationAverage = 0f/DaysInMonthAugust,
            PrecipitationDaysRatio = 0f/DaysInMonthAugust,
            AverageWindSpeed = 10,
            FogDaysRatio = 0.15f,
            DayLengthAverage = 12.33f,
          },
          new MonthlyClimateData() // September
          {
            TemperatureAverage = float.NaN,
            TemperatureHighAverage = 1, TemperatureLowAverage = -68,
            TemperatureHighest = 7, TemperatureLowest = -78,
            PrecipitationAverage = 0f/DaysInMonthSeptember,
            PrecipitationDaysRatio = 0f/DaysInMonthSeptember,
            AverageWindSpeed = 10,
            FogDaysRatio = 0.15f,
            DayLengthAverage = 12.33f,
          },
          new MonthlyClimateData() // October
          {
            TemperatureAverage = float.NaN,
            TemperatureHighAverage = 4, TemperatureLowAverage = -73,
            TemperatureHighest = 7, TemperatureLowest = -79,
            PrecipitationAverage = 0f/DaysInMonthOctober,
            PrecipitationDaysRatio = 0f/DaysInMonthOctober,
            AverageWindSpeed = 10,
            FogDaysRatio = 0.15f,
            DayLengthAverage = 12.33f,
          },
          new MonthlyClimateData() // November
          {
            TemperatureAverage = float.NaN,
            TemperatureHighAverage = -1, TemperatureLowAverage = -73,
            TemperatureHighest = 8, TemperatureLowest = -83,
            PrecipitationAverage = 0f/DaysInMonthNovember,
            PrecipitationDaysRatio = 0f/DaysInMonthNovember,
            AverageWindSpeed = 10,
            FogDaysRatio = 0.15f,
            DayLengthAverage = 12.33f,
          },
          new MonthlyClimateData() // December
          {
            TemperatureAverage = float.NaN,
            TemperatureHighAverage = -3, TemperatureLowAverage = -77,
            TemperatureHighest = 8, TemperatureLowest = -110,
            PrecipitationAverage = 0f/DaysInMonthDecember,
            PrecipitationDaysRatio = 0f/DaysInMonthDecember,
            AverageWindSpeed = 10,
            FogDaysRatio = 0.15f,
            DayLengthAverage = 12.33f,
          },
        }
      }},

      #endregion Planet Mars

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
            PrecipitationAverage = 240f/DaysInMonthJanuary,
            PrecipitationDaysRatio = 20f/DaysInMonthJanuary,
            AverageWindSpeed = 12,
            FogDaysRatio = 30f/DaysInMonthJanuary,
            DayLengthAverage = 13.8f,
          },
          new MonthlyClimateData() // February
          {
            TemperatureAverage = 23,
            TemperatureHighAverage = 28, TemperatureLowAverage = 19,
            TemperatureHighest = 37, TemperatureLowest = 13,
            PrecipitationAverage = 200f/DaysInMonthFebruary,
            PrecipitationDaysRatio = 18f/DaysInMonthFebruary,
            AverageWindSpeed = 12,
            FogDaysRatio = 27f/DaysInMonthFebruary,
            DayLengthAverage = 13.3f,
          },
          new MonthlyClimateData() // March
          {
            TemperatureAverage = 23,
            TemperatureHighAverage = 27, TemperatureLowAverage = 18,
            TemperatureHighest = 38, TemperatureLowest = 12,
            PrecipitationAverage = 140f/DaysInMonthMarch,
            PrecipitationDaysRatio = 16f/DaysInMonthMarch,
            AverageWindSpeed = 12,
            FogDaysRatio = 31f/DaysInMonthMarch,
            DayLengthAverage = 12.6f,
          },
          new MonthlyClimateData() // April
          {
            TemperatureAverage = 21,
            TemperatureHighAverage = 25, TemperatureLowAverage = 17,
            TemperatureHighest = 32, TemperatureLowest = 8,
            PrecipitationAverage = 50f/DaysInMonthApril,
            PrecipitationDaysRatio = 10f/DaysInMonthApril,
            AverageWindSpeed = 12,
            FogDaysRatio = 30f/DaysInMonthApril,
            DayLengthAverage = 11.9f,
          },
          new MonthlyClimateData() // May
          {
            TemperatureAverage = 18,
            TemperatureHighAverage = 23, TemperatureLowAverage = 15,
            TemperatureHighest = 29, TemperatureLowest = 2,
            PrecipitationAverage = 40f/DaysInMonthMay,
            PrecipitationDaysRatio = 9f/DaysInMonthMay,
            AverageWindSpeed = 9,
            FogDaysRatio = 30f/DaysInMonthMay,
            DayLengthAverage = 11.4f,
          },
          new MonthlyClimateData() // June
          {
            TemperatureAverage = 17,
            TemperatureHighAverage = 21, TemperatureLowAverage = 13,
            TemperatureHighest = 28, TemperatureLowest = 2,
            PrecipitationAverage = 30f/DaysInMonthJune,
            PrecipitationDaysRatio = 7f/DaysInMonthJune,
            AverageWindSpeed = 9,
            FogDaysRatio = 29f/DaysInMonthJune,
            DayLengthAverage = 11.1f,
          },
          new MonthlyClimateData() // July
          {
            TemperatureAverage = 17,
            TemperatureHighAverage = 21, TemperatureLowAverage = 12,
            TemperatureHighest = 28, TemperatureLowest = 2,
            PrecipitationAverage = 20f/DaysInMonthJuly,
            PrecipitationDaysRatio = 8f/DaysInMonthJuly,
            AverageWindSpeed = 9,
            FogDaysRatio = 29f/DaysInMonthJuly,
            DayLengthAverage = 11.3f,
          },
          new MonthlyClimateData() // August
          {
            TemperatureAverage = 18,
            TemperatureHighAverage = 22, TemperatureLowAverage = 13,
            TemperatureHighest = 33, TemperatureLowest = 3,
            PrecipitationAverage = 30f/DaysInMonthAugust,
            PrecipitationDaysRatio = 8f/DaysInMonthAugust,
            AverageWindSpeed = 12,
            FogDaysRatio = 29f/DaysInMonthAugust,
            DayLengthAverage = 11.7f,
          },
          new MonthlyClimateData() // September
          {
            TemperatureAverage = 18,
            TemperatureHighAverage = 22, TemperatureLowAverage = 13,
            TemperatureHighest = 35, TemperatureLowest = 3,
            PrecipitationAverage = 50f/DaysInMonthSeptember,
            PrecipitationDaysRatio = 13f/DaysInMonthSeptember,
            AverageWindSpeed = 14,
            FogDaysRatio = 29f/DaysInMonthSeptember,
            DayLengthAverage = 12.4f,
          },
          new MonthlyClimateData() // October
          {
            TemperatureAverage = 20,
            TemperatureHighAverage = 25, TemperatureLowAverage = 15,
            TemperatureHighest = 34, TemperatureLowest = 7,
            PrecipitationAverage = 140f/DaysInMonthOctober,
            PrecipitationDaysRatio = 16f/DaysInMonthOctober,
            AverageWindSpeed = 14,
            FogDaysRatio = 30f/DaysInMonthOctober,
            DayLengthAverage = 13.1f,
          },
          new MonthlyClimateData() // November
          {
            TemperatureAverage = 21,
            TemperatureHighAverage = 25, TemperatureLowAverage = 17,
            TemperatureHighest = 35, TemperatureLowest = 10,
            PrecipitationAverage = 120f/DaysInMonthNovember,
            PrecipitationDaysRatio = 15f/DaysInMonthNovember,
            AverageWindSpeed = 14,
            FogDaysRatio = 28f/DaysInMonthNovember,
            DayLengthAverage = 13.7f,
          },
          new MonthlyClimateData() // December
          {
            TemperatureAverage = 22,
            TemperatureHighAverage = 26, TemperatureLowAverage = 18,
            TemperatureHighest = 32, TemperatureLowest = 12,
            PrecipitationAverage = 190f/DaysInMonthDecember,
            PrecipitationDaysRatio = 18f/DaysInMonthDecember,
            AverageWindSpeed = 14,
            FogDaysRatio = 30f/DaysInMonthDecember,
            DayLengthAverage = 14,
          },
        }
      }},

      #endregion Brazil, São Paulo

      #region Canada, Baker Lake

      // http://www.weatherbase.com/weather/weatherall.php3?s=719260&cityname=Baker+Lake%2C+Nunavut%2C+Canada&units=
      new ClimatePreset() { PresetName = "Canada, Baker Lake", PresetCode = "PRESET_CANADA_BAKER_LAKE", ClimateProperties = new ClimateControlProperties()
      {
        SnowFallTemperature = 2f, SnowMeltTemperature = 8f, SolarDayLength = 24f,
        ClimateData = new MonthlyClimateData[]
        {
          new MonthlyClimateData() // January
          {
            TemperatureAverage = -31.3f,
            TemperatureHighAverage = -27.7f, TemperatureLowAverage = -34.8f,
            TemperatureHighest = -1.7f, TemperatureLowest = -50.6f,
            PrecipitationAverage = 6.2f/DaysInMonthJanuary,
            PrecipitationDaysRatio = 6.7f/DaysInMonthJanuary,
            AverageWindSpeed = 22.8f,
            FogDaysRatio = 0f/DaysInMonthJanuary,
            DayLengthAverage = 6.7f,
          },
          new MonthlyClimateData() // February
          {
            TemperatureAverage = -31.1f,
            TemperatureHighAverage = -27.7f, TemperatureLowAverage = -34.8f,
            TemperatureHighest = -4.1f, TemperatureLowest = -50f,
            PrecipitationAverage = 7.5f/DaysInMonthFebruary,
            PrecipitationDaysRatio = 7f/DaysInMonthFebruary,
            AverageWindSpeed = 22.1f,
            FogDaysRatio = 0f/DaysInMonthFebruary,
            DayLengthAverage = 9.5f,
          },
          new MonthlyClimateData() // March
          {
            TemperatureAverage = -26.3f,
            TemperatureHighAverage = -22, TemperatureLowAverage = -30.6f,
            TemperatureHighest = 1.5f, TemperatureLowest = -50f,
            PrecipitationAverage = 11.4f/DaysInMonthMarch,
            PrecipitationDaysRatio = 7.8f/DaysInMonthMarch,
            AverageWindSpeed = 20.9f,
            FogDaysRatio = 0f/DaysInMonthMarch,
            DayLengthAverage = 12.7f,
          },
          new MonthlyClimateData() // April
          {
            TemperatureAverage = -17f,
            TemperatureHighAverage = -12.3f, TemperatureLowAverage = -21.5f,
            TemperatureHighest = 5f, TemperatureLowest = -41.1f,
            PrecipitationAverage = 14f/DaysInMonthApril,
            PrecipitationDaysRatio = 8f/DaysInMonthApril,
            AverageWindSpeed = 20.1f,
            FogDaysRatio = 0f/DaysInMonthApril,
            DayLengthAverage = 16.2f,
          },
          new MonthlyClimateData() // May
          {
            TemperatureAverage = -6.4f,
            TemperatureHighAverage = -3f, TemperatureLowAverage = -9.8f,
            TemperatureHighest = 13.9f, TemperatureLowest = -27.8f,
            PrecipitationAverage = 14.5f/DaysInMonthMay,
            PrecipitationDaysRatio = 6.9f/DaysInMonthMay,
            AverageWindSpeed = 19.5f,
            FogDaysRatio = 0f/DaysInMonthMay,
            DayLengthAverage = 20,
          },
          new MonthlyClimateData() // June
          {
            TemperatureAverage = 4.9f,
            TemperatureHighAverage = 9.3f, TemperatureLowAverage = 0.5f,
            TemperatureHighest = 28.1f, TemperatureLowest = -13.9f,
            PrecipitationAverage = 23.1f/DaysInMonthJune,
            PrecipitationDaysRatio = 7.5f/DaysInMonthJune,
            AverageWindSpeed = 16.4f,
            FogDaysRatio = 0f/DaysInMonthJune,
            DayLengthAverage = 22.5f,
          },
          new MonthlyClimateData() // July
          {
            TemperatureAverage = 11.6f,
            TemperatureHighAverage = 17f, TemperatureLowAverage = 6.1f,
            TemperatureHighest = 33.6f, TemperatureLowest = -1.7f,
            PrecipitationAverage = 41.1f/DaysInMonthJuly,
            PrecipitationDaysRatio = 9.3f/DaysInMonthJuly,
            AverageWindSpeed = 15.4f,
            FogDaysRatio = 0f/DaysInMonthJuly,
            DayLengthAverage = 20.6f,
          },
          new MonthlyClimateData() // August
          {
            TemperatureAverage = 9.8f,
            TemperatureHighAverage = 14.3f, TemperatureLowAverage = 5.3f,
            TemperatureHighest = 30.9f, TemperatureLowest = -3.4f,
            PrecipitationAverage = 52f/DaysInMonthAugust,
            PrecipitationDaysRatio = 11.8f/DaysInMonthAugust,
            AverageWindSpeed = 17.4f,
            FogDaysRatio = 0f/DaysInMonthAugust,
            DayLengthAverage = 17.4f,
          },
          new MonthlyClimateData() // September
          {
            TemperatureAverage = 3.1f,
            TemperatureHighAverage = 6.4f, TemperatureLowAverage = -0.2f,
            TemperatureHighest = 22.6f, TemperatureLowest = -14.4f,
            PrecipitationAverage = 48.7f/DaysInMonthSeptember,
            PrecipitationDaysRatio = 13.3f/DaysInMonthSeptember,
            AverageWindSpeed = 19.1f,
            FogDaysRatio = 0f/DaysInMonthSeptember,
            DayLengthAverage = 13.7f,
          },
          new MonthlyClimateData() // October
          {
            TemperatureAverage = -6.5f,
            TemperatureHighAverage = -3.4f, TemperatureLowAverage = -9.5f,
            TemperatureHighest = 9.8f, TemperatureLowest = -30.6f,
            PrecipitationAverage = 27f/DaysInMonthOctober,
            PrecipitationDaysRatio = 14.5f/DaysInMonthOctober,
            AverageWindSpeed = 21.4f,
            FogDaysRatio = 0f/DaysInMonthOctober,
            DayLengthAverage = 10.5f,
          },
          new MonthlyClimateData() // November
          {
            TemperatureAverage = -19.3f,
            TemperatureHighAverage = -15.5f, TemperatureLowAverage = -23.1f,
            TemperatureHighest = 2.2f, TemperatureLowest = -42.7f,
            PrecipitationAverage = 16f/DaysInMonthNovember,
            PrecipitationDaysRatio = 9.6f/DaysInMonthNovember,
            AverageWindSpeed = 21.9f,
            FogDaysRatio = 0f/DaysInMonthNovember,
            DayLengthAverage = 7.4f,
          },
          new MonthlyClimateData() // December
          {
            TemperatureAverage = -26.8f,
            TemperatureHighAverage = -23.1f, TemperatureLowAverage = -30.5f,
            TemperatureHighest = 1.1f, TemperatureLowest = -45.6f,
            PrecipitationAverage = 11.1f/DaysInMonthDecember,
            PrecipitationDaysRatio = 8.3f/DaysInMonthDecember,
            AverageWindSpeed = 22.5f,
            FogDaysRatio = 0f/DaysInMonthDecember,
            DayLengthAverage = 5.6f,
          },
        }
      }},

      #endregion Canada, Baker Lake

      #region Canada, Toronto

      // http://www.weatherbase.com/weather/weatherall.php3?s=42617&cityname=Toronto%2C+Ontario%2C+Canada&units=
      new ClimatePreset() { PresetName = "Canada, Toronto", PresetCode = "PRESET_CANADA_TORONTO", ClimateProperties = new ClimateControlProperties()
      {
        SnowFallTemperature = 2f, SnowMeltTemperature = 8f, SolarDayLength = 24f,
        ClimateData = new MonthlyClimateData[]
        {
          new MonthlyClimateData() // January
          {
            TemperatureAverage = -5.8f,
            TemperatureHighAverage = -1.5f, TemperatureLowAverage = -10.1f,
            TemperatureHighest = 14.9f, TemperatureLowest = -35.2f,
            PrecipitationAverage = 62.1f/DaysInMonthJanuary,
            PrecipitationDaysRatio = 16.7f/DaysInMonthJanuary,
            AverageWindSpeed = 14,
            FogDaysRatio = 11f/DaysInMonthJanuary,
            DayLengthAverage = 9.9f,
          },
          new MonthlyClimateData() // February
          {
            TemperatureAverage = -5.6f,
            TemperatureHighAverage = -0.9f, TemperatureLowAverage = -10.2f,
            TemperatureHighest = 14.9f, TemperatureLowest = -25.7f,
            PrecipitationAverage = 50.5f/DaysInMonthFebruary,
            PrecipitationDaysRatio = 12.9f/DaysInMonthFebruary,
            AverageWindSpeed = 13.9f,
            FogDaysRatio = 10f/DaysInMonthFebruary,
            DayLengthAverage = 11f,
          },
          new MonthlyClimateData() // March
          {
            TemperatureAverage = -0.4f,
            TemperatureHighAverage = 4.5f, TemperatureLowAverage = -5.3f,
            TemperatureHighest = 26, TemperatureLowest = -25.6f,
            PrecipitationAverage = 53.2f/DaysInMonthMarch,
            PrecipitationDaysRatio = 12f/DaysInMonthMarch,
            AverageWindSpeed = 13.8f,
            FogDaysRatio = 13f/DaysInMonthMarch,
            DayLengthAverage = 12.5f,
          },
          new MonthlyClimateData() // April
          {
            TemperatureAverage = 6.7f,
            TemperatureHighAverage = 12.1f, TemperatureLowAverage = 1.2f,
            TemperatureHighest = 31.7f, TemperatureLowest = -10.6f,
            PrecipitationAverage = 74.1f/DaysInMonthApril,
            PrecipitationDaysRatio = 12.3f/DaysInMonthApril,
            AverageWindSpeed = 13.9f,
            FogDaysRatio = 11f/DaysInMonthApril,
            DayLengthAverage = 14f,
          },
          new MonthlyClimateData() // May
          {
            TemperatureAverage = 13,
            TemperatureHighAverage = 19.1f, TemperatureLowAverage = 6.8f,
            TemperatureHighest = 34.6f, TemperatureLowest = -2.1f,
            PrecipitationAverage = 79.6f/DaysInMonthMay,
            PrecipitationDaysRatio = 12f/DaysInMonthMay,
            AverageWindSpeed = 12.3f,
            FogDaysRatio = 13/DaysInMonthMay,
            DayLengthAverage = 15.3f,
          },
          new MonthlyClimateData() // June
          {
            TemperatureAverage = 18.6f,
            TemperatureHighAverage = 24.6f, TemperatureLowAverage = 12.6f,
            TemperatureHighest = 36.6f, TemperatureLowest = 1.9f,
            PrecipitationAverage = 82.8f/DaysInMonthJune,
            PrecipitationDaysRatio = 11.8f/DaysInMonthJune,
            AverageWindSpeed = 11.4f,
            FogDaysRatio = 12f/DaysInMonthJune,
            DayLengthAverage = 16f,
          },
          new MonthlyClimateData() // July
          {
            TemperatureAverage = 21.2f,
            TemperatureHighAverage = 27.1f, TemperatureLowAverage = 15.2f,
            TemperatureHighest = 37.2f, TemperatureLowest = 6.9f,
            PrecipitationAverage = 79f/DaysInMonthJuly,
            PrecipitationDaysRatio = 11.2f/DaysInMonthJuly,
            AverageWindSpeed = 10.7f,
            FogDaysRatio = 12f/DaysInMonthJuly,
            DayLengthAverage = 15.6f,
          },
          new MonthlyClimateData() // August
          {
            TemperatureAverage = 20.2f,
            TemperatureHighAverage = 26, TemperatureLowAverage = 14.3f,
            TemperatureHighest = 37.8f, TemperatureLowest = 4.2f,
            PrecipitationAverage = 76.2f/DaysInMonthAugust,
            PrecipitationDaysRatio = 9.9f/DaysInMonthAugust,
            AverageWindSpeed = 10,
            FogDaysRatio = 15f/DaysInMonthAugust,
            DayLengthAverage = 14.4f,
          },
          new MonthlyClimateData() // September
          {
            TemperatureAverage = 15.7f,
            TemperatureHighAverage = 21.5f, TemperatureLowAverage = 9.9f,
            TemperatureHighest = 34.4f, TemperatureLowest = -2,
            PrecipitationAverage = 81.8f/DaysInMonthSeptember,
            PrecipitationDaysRatio = 10.8f/DaysInMonthSeptember,
            AverageWindSpeed = 10.6f,
            FogDaysRatio = 15f/DaysInMonthSeptember,
            DayLengthAverage = 12.9f,
          },
          new MonthlyClimateData() // October
          {
            TemperatureAverage = 8.9f,
            TemperatureHighAverage = 14.1f, TemperatureLowAverage = 3.6f,
            TemperatureHighest = 31, TemperatureLowest = -7.4f,
            PrecipitationAverage = 68f/DaysInMonthOctober,
            PrecipitationDaysRatio = 13.2f/DaysInMonthOctober,
            AverageWindSpeed = 11.6f,
            FogDaysRatio = 15f/DaysInMonthOctober,
            DayLengthAverage = 11.5f,
          },
          new MonthlyClimateData() // November
          {
            TemperatureAverage = 3.1f,
            TemperatureHighAverage = 7.2f, TemperatureLowAverage = -1.1f,
            TemperatureHighest = 22.1f, TemperatureLowest = -15,
            PrecipitationAverage = 80f/DaysInMonthNovember,
            PrecipitationDaysRatio = 14.5f/DaysInMonthNovember,
            AverageWindSpeed = 12.9f,
            FogDaysRatio = 15f/DaysInMonthNovember,
            DayLengthAverage = 10.2f,
          },
          new MonthlyClimateData() // December
          {
            TemperatureAverage = -2.9f,
            TemperatureHighAverage = 0.9f, TemperatureLowAverage = -6.8f,
            TemperatureHighest = 18, TemperatureLowest = -26,
            PrecipitationAverage = 65.7f/DaysInMonthDecember,
            PrecipitationDaysRatio = 15.3f/DaysInMonthDecember,
            AverageWindSpeed = 13.4f,
            FogDaysRatio = 13f/DaysInMonthDecember,
            DayLengthAverage = 9.5f,
          },
        }
      }},

      #endregion Canada, Toronto

      #region Canada, Vancouver

      // http://www.weatherbase.com/weather/weatherall.php3?s=29817&cityname=Vancouver%2C+British+Columbia%2C+Canada&units=
      new ClimatePreset() { PresetName = "Canada, Vancouver", PresetCode = "PRESET_CANADA_VANCOUVER", ClimateProperties = new ClimateControlProperties()
      {
        SnowFallTemperature = 2f, SnowMeltTemperature = 8f, SolarDayLength = 24f,
        ClimateData = new MonthlyClimateData[]
        {
          new MonthlyClimateData() // January
          {
            TemperatureAverage = 4.1f,
            TemperatureHighAverage = 6.9f, TemperatureLowAverage = 1.4f,
            TemperatureHighest = 15.3f, TemperatureLowest = -17.8f,
            PrecipitationAverage = 168.4f/DaysInMonthJanuary,
            PrecipitationDaysRatio = 18.5f/DaysInMonthJanuary,
            AverageWindSpeed = 11.9f,
            FogDaysRatio = 18f/DaysInMonthJanuary,
            DayLengthAverage = 9.4f,
          },
          new MonthlyClimateData() // February
          {
            TemperatureAverage = 4.9f,
            TemperatureHighAverage = 8.2f, TemperatureLowAverage = 1.6f,
            TemperatureHighest = 18.4f, TemperatureLowest = -16.1f,
            PrecipitationAverage = 104.6f/DaysInMonthFebruary,
            PrecipitationDaysRatio = 16.3f/DaysInMonthFebruary,
            AverageWindSpeed = 11.7f,
            FogDaysRatio = 12f/DaysInMonthFebruary,
            DayLengthAverage = 10.8f,
          },
          new MonthlyClimateData() // March
          {
            TemperatureAverage = 6.9f,
            TemperatureHighAverage = 10.3f, TemperatureLowAverage = 3.4f,
            TemperatureHighest = 19.4f, TemperatureLowest = -9.4f,
            PrecipitationAverage = 113.9f/DaysInMonthMarch,
            PrecipitationDaysRatio = 17f/DaysInMonthMarch,
            AverageWindSpeed = 13.2f,
            FogDaysRatio = 10f/DaysInMonthMarch,
            DayLengthAverage = 12.5f,
          },
          new MonthlyClimateData() // April
          {
            TemperatureAverage = 9.4f,
            TemperatureHighAverage = 13.2f, TemperatureLowAverage = 5.6f,
            TemperatureHighest = 25f, TemperatureLowest = -3.3f,
            PrecipitationAverage = 88.5f/DaysInMonthApril,
            PrecipitationDaysRatio = 13.9f/DaysInMonthApril,
            AverageWindSpeed = 12.5f,
            FogDaysRatio = 7f/DaysInMonthApril,
            DayLengthAverage = 14.4f,
          },
          new MonthlyClimateData() // May
          {
            TemperatureAverage = 12.8f,
            TemperatureHighAverage = 16.7f, TemperatureLowAverage = 8.8f,
            TemperatureHighest = 30.4f, TemperatureLowest = 0.6f,
            PrecipitationAverage = 65f/DaysInMonthMay,
            PrecipitationDaysRatio = 13f/DaysInMonthMay,
            AverageWindSpeed = 12.5f,
            FogDaysRatio = 6f/DaysInMonthMay,
            DayLengthAverage = 16f,
          },
          new MonthlyClimateData() // June
          {
            TemperatureAverage = 15.7f,
            TemperatureHighAverage = 19.6f, TemperatureLowAverage = 11.7f,
            TemperatureHighest = 30.6f, TemperatureLowest = 3.9f,
            PrecipitationAverage = 53.8f/DaysInMonthJune,
            PrecipitationDaysRatio = 11.2f/DaysInMonthJune,
            AverageWindSpeed = 12.4f,
            FogDaysRatio = 6f/DaysInMonthJune,
            DayLengthAverage = 16.9f,
          },
          new MonthlyClimateData() // July
          {
            TemperatureAverage = 18f,
            TemperatureHighAverage = 22.2f, TemperatureLowAverage = 13.7f,
            TemperatureHighest = 34.4f, TemperatureLowest = 6.7f,
            PrecipitationAverage = 35.6f/DaysInMonthJuly,
            PrecipitationDaysRatio = 6.9f/DaysInMonthJuly,
            AverageWindSpeed = 12.3f,
            FogDaysRatio = 4f/DaysInMonthJuly,
            DayLengthAverage = 16.4f,
          },
          new MonthlyClimateData() // August
          {
            TemperatureAverage = 18f,
            TemperatureHighAverage = 22.2f, TemperatureLowAverage = 13.8f,
            TemperatureHighest = 33.3f, TemperatureLowest = 6.1f,
            PrecipitationAverage = 36.7f/DaysInMonthAugust,
            PrecipitationDaysRatio = 6.8f/DaysInMonthAugust,
            AverageWindSpeed = 11.6f,
            FogDaysRatio = 7f/DaysInMonthAugust,
            DayLengthAverage = 14.9f,
          },
          new MonthlyClimateData() // September
          {
            TemperatureAverage = 14.9f,
            TemperatureHighAverage = 18.9f, TemperatureLowAverage = 10.8f,
            TemperatureHighest = 29.3f, TemperatureLowest = 0f,
            PrecipitationAverage = 50.9f/DaysInMonthSeptember,
            PrecipitationDaysRatio = 8.6f/DaysInMonthSeptember,
            AverageWindSpeed = 11.2f,
            FogDaysRatio = 11f/DaysInMonthSeptember,
            DayLengthAverage = 13.1f,
          },
          new MonthlyClimateData() // October
          {
            TemperatureAverage = 10.3f,
            TemperatureHighAverage = 13.5f, TemperatureLowAverage = 7f,
            TemperatureHighest = 23.7f, TemperatureLowest = -5.9f,
            PrecipitationAverage = 120.8f/DaysInMonthOctober,
            PrecipitationDaysRatio = 14.3f/DaysInMonthOctober,
            AverageWindSpeed = 11.7f,
            FogDaysRatio = 18f/DaysInMonthOctober,
            DayLengthAverage = 11.3f,
          },
          new MonthlyClimateData() // November
          {
            TemperatureAverage = 6.3f,
            TemperatureHighAverage = 9.2f, TemperatureLowAverage = 3.5f,
            TemperatureHighest = 18.4f, TemperatureLowest = -14.3f,
            PrecipitationAverage = 188.9f/DaysInMonthNovember,
            PrecipitationDaysRatio = 19.7f/DaysInMonthNovember,
            AverageWindSpeed = 12.9f,
            FogDaysRatio = 17f/DaysInMonthNovember,
            DayLengthAverage = 9.7f,
          },
          new MonthlyClimateData() // December
          {
            TemperatureAverage = 3.6f,
            TemperatureHighAverage = 6.3f, TemperatureLowAverage = 0.8f,
            TemperatureHighest = 14.9f, TemperatureLowest = -17.8f,
            PrecipitationAverage = 161.9f/DaysInMonthDecember,
            PrecipitationDaysRatio = 19.8f/DaysInMonthDecember,
            AverageWindSpeed = 12.2f,
            FogDaysRatio = 17f/DaysInMonthDecember,
            DayLengthAverage = 8.9f,
          },
        }
      }},

      #endregion Canada, Vancouver

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
            PrecipitationAverage = 0f/DaysInMonthJanuary,
            PrecipitationDaysRatio = 2f/DaysInMonthJanuary,
            AverageWindSpeed = 14,
            FogDaysRatio = 12f/DaysInMonthJanuary,
            DayLengthAverage = 10.2f,
          },
          new MonthlyClimateData() // February
          {
            TemperatureAverage = 0,
            TemperatureHighAverage = 3, TemperatureLowAverage = -5,
            TemperatureHighest = 17, TemperatureLowest = -15,
            PrecipitationAverage = 0f/DaysInMonthFebruary,
            PrecipitationDaysRatio = 3f/DaysInMonthFebruary,
            AverageWindSpeed = 19,
            FogDaysRatio = 10f/DaysInMonthFebruary,
            DayLengthAverage = 11.2f,
          },
          new MonthlyClimateData() // March
          {
            TemperatureAverage = 6,
            TemperatureHighAverage = 11, TemperatureLowAverage = 0,
            TemperatureHighest = 27, TemperatureLowest = -8,
            PrecipitationAverage = 0f/DaysInMonthMarch,
            PrecipitationDaysRatio = 4f/DaysInMonthMarch,
            AverageWindSpeed = 12,
            FogDaysRatio = 12f/DaysInMonthMarch,
            DayLengthAverage = 12.4f,
          },
          new MonthlyClimateData() // April
          {
            TemperatureAverage = 13,
            TemperatureHighAverage = 19, TemperatureLowAverage = 8,
            TemperatureHighest = 32, TemperatureLowest = -1,
            PrecipitationAverage = 10f/DaysInMonthApril,
            PrecipitationDaysRatio = 5f/DaysInMonthApril,
            AverageWindSpeed = 14,
            FogDaysRatio = 11f/DaysInMonthApril,
            DayLengthAverage = 13.8f,
          },
          new MonthlyClimateData() // May
          {
            TemperatureAverage = 20,
            TemperatureHighAverage = 25, TemperatureLowAverage = 13,
            TemperatureHighest = 37, TemperatureLowest = 3,
            PrecipitationAverage = 30f/DaysInMonthMay,
            PrecipitationDaysRatio = 6f/DaysInMonthMay,
            AverageWindSpeed = 12,
            FogDaysRatio = 14f/DaysInMonthMay,
            DayLengthAverage = 14.9f,
          },
          new MonthlyClimateData() // June
          {
            TemperatureAverage = 24,
            TemperatureHighAverage = 29, TemperatureLowAverage = 18,
            TemperatureHighest = 40, TemperatureLowest = 8,
            PrecipitationAverage = 70f/DaysInMonthJune,
            PrecipitationDaysRatio = 9f/DaysInMonthJune,
            AverageWindSpeed = 12,
            FogDaysRatio = 17f/DaysInMonthJune,
            DayLengthAverage = 15.5f,
          },
          new MonthlyClimateData() // July
          {
            TemperatureAverage = 26,
            TemperatureHighAverage = 30, TemperatureLowAverage = 22,
            TemperatureHighest = 40, TemperatureLowest = 17,
            PrecipitationAverage = 220f/DaysInMonthJuly,
            PrecipitationDaysRatio = 14f/DaysInMonthJuly,
            AverageWindSpeed = 8,
            FogDaysRatio = 26f/DaysInMonthJuly,
            DayLengthAverage = 15.2f,
          },
          new MonthlyClimateData() // August
          {
            TemperatureAverage = 25,
            TemperatureHighAverage = 29, TemperatureLowAverage = 20,
            TemperatureHighest = 41, TemperatureLowest = 12,
            PrecipitationAverage = 170f/DaysInMonthAugust,
            PrecipitationDaysRatio = 12f/DaysInMonthAugust,
            AverageWindSpeed = 8,
            FogDaysRatio = 25f/DaysInMonthAugust,
            DayLengthAverage = 14.2f,
          },
          new MonthlyClimateData() // September
          {
            TemperatureAverage = 20,
            TemperatureHighAverage = 25, TemperatureLowAverage = 15,
            TemperatureHighest = 33, TemperatureLowest = 2,
            PrecipitationAverage = 50f/DaysInMonthSeptember,
            PrecipitationDaysRatio = 7f/DaysInMonthSeptember,
            AverageWindSpeed = 8,
            FogDaysRatio = 22f/DaysInMonthSeptember,
            DayLengthAverage = 12.9f,
          },
          new MonthlyClimateData() // October
          {
            TemperatureAverage = 13,
            TemperatureHighAverage = 18, TemperatureLowAverage = 8,
            TemperatureHighest = 28, TemperatureLowest = -2,
            PrecipitationAverage = 10f/DaysInMonthOctober,
            PrecipitationDaysRatio = 6f/DaysInMonthOctober,
            AverageWindSpeed = 9,
            FogDaysRatio = 21f/DaysInMonthOctober,
            DayLengthAverage = 11.6f,
          },
          new MonthlyClimateData() // November
          {
            TemperatureAverage = 5,
            TemperatureHighAverage = 9, TemperatureLowAverage = 0,
            TemperatureHighest = 23, TemperatureLowest = -12,
            PrecipitationAverage = 10f/DaysInMonthNovember,
            PrecipitationDaysRatio = 5f/DaysInMonthNovember,
            AverageWindSpeed = 19,
            FogDaysRatio = 19f/DaysInMonthNovember,
            DayLengthAverage = 10.5f,
          },
          new MonthlyClimateData() // December
          {
            TemperatureAverage = -1,
            TemperatureHighAverage = 2, TemperatureLowAverage = -5,
            TemperatureHighest = 18, TemperatureLowest = -14,
            PrecipitationAverage = 0f/DaysInMonthDecember,
            PrecipitationDaysRatio = 2f/DaysInMonthDecember,
            AverageWindSpeed = 14,
            FogDaysRatio = 16f/DaysInMonthDecember,
            DayLengthAverage = 9.9f,
          },
        }
      }},

      #endregion China, Beijing

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
            PrecipitationAverage = 0f/DaysInMonthJanuary,
            PrecipitationDaysRatio = 5f/DaysInMonthJanuary,
            AverageWindSpeed = 14,
            FogDaysRatio = 11f/DaysInMonthJanuary,
            DayLengthAverage = 10.9f,
          },
          new MonthlyClimateData() // February
          {
            TemperatureAverage = 15,
            TemperatureHighAverage = 20, TemperatureLowAverage = 10,
            TemperatureHighest = 33, TemperatureLowest = 0,
            PrecipitationAverage = 0f/DaysInMonthFebruary,
            PrecipitationDaysRatio = 3f/DaysInMonthFebruary,
            AverageWindSpeed = 16,
            FogDaysRatio = 7f/DaysInMonthFebruary,
            DayLengthAverage = 11.6f,
          },
          new MonthlyClimateData() // March
          {
            TemperatureAverage = 17,
            TemperatureHighAverage = 22, TemperatureLowAverage = 12,
            TemperatureHighest = 37, TemperatureLowest = 2,
            PrecipitationAverage = 0f/DaysInMonthMarch,
            PrecipitationDaysRatio = 2f/DaysInMonthMarch,
            AverageWindSpeed = 12,
            FogDaysRatio = 9f/DaysInMonthMarch,
            DayLengthAverage = 12.4f,
          },
          new MonthlyClimateData() // April
          {
            TemperatureAverage = 21,
            TemperatureHighAverage = 27, TemperatureLowAverage = 15,
            TemperatureHighest = 42, TemperatureLowest = 7,
            PrecipitationAverage = 0f/DaysInMonthApril,
            PrecipitationDaysRatio = 1f/DaysInMonthApril,
            AverageWindSpeed = 14,
            FogDaysRatio = 7f/DaysInMonthApril,
            DayLengthAverage = 13.3f,
          },
          new MonthlyClimateData() // May
          {
            TemperatureAverage = 25,
            TemperatureHighAverage = 31, TemperatureLowAverage = 17,
            TemperatureHighest = 43, TemperatureLowest = 12,
            PrecipitationAverage = 0f/DaysInMonthMay,
            PrecipitationDaysRatio = 1f/DaysInMonthMay,
            AverageWindSpeed = 14,
            FogDaysRatio = 8f/DaysInMonthMay,
            DayLengthAverage = 14.1f,
          },
          new MonthlyClimateData() // June
          {
            TemperatureAverage = 27,
            TemperatureHighAverage = 33, TemperatureLowAverage = 21,
            TemperatureHighest = 45, TemperatureLowest = 15,
            PrecipitationAverage = 0f/DaysInMonthJune,
            PrecipitationDaysRatio = 0f/DaysInMonthJune,
            AverageWindSpeed = 14,
            FogDaysRatio = 11f/DaysInMonthJune,
            DayLengthAverage = 14.5f,
          },
          new MonthlyClimateData() // July
          {
            TemperatureAverage = 28,
            TemperatureHighAverage = 33, TemperatureLowAverage = 22,
            TemperatureHighest = 42, TemperatureLowest = 17,
            PrecipitationAverage = 0f/DaysInMonthJuly,
            PrecipitationDaysRatio = 0f/DaysInMonthJuly,
            AverageWindSpeed = 12,
            FogDaysRatio = 20f/DaysInMonthJuly,
            DayLengthAverage = 14.3f,
          },
          new MonthlyClimateData() // August
          {
            TemperatureAverage = 27,
            TemperatureHighAverage = 33, TemperatureLowAverage = 22,
            TemperatureHighest = 41, TemperatureLowest = 18,
            PrecipitationAverage = 0f/DaysInMonthAugust,
            PrecipitationDaysRatio = 0f/DaysInMonthAugust,
            AverageWindSpeed = 12,
            FogDaysRatio = 23f/DaysInMonthAugust,
            DayLengthAverage = 13.6f,
          },
          new MonthlyClimateData() // September
          {
            TemperatureAverage = 26,
            TemperatureHighAverage = 32, TemperatureLowAverage = 20,
            TemperatureHighest = 43, TemperatureLowest = 16,
            PrecipitationAverage = 0f/DaysInMonthSeptember,
            PrecipitationDaysRatio = 0f/DaysInMonthSeptember,
            AverageWindSpeed = 12,
            FogDaysRatio = 17f/DaysInMonthSeptember,
            DayLengthAverage = 12.7f,
          },
          new MonthlyClimateData() // October
          {
            TemperatureAverage = 23,
            TemperatureHighAverage = 29, TemperatureLowAverage = 18,
            TemperatureHighest = 38, TemperatureLowest = 0,
            PrecipitationAverage = 0f/DaysInMonthOctober,
            PrecipitationDaysRatio = 1f/DaysInMonthOctober,
            AverageWindSpeed = 12,
            FogDaysRatio = 15f/DaysInMonthOctober,
            DayLengthAverage = 11.8f,
          },
          new MonthlyClimateData() // November
          {
            TemperatureAverage = 19,
            TemperatureHighAverage = 23, TemperatureLowAverage = 14,
            TemperatureHighest = 35, TemperatureLowest = 2,
            PrecipitationAverage = 0f/DaysInMonthNovember,
            PrecipitationDaysRatio = 1f/DaysInMonthNovember,
            AverageWindSpeed = 9,
            FogDaysRatio = 11f/DaysInMonthNovember,
            DayLengthAverage = 11.1f,
          },
          new MonthlyClimateData() // December
          {
            TemperatureAverage = 15,
            TemperatureHighAverage = 19, TemperatureLowAverage = 10,
            TemperatureHighest = 28, TemperatureLowest = 0,
            PrecipitationAverage = 0f/DaysInMonthDecember,
            PrecipitationDaysRatio = 3f/DaysInMonthDecember,
            AverageWindSpeed = 12,
            FogDaysRatio = 12f/DaysInMonthDecember,
            DayLengthAverage = 10.7f,
          },
        }
      }},

      #endregion Egypt, Cairo

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
            PrecipitationAverage = 70f/DaysInMonthJanuary,
            PrecipitationDaysRatio = 0.76f,
            AverageWindSpeed = 12.4f,
            FogDaysRatio = 14f/DaysInMonthJanuary,
            DayLengthAverage = 9.2f,
          },
          new MonthlyClimateData() // February
          {
            TemperatureAverage = 4.5f,
            TemperatureHighAverage = 7.9f, TemperatureLowAverage = 1,
            TemperatureHighest = 17, TemperatureLowest = -13,
            PrecipitationAverage = 50f/DaysInMonthFebruary,
            PrecipitationDaysRatio = 0.63f,
            AverageWindSpeed = 13,
            FogDaysRatio = 13f/DaysInMonthFebruary,
            DayLengthAverage = 10.6f,
          },
          new MonthlyClimateData() // March
          {
            TemperatureAverage = 6.9f,
            TemperatureHighAverage = 10.9f, TemperatureLowAverage = 2.8f,
            TemperatureHighest = 20, TemperatureLowest = -7,
            PrecipitationAverage = 60f/DaysInMonthMarch,
            PrecipitationDaysRatio = 0.7f,
            AverageWindSpeed = 14.4f,
            FogDaysRatio = 16f/DaysInMonthMarch,
            DayLengthAverage = 12.5f,
          },
          new MonthlyClimateData() // April
          {
            TemperatureAverage = 8.7f,
            TemperatureHighAverage = 13.7f, TemperatureLowAverage = 3.7f,
            TemperatureHighest = 22, TemperatureLowest = -5,
            PrecipitationAverage = 50f/DaysInMonthApril,
            PrecipitationDaysRatio = 0.66f,
            AverageWindSpeed = 10.4f,
            FogDaysRatio = 14f/DaysInMonthApril,
            DayLengthAverage = 14.5f,
          },
          new MonthlyClimateData() // May
          {
            TemperatureAverage = 12.1f,
            TemperatureHighAverage = 17.4f, TemperatureLowAverage = 6.8f,
            TemperatureHighest = 28, TemperatureLowest = -3,
            PrecipitationAverage = 50f/DaysInMonthMay,
            PrecipitationDaysRatio = 0.6f,
            AverageWindSpeed = 10.6f,
            FogDaysRatio = 18f/DaysInMonthMay,
            DayLengthAverage = 16.3f,
          },
          new MonthlyClimateData() // June
          {
            TemperatureAverage = 15.1f,
            TemperatureHighAverage = 20.5f, TemperatureLowAverage = 9.6f,
            TemperatureHighest = 32, TemperatureLowest = 1,
            PrecipitationAverage = 50f/DaysInMonthJune,
            PrecipitationDaysRatio = 0.6f,
            AverageWindSpeed = 9.3f,
            FogDaysRatio = 19f/DaysInMonthJune,
            DayLengthAverage = 17.3f,
          },
          new MonthlyClimateData() // July
          {
            TemperatureAverage = 17.3f,
            TemperatureHighAverage = 22.9f, TemperatureLowAverage = 11.7f,
            TemperatureHighest = 33, TemperatureLowest = 3,
            PrecipitationAverage = 40f/DaysInMonthJuly,
            PrecipitationDaysRatio = 0.56f,
            AverageWindSpeed = 8.7f,
            FogDaysRatio = 17f/DaysInMonthJuly,
            DayLengthAverage = 16.7f,
          },
          new MonthlyClimateData() // August
          {
            TemperatureAverage = 17,
            TemperatureHighAverage = 22.6f, TemperatureLowAverage = 11.4f,
            TemperatureHighest = 35, TemperatureLowest = 2,
            PrecipitationAverage = 50f/DaysInMonthAugust,
            PrecipitationDaysRatio = 0.56f,
            AverageWindSpeed = 11.1f,
            FogDaysRatio = 22f/DaysInMonthAugust,
            DayLengthAverage = 15.1f,
          },
          new MonthlyClimateData() // September
          {
            TemperatureAverage = 14.3f,
            TemperatureHighAverage = 19.2f, TemperatureLowAverage = 9.3f,
            TemperatureHighest = 27, TemperatureLowest = 1,
            PrecipitationAverage = 60f/DaysInMonthSeptember,
            PrecipitationDaysRatio = 0.6f,
            AverageWindSpeed = 8.7f,
            FogDaysRatio = 20f/DaysInMonthSeptember,
            DayLengthAverage = 13.2f,
          },
          new MonthlyClimateData() // October
          {
            TemperatureAverage = 10.9f,
            TemperatureHighAverage = 15.2f, TemperatureLowAverage = 6.6f,
            TemperatureHighest = 25, TemperatureLowest = -4,
            PrecipitationAverage = 70f/DaysInMonthOctober,
            PrecipitationDaysRatio = 0.70f,
            AverageWindSpeed = 9.8f,
            FogDaysRatio = 21f/DaysInMonthOctober,
            DayLengthAverage = 11.2f,
          },
          new MonthlyClimateData() // November
          {
            TemperatureAverage = 7.2f,
            TemperatureHighAverage = 10.7f, TemperatureLowAverage = 3.6f,
            TemperatureHighest = 17, TemperatureLowest = -7,
            PrecipitationAverage = 70f/DaysInMonthNovember,
            PrecipitationDaysRatio = 0.73f,
            AverageWindSpeed = 9.1f,
            FogDaysRatio = 17f/DaysInMonthNovember,
            DayLengthAverage = 9.5f,
          },
          new MonthlyClimateData() // December
          {
            TemperatureAverage = 4.7f,
            TemperatureHighAverage = 7.8f, TemperatureLowAverage = 1.6f,
            TemperatureHighest = 15, TemperatureLowest = -11,
            PrecipitationAverage = 70f/DaysInMonthDecember,
            PrecipitationDaysRatio = 0.73f,
            AverageWindSpeed = 10.9f,
            FogDaysRatio = 16f/DaysInMonthDecember,
            DayLengthAverage = 8.6f,
          },
        }
      }},

      #endregion England, London

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
            PrecipitationAverage = 40f/DaysInMonthJanuary,
            PrecipitationDaysRatio = 16f/DaysInMonthJanuary,
            AverageWindSpeed = 12,
            FogDaysRatio = 15f/DaysInMonthJanuary,
            DayLengthAverage = 7.7f,
          },
          new MonthlyClimateData() // February
          {
            TemperatureAverage = -6,
            TemperatureHighAverage = -2, TemperatureLowAverage = -9,
            TemperatureHighest = 10, TemperatureLowest = -30,
            PrecipitationAverage = 30f/DaysInMonthFebruary,
            PrecipitationDaysRatio = 11f/DaysInMonthFebruary,
            AverageWindSpeed = 12,
            FogDaysRatio = 16f/DaysInMonthFebruary,
            DayLengthAverage = 9.9f,
          },
          new MonthlyClimateData() // March
          {
            TemperatureAverage = -2,
            TemperatureHighAverage = 1, TemperatureLowAverage = -5,
            TemperatureHighest = 12, TemperatureLowest = -26,
            PrecipitationAverage = 30f/DaysInMonthMarch,
            PrecipitationDaysRatio = 12f/DaysInMonthMarch,
            AverageWindSpeed = 19,
            FogDaysRatio = 18f/DaysInMonthMarch,
            DayLengthAverage = 12.6f,
          },
          new MonthlyClimateData() // April
          {
            TemperatureAverage = 3,
            TemperatureHighAverage = 7, TemperatureLowAverage = 0,
            TemperatureHighest = 21, TemperatureLowest = -11,
            PrecipitationAverage = 30f/DaysInMonthApril,
            PrecipitationDaysRatio = 13f/DaysInMonthApril,
            AverageWindSpeed = 16,
            FogDaysRatio = 14f/DaysInMonthApril,
            DayLengthAverage = 15.5f,
          },
          new MonthlyClimateData() // May
          {
            TemperatureAverage = 10,
            TemperatureHighAverage = 15, TemperatureLowAverage = 5,
            TemperatureHighest = 27, TemperatureLowest = -3,
            PrecipitationAverage = 40f/DaysInMonthMay,
            PrecipitationDaysRatio = 14f/DaysInMonthMay,
            AverageWindSpeed = 16,
            FogDaysRatio = 13f/DaysInMonthMay,
            DayLengthAverage = 18.5f,
          },
          new MonthlyClimateData() // June
          {
            TemperatureAverage = 13,
            TemperatureHighAverage = 18, TemperatureLowAverage = 9,
            TemperatureHighest = 30, TemperatureLowest = -1,
            PrecipitationAverage = 40f/DaysInMonthJune,
            PrecipitationDaysRatio = 17f/DaysInMonthJune,
            AverageWindSpeed = 16,
            FogDaysRatio = 14f/DaysInMonthJune,
            DayLengthAverage = 20.7f,
          },
          new MonthlyClimateData() // July
          {
            TemperatureAverage = 16,
            TemperatureHighAverage = 21, TemperatureLowAverage = 11,
            TemperatureHighest = 31, TemperatureLowest = 4,
            PrecipitationAverage = 60f/DaysInMonthJuly,
            PrecipitationDaysRatio = 15f/DaysInMonthJuly,
            AverageWindSpeed = 14,
            FogDaysRatio = 18f/DaysInMonthJuly,
            DayLengthAverage = 19.3f,
          },
          new MonthlyClimateData() // August
          {
            TemperatureAverage = 15,
            TemperatureHighAverage = 18, TemperatureLowAverage = 10,
            TemperatureHighest = 31, TemperatureLowest = 4,
            PrecipitationAverage = 70f/DaysInMonthAugust,
            PrecipitationDaysRatio = 17f/DaysInMonthAugust,
            AverageWindSpeed = 16,
            FogDaysRatio = 19f/DaysInMonthAugust,
            DayLengthAverage = 16.4f,
          },
          new MonthlyClimateData() // September
          {
            TemperatureAverage = 10,
            TemperatureHighAverage = 13, TemperatureLowAverage = 6,
            TemperatureHighest = 25, TemperatureLowest = -7,
            PrecipitationAverage = 60f/DaysInMonthSeptember,
            PrecipitationDaysRatio = 15f/DaysInMonthSeptember,
            AverageWindSpeed = 9,
            FogDaysRatio = 17f/DaysInMonthSeptember,
            DayLengthAverage = 13.5f,
          },
          new MonthlyClimateData() // October
          {
            TemperatureAverage = 5,
            TemperatureHighAverage = 7, TemperatureLowAverage = 2,
            TemperatureHighest = 17, TemperatureLowest = -12,
            PrecipitationAverage = 60f/DaysInMonthOctober,
            PrecipitationDaysRatio = 20f/DaysInMonthOctober,
            AverageWindSpeed = 9,
            FogDaysRatio = 16f/DaysInMonthOctober,
            DayLengthAverage = 10.8f,
          },
          new MonthlyClimateData() // November
          {
            TemperatureAverage = 0,
            TemperatureHighAverage = 2, TemperatureLowAverage = -2,
            TemperatureHighest = 10, TemperatureLowest = -20,
            PrecipitationAverage = 60f/DaysInMonthNovember,
            PrecipitationDaysRatio = 17f/DaysInMonthNovember,
            AverageWindSpeed = 19,
            FogDaysRatio = 15f/DaysInMonthNovember,
            DayLengthAverage = 8.3f,
          },
          new MonthlyClimateData() // December
          {
            TemperatureAverage = -3,
            TemperatureHighAverage = -1, TemperatureLowAverage = -6,
            TemperatureHighest = 8, TemperatureLowest = -32,
            PrecipitationAverage = 50f/DaysInMonthDecember,
            PrecipitationDaysRatio = 16f/DaysInMonthDecember,
            AverageWindSpeed = 20,
            FogDaysRatio = 13f/DaysInMonthDecember,
            DayLengthAverage = 6.9f,
          },
        }
      }},

      #endregion Finland, Helsinki

      #region Germany, Frankfurt

      // http://www.weatherbase.com/weather/weatherall.php3?s=73601&cityname=Frankfurt%2C+Hesse%2C+Germany&units=
      new ClimatePreset() { PresetName = "Germany, Frankfurt", PresetCode = "PRESET_GERMANY_FRANKFURT", ClimateProperties = new ClimateControlProperties()
      {
        SnowFallTemperature = 2, SnowMeltTemperature = 10, SolarDayLength = 24f,
        ClimateData = new MonthlyClimateData[]
        {
          new MonthlyClimateData() // January
          {
            TemperatureAverage = 1,
            TemperatureHighAverage = 3, TemperatureLowAverage = -1,
            TemperatureHighest = 13, TemperatureLowest = -20,
            PrecipitationAverage = 40f/DaysInMonthJanuary,
            PrecipitationDaysRatio = 5f/DaysInMonthJanuary,
            AverageWindSpeed = 14,
            FogDaysRatio = 19f/DaysInMonthJanuary,
            DayLengthAverage = 9.3f,
          },
          new MonthlyClimateData() // February
          {
            TemperatureAverage = 2,
            TemperatureHighAverage = 5, TemperatureLowAverage = -1,
            TemperatureHighest = 17, TemperatureLowest = -18,
            PrecipitationAverage = 40f/DaysInMonthFebruary,
            PrecipitationDaysRatio = 4f/DaysInMonthFebruary,
            AverageWindSpeed = 12,
            FogDaysRatio = 18f/DaysInMonthFebruary,
            DayLengthAverage = 10.7f,
          },
          new MonthlyClimateData() // March
          {
            TemperatureAverage = 6,
            TemperatureHighAverage = 10, TemperatureLowAverage = 2,
            TemperatureHighest = 23, TemperatureLowest = -12,
            PrecipitationAverage = 50f/DaysInMonthMarch,
            PrecipitationDaysRatio = 2f/DaysInMonthMarch,
            AverageWindSpeed = 14,
            FogDaysRatio = 16f/DaysInMonthMarch,
            DayLengthAverage = 12.5f,
          },
          new MonthlyClimateData() // April
          {
            TemperatureAverage = 8,
            TemperatureHighAverage = 13, TemperatureLowAverage = 3,
            TemperatureHighest = 25, TemperatureLowest = -6,
            PrecipitationAverage = 50f/DaysInMonthApril,
            PrecipitationDaysRatio = 5f/DaysInMonthApril,
            AverageWindSpeed = 14,
            FogDaysRatio = 12f/DaysInMonthApril,
            DayLengthAverage = 14.4f,
          },
          new MonthlyClimateData() // May
          {
            TemperatureAverage = 13,
            TemperatureHighAverage = 18, TemperatureLowAverage = 8,
            TemperatureHighest = 31, TemperatureLowest = -2,
            PrecipitationAverage = 60f/DaysInMonthMay,
            PrecipitationDaysRatio = 5f/DaysInMonthMay,
            AverageWindSpeed = 12,
            FogDaysRatio = 14f/DaysInMonthMay,
            DayLengthAverage = 16.1f,
          },
          new MonthlyClimateData() // June
          {
            TemperatureAverage = 16,
            TemperatureHighAverage = 21, TemperatureLowAverage = 11,
            TemperatureHighest = 33, TemperatureLowest = 1,
            PrecipitationAverage = 70f/DaysInMonthJune,
            PrecipitationDaysRatio = 5f/DaysInMonthJune,
            AverageWindSpeed = 14,
            FogDaysRatio = 13f/DaysInMonthJune,
            DayLengthAverage = 17f,
          },
          new MonthlyClimateData() // July
          {
            TemperatureAverage = 18,
            TemperatureHighAverage = 23, TemperatureLowAverage = 13,
            TemperatureHighest = 36, TemperatureLowest = 3,
            PrecipitationAverage = 60f/DaysInMonthJuly,
            PrecipitationDaysRatio = 9f/DaysInMonthJuly,
            AverageWindSpeed = 14,
            FogDaysRatio = 12f/DaysInMonthJuly,
            DayLengthAverage = 16.5f,
          },
          new MonthlyClimateData() // August
          {
            TemperatureAverage = 18,
            TemperatureHighAverage = 23, TemperatureLowAverage = 13,
            TemperatureHighest = 36, TemperatureLowest = 3,
            PrecipitationAverage = 70f/DaysInMonthAugust,
            PrecipitationDaysRatio = 5f/DaysInMonthAugust,
            AverageWindSpeed = 12,
            FogDaysRatio = 15f/DaysInMonthAugust,
            DayLengthAverage = 15f,
          },
          new MonthlyClimateData() // September
          {
            TemperatureAverage = 15,
            TemperatureHighAverage = 20, TemperatureLowAverage = 10,
            TemperatureHighest = 32, TemperatureLowest = 0,
            PrecipitationAverage = 50f/DaysInMonthSeptember,
            PrecipitationDaysRatio = 5f/DaysInMonthSeptember,
            AverageWindSpeed = 12,
            FogDaysRatio = 18f/DaysInMonthSeptember,
            DayLengthAverage = 13.1f,
          },
          new MonthlyClimateData() // October
          {
            TemperatureAverage = 10,
            TemperatureHighAverage = 13, TemperatureLowAverage = 6,
            TemperatureHighest = 27, TemperatureLowest = -3,
            PrecipitationAverage = 50f/DaysInMonthOctober,
            PrecipitationDaysRatio = 4f/DaysInMonthOctober,
            AverageWindSpeed = 12,
            FogDaysRatio = 21f/DaysInMonthOctober,
            DayLengthAverage = 11.2f,
          },
          new MonthlyClimateData() // November
          {
            TemperatureAverage = 5,
            TemperatureHighAverage = 7, TemperatureLowAverage = 2,
            TemperatureHighest = 17, TemperatureLowest = -8,
            PrecipitationAverage = 50f/DaysInMonthNovember,
            PrecipitationDaysRatio = 3f/DaysInMonthNovember,
            AverageWindSpeed = 14,
            FogDaysRatio = 19f/DaysInMonthNovember,
            DayLengthAverage = 9.6f,
          },
          new MonthlyClimateData() // December
          {
            TemperatureAverage = 2,
            TemperatureHighAverage = 4, TemperatureLowAverage = 0,
            TemperatureHighest = 16, TemperatureLowest = -16,
            PrecipitationAverage = 50f/DaysInMonthDecember,
            PrecipitationDaysRatio = 6f/DaysInMonthDecember,
            AverageWindSpeed = 14,
            FogDaysRatio = 20f/DaysInMonthDecember,
            DayLengthAverage = 8.8f,
          },
        }
      }},

      #endregion Germany, Frankfurt

      #region Germany, Hamburg

      // http://www.weatherbase.com/weather/weatherall.php3?s=74101&cityname=Hamburg%2C+Hamburg%2C+Germany&units=
      new ClimatePreset() { PresetName = "Germany, Hamburg", PresetCode = "PRESET_GERMANY_HAMBURG", ClimateProperties = new ClimateControlProperties()
      {
        SnowFallTemperature = 2, SnowMeltTemperature = 10, SolarDayLength = 24f,
        ClimateData = new MonthlyClimateData[]
        {
          new MonthlyClimateData() // January
          {
            TemperatureAverage = 1,
            TemperatureHighAverage = 3, TemperatureLowAverage = -1,
            TemperatureHighest = 12, TemperatureLowest = -18,
            PrecipitationAverage = 60f/DaysInMonthJanuary,
            PrecipitationDaysRatio = 12f/DaysInMonthJanuary,
            AverageWindSpeed = 19,
            FogDaysRatio = 22f/DaysInMonthJanuary,
            DayLengthAverage = 8.8f,
          },
          new MonthlyClimateData() // February
          {
            TemperatureAverage = 1,
            TemperatureHighAverage = 3, TemperatureLowAverage = -1,
            TemperatureHighest = 16, TemperatureLowest = -18,
            PrecipitationAverage = 40f/DaysInMonthFebruary,
            PrecipitationDaysRatio = 9f/DaysInMonthFebruary,
            AverageWindSpeed = 16,
            FogDaysRatio = 19f/DaysInMonthFebruary,
            DayLengthAverage = 10.5f,
          },
          new MonthlyClimateData() // March
          {
            TemperatureAverage = 4,
            TemperatureHighAverage = 7, TemperatureLowAverage = 1,
            TemperatureHighest = 22, TemperatureLowest = -12,
            PrecipitationAverage = 50f/DaysInMonthMarch,
            PrecipitationDaysRatio = 11f/DaysInMonthMarch,
            AverageWindSpeed = 17,
            FogDaysRatio = 20f/DaysInMonthMarch,
            DayLengthAverage = 12.5f,
          },
          new MonthlyClimateData() // April
          {
            TemperatureAverage = 7,
            TemperatureHighAverage = 11, TemperatureLowAverage = 2,
            TemperatureHighest = 25, TemperatureLowest = -6,
            PrecipitationAverage = 40f/DaysInMonthApril,
            PrecipitationDaysRatio = 10f/DaysInMonthApril,
            AverageWindSpeed = 16,
            FogDaysRatio = 18f/DaysInMonthApril,
            DayLengthAverage = 14.7f,
          },
          new MonthlyClimateData() // May
          {
            TemperatureAverage = 12,
            TemperatureHighAverage = 16, TemperatureLowAverage = 7,
            TemperatureHighest = 28, TemperatureLowest = -1,
            PrecipitationAverage = 50f/DaysInMonthMay,
            PrecipitationDaysRatio = 10f/DaysInMonthMay,
            AverageWindSpeed = 14,
            FogDaysRatio = 19f/DaysInMonthMay,
            DayLengthAverage = 16.7f,
          },
          new MonthlyClimateData() // June
          {
            TemperatureAverage = 15,
            TemperatureHighAverage = 19, TemperatureLowAverage = 10,
            TemperatureHighest = 32, TemperatureLowest = 2,
            PrecipitationAverage = 70f/DaysInMonthJune,
            PrecipitationDaysRatio = 11f/DaysInMonthJune,
            AverageWindSpeed = 14,
            FogDaysRatio = 18f/DaysInMonthJune,
            DayLengthAverage = 17.9f,
          },
          new MonthlyClimateData() // July
          {
            TemperatureAverage = 17,
            TemperatureHighAverage = 21, TemperatureLowAverage = 12,
            TemperatureHighest = 34, TemperatureLowest = 6,
            PrecipitationAverage = 80f/DaysInMonthJuly,
            PrecipitationDaysRatio = 12f/DaysInMonthJuly,
            AverageWindSpeed = 14,
            FogDaysRatio = 19f/DaysInMonthJuly,
            DayLengthAverage = 17.2f,
          },
          new MonthlyClimateData() // August
          {
            TemperatureAverage = 17,
            TemperatureHighAverage = 21, TemperatureLowAverage = 12,
            TemperatureHighest = 37, TemperatureLowest = 2,
            PrecipitationAverage = 70f/DaysInMonthAugust,
            PrecipitationDaysRatio = 11f/DaysInMonthAugust,
            AverageWindSpeed = 12,
            FogDaysRatio = 21f/DaysInMonthAugust,
            DayLengthAverage = 15.4f,
          },
          new MonthlyClimateData() // September
          {
            TemperatureAverage = 13,
            TemperatureHighAverage = 17, TemperatureLowAverage = 9,
            TemperatureHighest = 29, TemperatureLowest = 0,
            PrecipitationAverage = 60f/DaysInMonthSeptember,
            PrecipitationDaysRatio = 11f/DaysInMonthSeptember,
            AverageWindSpeed = 14,
            FogDaysRatio = 21f/DaysInMonthSeptember,
            DayLengthAverage = 13.2f,
          },
          new MonthlyClimateData() // October
          {
            TemperatureAverage = 9,
            TemperatureHighAverage = 12, TemperatureLowAverage = 6,
            TemperatureHighest = 23, TemperatureLowest = -3,
            PrecipitationAverage = 60f/DaysInMonthOctober,
            PrecipitationDaysRatio = 10f/DaysInMonthOctober,
            AverageWindSpeed = 17,
            FogDaysRatio = 23f/DaysInMonthOctober,
            DayLengthAverage = 11.1f,
          },
          new MonthlyClimateData() // November
          {
            TemperatureAverage = 5,
            TemperatureHighAverage = 7, TemperatureLowAverage = 2,
            TemperatureHighest = 15, TemperatureLowest = -11,
            PrecipitationAverage = 60f/DaysInMonthNovember,
            PrecipitationDaysRatio = 12f/DaysInMonthNovember,
            AverageWindSpeed = 19,
            FogDaysRatio = 20f/DaysInMonthNovember,
            DayLengthAverage = 9.2f,
          },
          new MonthlyClimateData() // December
          {
            TemperatureAverage = 2,
            TemperatureHighAverage = 4, TemperatureLowAverage = 0,
            TemperatureHighest = 16, TemperatureLowest = 0,
            PrecipitationAverage = 70f/DaysInMonthDecember,
            PrecipitationDaysRatio = 12f/DaysInMonthDecember,
            AverageWindSpeed = 17,
            FogDaysRatio = 21f/DaysInMonthDecember,
            DayLengthAverage = 8.3f,
          },
        }
      }},

      #endregion Germany, Hamburg

      #region Greenland, Kraulshavn

      // http://www.weatherbase.com/weather/weatherall.php3?s=80240&cityname=Kraulshavn%2C+Qaasuitsup%2C+Greenland&units=
      new ClimatePreset() { PresetName = "Greenland, Kraulshavn", PresetCode = "PRESET_GREENLAND_KRAULSHAVN", ClimateProperties = new ClimateControlProperties()
      {
        SnowFallTemperature = 1f, SnowMeltTemperature = 6f, SolarDayLength = 24.00f,
        ClimateData = new MonthlyClimateData[]
        {
          new MonthlyClimateData() // January
          {
            TemperatureAverage = -21,
            TemperatureHighAverage = -20, TemperatureLowAverage = -24,
            TemperatureHighest = 1, TemperatureLowest = -38,
            PrecipitationAverage = float.NaN,
            PrecipitationDaysRatio = 0f/DaysInMonthJanuary,
            AverageWindSpeed = 19,
            FogDaysRatio = float.NaN,
            DayLengthAverage = 0,
          },
          new MonthlyClimateData() // February
          {
            TemperatureAverage = -23,
            TemperatureHighAverage = -21, TemperatureLowAverage = -26,
            TemperatureHighest = 0, TemperatureLowest = -39,
            PrecipitationAverage = float.NaN,
            PrecipitationDaysRatio = 0f/DaysInMonthFebruary,
            AverageWindSpeed = 19,
            FogDaysRatio = float.NaN,
            DayLengthAverage = 7.1f,
          },
          new MonthlyClimateData() // March
          {
            TemperatureAverage = -23,
            TemperatureHighAverage = -22, TemperatureLowAverage = -26,
            TemperatureHighest = -1, TemperatureLowest = -41,
            PrecipitationAverage = float.NaN,
            PrecipitationDaysRatio = 31f/DaysInMonthMarch,
            AverageWindSpeed = 19,
            FogDaysRatio = float.NaN,
            DayLengthAverage = 13.1f,
          },
          new MonthlyClimateData() // April
          {
            TemperatureAverage = 0,
            TemperatureHighAverage = -15, TemperatureLowAverage = -20,
            TemperatureHighest = 2, TemperatureLowest = -35,
            PrecipitationAverage = float.NaN,
            PrecipitationDaysRatio = 0f/DaysInMonthApril,
            AverageWindSpeed = 20,
            FogDaysRatio = float.NaN,
            DayLengthAverage = 22,
          },
          new MonthlyClimateData() // May
          {
            TemperatureAverage = -7,
            TemperatureHighAverage = -5, TemperatureLowAverage = -9,
            TemperatureHighest = 7, TemperatureLowest = -28,
            PrecipitationAverage = float.NaN,
            PrecipitationDaysRatio = 0f/DaysInMonthMay,
            AverageWindSpeed = 22,
            FogDaysRatio = float.NaN,
            DayLengthAverage = 24,
          },
          new MonthlyClimateData() // June
          {
            TemperatureAverage = 0,
            TemperatureHighAverage = 1, TemperatureLowAverage = -1,
            TemperatureHighest = 13, TemperatureLowest = -8,
            PrecipitationAverage = float.NaN,
            PrecipitationDaysRatio = 0f/DaysInMonthJune,
            AverageWindSpeed = 19,
            FogDaysRatio = float.NaN,
            DayLengthAverage = 24,
          },
          new MonthlyClimateData() // July
          {
            TemperatureAverage = 3,
            TemperatureHighAverage = 4, TemperatureLowAverage = 1,
            TemperatureHighest = 13, TemperatureLowest = -8,
            PrecipitationAverage = float.NaN,
            PrecipitationDaysRatio = 0f/DaysInMonthJuly,
            AverageWindSpeed = 19,
            FogDaysRatio = float.NaN,
            DayLengthAverage = 24,
          },
          new MonthlyClimateData() // August
          {
            TemperatureAverage = 3,
            TemperatureHighAverage = 3, TemperatureLowAverage = 2,
            TemperatureHighest = 11, TemperatureLowest = -1,
            PrecipitationAverage = float.NaN,
            PrecipitationDaysRatio = 16f/DaysInMonthAugust,
            AverageWindSpeed = 20,
            FogDaysRatio = float.NaN,
            DayLengthAverage = 22.5f,
          },
          new MonthlyClimateData() // September
          {
            TemperatureAverage = 0,
            TemperatureHighAverage = 1, TemperatureLowAverage = 0,
            TemperatureHighest = 7, TemperatureLowest = -5,
            PrecipitationAverage = float.NaN,
            PrecipitationDaysRatio = 0f/DaysInMonthSeptember,
            AverageWindSpeed = 19,
            FogDaysRatio = float.NaN,
            DayLengthAverage = 15,
          },
          new MonthlyClimateData() // October
          {
            TemperatureAverage = -4,
            TemperatureHighAverage = -3, TemperatureLowAverage = -5,
            TemperatureHighest = 7, TemperatureLowest = -17,
            PrecipitationAverage = float.NaN,
            PrecipitationDaysRatio = 0f/DaysInMonthOctober,
            AverageWindSpeed = 25,
            FogDaysRatio = float.NaN,
            DayLengthAverage = 9.2f,
          },
          new MonthlyClimateData() // November
          {
            TemperatureAverage = -11,
            TemperatureHighAverage = -10, TemperatureLowAverage = -12,
            TemperatureHighest = 2, TemperatureLowest = -30,
            PrecipitationAverage = float.NaN,
            PrecipitationDaysRatio = 30f/DaysInMonthNovember,
            AverageWindSpeed = 22,
            FogDaysRatio = float.NaN,
            DayLengthAverage = 0,
          },
          new MonthlyClimateData() // December
          {
            TemperatureAverage = 0,
            TemperatureHighAverage = -16, TemperatureLowAverage = -20,
            TemperatureHighest = 2, TemperatureLowest = -37,
            PrecipitationAverage = float.NaN,
            PrecipitationDaysRatio = 0f/DaysInMonthDecember,
            AverageWindSpeed = 19,
            FogDaysRatio = float.NaN,
            DayLengthAverage = 0,
          },
        }
      }},

      #endregion Greenland, Kraulshavn

      #region India, Cherrapunj

      // http://www.weatherbase.com/weather/weatherall.php3?s=425150&cityname=Cherrapunj%2C+Meghalaya%2C+India&units=
      new ClimatePreset() { PresetName = "India, Cherrapunj", PresetCode = "PRESET_INDIA_CHERRAPUNJ", ClimateProperties = new ClimateControlProperties()
      {
        SnowFallTemperature = 2, SnowMeltTemperature = 10, SolarDayLength = 24f,
        ClimateData = new MonthlyClimateData[]
        {
          new MonthlyClimateData() // January
          {
            TemperatureAverage = 11.5f,
            TemperatureHighAverage = 15.7f,
            TemperatureLowAverage = 7.3f,
            TemperatureHighest = float.NaN,
            TemperatureLowest = float.NaN,
            PrecipitationAverage = 19f/DaysInMonthJanuary,
            PrecipitationDaysRatio = float.NaN, //f/DaysInMonthJanuary,
            AverageWindSpeed = float.NaN,
            FogDaysRatio = float.NaN, //f/DaysInMonthJanuary,
            DayLengthAverage = 11.2f,
          },
          new MonthlyClimateData() // February
          {
            TemperatureAverage = 13,
            TemperatureHighAverage = 17.1f,
            TemperatureLowAverage = 8.9f,
            TemperatureHighest = float.NaN,
            TemperatureLowest = float.NaN,
            PrecipitationAverage = 45f/DaysInMonthFebruary,
            PrecipitationDaysRatio = float.NaN, //f/DaysInMonthFebruary,
            AverageWindSpeed = float.NaN,
            FogDaysRatio = float.NaN, //f/DaysInMonthFebruary,
            DayLengthAverage = 11.7f,
          },
          new MonthlyClimateData() // March
          {
            TemperatureAverage = 16.5f,
            TemperatureHighAverage = 20.4f,
            TemperatureLowAverage = 12.5f,
            TemperatureHighest = float.NaN,
            TemperatureLowest = float.NaN,
            PrecipitationAverage = 220f/DaysInMonthMarch,
            PrecipitationDaysRatio = float.NaN, //f/DaysInMonthMarch,
            AverageWindSpeed = float.NaN,
            FogDaysRatio = float.NaN, //f/DaysInMonthMarch,
            DayLengthAverage = 12.4f,
          },
          new MonthlyClimateData() // April
          {
            TemperatureAverage = 18.3f,
            TemperatureHighAverage = 21.9f,
            TemperatureLowAverage = 14.6f,
            TemperatureHighest = float.NaN,
            TemperatureLowest = float.NaN,
            PrecipitationAverage = 725f/DaysInMonthApril,
            PrecipitationDaysRatio = float.NaN, //f/DaysInMonthApril,
            AverageWindSpeed = float.NaN,
            FogDaysRatio = float.NaN, //f/DaysInMonthApril,
            DayLengthAverage = 13.2f,
          },
          new MonthlyClimateData() // May
          {
            TemperatureAverage = 19.3f,
            TemperatureHighAverage = 22.4f,
            TemperatureLowAverage = 16.1f,
            TemperatureHighest = float.NaN,
            TemperatureLowest = float.NaN,
            PrecipitationAverage = 1290f/DaysInMonthMay,
            PrecipitationDaysRatio = float.NaN, //f/DaysInMonthMay,
            AverageWindSpeed = float.NaN,
            FogDaysRatio = float.NaN, //f/DaysInMonthMay,
            DayLengthAverage = 13.8f,
          },
          new MonthlyClimateData() // June
          {
            TemperatureAverage = 20.1f,
            TemperatureHighAverage = 22.4f,
            TemperatureLowAverage = 17.7f,
            TemperatureHighest = float.NaN,
            TemperatureLowest = float.NaN,
            PrecipitationAverage = 2597f/DaysInMonthJune,
            PrecipitationDaysRatio = float.NaN, //f/DaysInMonthJune,
            AverageWindSpeed = float.NaN,
            FogDaysRatio = float.NaN, //f/DaysInMonthJune,
            DayLengthAverage = 14.1f,
          },
          new MonthlyClimateData() // July
          {
            TemperatureAverage = 20.3f,
            TemperatureHighAverage = 22.4f,
            TemperatureLowAverage = 18.2f,
            TemperatureHighest = float.NaN,
            TemperatureLowest = float.NaN,
            PrecipitationAverage = 2553f/DaysInMonthJuly,
            PrecipitationDaysRatio = float.NaN, //f/DaysInMonthJuly,
            AverageWindSpeed = float.NaN,
            FogDaysRatio = float.NaN, //f/DaysInMonthJuly,
            DayLengthAverage = 14f,
          },
          new MonthlyClimateData() // August
          {
            TemperatureAverage = 20.5f,
            TemperatureHighAverage = 22.7f,
            TemperatureLowAverage = 18.2f,
            TemperatureHighest = float.NaN,
            TemperatureLowest = float.NaN,
            PrecipitationAverage = 1803f/DaysInMonthAugust,
            PrecipitationDaysRatio = float.NaN, //f/DaysInMonthAugust,
            AverageWindSpeed = float.NaN,
            FogDaysRatio = float.NaN, //f/DaysInMonthAugust,
            DayLengthAverage = 13.4f,
          },
          new MonthlyClimateData() // September
          {
            TemperatureAverage = 20.4f,
            TemperatureHighAverage = 23,
            TemperatureLowAverage = 17.8f,
            TemperatureHighest = float.NaN,
            TemperatureLowest = float.NaN,
            PrecipitationAverage = 1120f/DaysInMonthSeptember,
            PrecipitationDaysRatio = float.NaN, //f/DaysInMonthSeptember,
            AverageWindSpeed = float.NaN,
            FogDaysRatio = float.NaN, //f/DaysInMonthSeptember,
            DayLengthAverage = 12.7f,
          },
          new MonthlyClimateData() // October
          {
            TemperatureAverage = 19.1f,
            TemperatureHighAverage = 22.5f,
            TemperatureLowAverage = 15.7f,
            TemperatureHighest = float.NaN,
            TemperatureLowest = float.NaN,
            PrecipitationAverage = 432f/DaysInMonthOctober,
            PrecipitationDaysRatio = float.NaN, //f/DaysInMonthOctober,
            AverageWindSpeed = float.NaN,
            FogDaysRatio = float.NaN, //f/DaysInMonthOctober,
            DayLengthAverage = 11.9f,
          },
          new MonthlyClimateData() // November
          {
            TemperatureAverage = 16.1f,
            TemperatureHighAverage = 20.1f,
            TemperatureLowAverage = 12,
            TemperatureHighest = float.NaN,
            TemperatureLowest = float.NaN,
            PrecipitationAverage = 50f/DaysInMonthNovember,
            PrecipitationDaysRatio = float.NaN, //f/DaysInMonthNovember,
            AverageWindSpeed = float.NaN,
            FogDaysRatio = float.NaN, //f/DaysInMonthNovember,
            DayLengthAverage = 11.3f,
          },
          new MonthlyClimateData() // December
          {
            TemperatureAverage = 12.9f,
            TemperatureHighAverage = 17.1f,
            TemperatureLowAverage = 8.6f,
            TemperatureHighest = float.NaN,
            TemperatureLowest = float.NaN,
            PrecipitationAverage = 12f/DaysInMonthDecember,
            PrecipitationDaysRatio = float.NaN, //f/DaysInMonthDecember,
            AverageWindSpeed = float.NaN,
            FogDaysRatio = float.NaN, //f/DaysInMonthDecember,
            DayLengthAverage = 11f,
          },
        }
      }},

      #endregion India, Cherrapunj

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
            PrecipitationAverage = 10f/DaysInMonthJanuary,
            PrecipitationDaysRatio = 3f/DaysInMonthJanuary,
            AverageWindSpeed = 9,
            FogDaysRatio = 25f/DaysInMonthJanuary,
            DayLengthAverage = 10.3f,
          },
          new MonthlyClimateData() // February
          {
            TemperatureAverage = -2,
            TemperatureHighAverage = 1, TemperatureLowAverage = -7,
            TemperatureHighest = 15, TemperatureLowest = -22,
            PrecipitationAverage = 10f/DaysInMonthFebruary,
            PrecipitationDaysRatio = 3f/DaysInMonthFebruary,
            AverageWindSpeed = 12,
            FogDaysRatio = 21f/DaysInMonthFebruary,
            DayLengthAverage = 11.2f,
          },
          new MonthlyClimateData() // March
          {
            TemperatureAverage = 3,
            TemperatureHighAverage = 8, TemperatureLowAverage = -1,
            TemperatureHighest = 18, TemperatureLowest = -13,
            PrecipitationAverage = 20f/DaysInMonthMarch,
            PrecipitationDaysRatio = 5f/DaysInMonthMarch,
            AverageWindSpeed = 12,
            FogDaysRatio = 24f/DaysInMonthMarch,
            DayLengthAverage = 12.4f,
          },
          new MonthlyClimateData() // April
          {
            TemperatureAverage = 10,
            TemperatureHighAverage = 16, TemperatureLowAverage = 5,
            TemperatureHighest = 27, TemperatureLowest = -4,
            PrecipitationAverage = 40f/DaysInMonthApril,
            PrecipitationDaysRatio = 8f/DaysInMonthApril,
            AverageWindSpeed = 12,
            FogDaysRatio = 21f/DaysInMonthApril,
            DayLengthAverage = 13.7f,
          },
          new MonthlyClimateData() // May
          {
            TemperatureAverage = 16,
            TemperatureHighAverage = 21, TemperatureLowAverage = 11,
            TemperatureHighest = 32, TemperatureLowest = 3,
            PrecipitationAverage = 60f/DaysInMonthMay,
            PrecipitationDaysRatio = 10f/DaysInMonthMay,
            AverageWindSpeed = 9,
            FogDaysRatio = 21f/DaysInMonthMay,
            DayLengthAverage = 14.8f,
          },
          new MonthlyClimateData() // June
          {
            TemperatureAverage = 21,
            TemperatureHighAverage = 25, TemperatureLowAverage = 16,
            TemperatureHighest = 33, TemperatureLowest = 7,
            PrecipitationAverage = 70f/DaysInMonthJune,
            PrecipitationDaysRatio = 11f/DaysInMonthJune,
            AverageWindSpeed = 8,
            FogDaysRatio = 22f/DaysInMonthJune,
            DayLengthAverage = 15.4f,
          },
          new MonthlyClimateData() // July
          {
            TemperatureAverage = 24,
            TemperatureHighAverage = 27, TemperatureLowAverage = 20,
            TemperatureHighest = 35, TemperatureLowest = 12,
            PrecipitationAverage = 250f/DaysInMonthJuly,
            PrecipitationDaysRatio = 16f/DaysInMonthJuly,
            AverageWindSpeed = 6,
            FogDaysRatio = 21f/DaysInMonthJuly,
            DayLengthAverage = 15.1f,
          },
          new MonthlyClimateData() // August
          {
            TemperatureAverage = 24,
            TemperatureHighAverage = 28, TemperatureLowAverage = 20,
            TemperatureHighest = 35, TemperatureLowest = 12,
            PrecipitationAverage = 230f/DaysInMonthAugust,
            PrecipitationDaysRatio = 12f/DaysInMonthAugust,
            AverageWindSpeed = 6,
            FogDaysRatio = 21f/DaysInMonthAugust,
            DayLengthAverage = 14.1f,
          },
          new MonthlyClimateData() // September
          {
            TemperatureAverage = 19,
            TemperatureHighAverage = 23, TemperatureLowAverage = 14,
            TemperatureHighest = 30, TemperatureLowest = 4,
            PrecipitationAverage = 110f/DaysInMonthSeptember,
            PrecipitationDaysRatio = 8f/DaysInMonthSeptember,
            AverageWindSpeed = 8,
            FogDaysRatio = 21f/DaysInMonthSeptember,
            DayLengthAverage = 12.9f,
          },
          new MonthlyClimateData() // October
          {
            TemperatureAverage = 12,
            TemperatureHighAverage = 17, TemperatureLowAverage = 7,
            TemperatureHighest = 27, TemperatureLowest = -3,
            PrecipitationAverage = 40f/DaysInMonthOctober,
            PrecipitationDaysRatio = 7f/DaysInMonthOctober,
            AverageWindSpeed = 9,
            FogDaysRatio = 23f/DaysInMonthOctober,
            DayLengthAverage = 11.6f,
          },
          new MonthlyClimateData() // November
          {
            TemperatureAverage = 4,
            TemperatureHighAverage = 8, TemperatureLowAverage = 0,
            TemperatureHighest = 22, TemperatureLowest = -13,
            PrecipitationAverage = 40f/DaysInMonthNovember,
            PrecipitationDaysRatio = 8f/DaysInMonthNovember,
            AverageWindSpeed = 12,
            FogDaysRatio = 22f/DaysInMonthNovember,
            DayLengthAverage = 10.5f,
          },
          new MonthlyClimateData() // December
          {
            TemperatureAverage = -2,
            TemperatureHighAverage = 1, TemperatureLowAverage = -6,
            TemperatureHighest = 12, TemperatureLowest = -21,
            PrecipitationAverage = 20f/DaysInMonthDecember,
            PrecipitationDaysRatio = 4f/DaysInMonthDecember,
            AverageWindSpeed = 12,
            FogDaysRatio = 25f/DaysInMonthDecember,
            DayLengthAverage = 10,
          },
        }
      }},

      #endregion North Korea, Pyongyang

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
            PrecipitationAverage = 30f/DaysInMonthJanuary,
            PrecipitationDaysRatio = 18f/DaysInMonthJanuary,
            AverageWindSpeed = 14,
            FogDaysRatio = 24f/DaysInMonthJanuary,
            DayLengthAverage = 9.3f,
          },
          new MonthlyClimateData() // February
          {
            TemperatureAverage = -1,
            TemperatureHighAverage = 1, TemperatureLowAverage = -4,
            TemperatureHighest = 18, TemperatureLowest = -27,
            PrecipitationAverage = 30f/DaysInMonthFebruary,
            PrecipitationDaysRatio = 17f/DaysInMonthFebruary,
            AverageWindSpeed = 14,
            FogDaysRatio = 22f/DaysInMonthFebruary,
            DayLengthAverage = 10.7f,
          },
          new MonthlyClimateData() // March
          {
            TemperatureAverage = 3,
            TemperatureHighAverage = 7, TemperatureLowAverage = 0,
            TemperatureHighest = 22, TemperatureLowest = -17,
            PrecipitationAverage = 30f/DaysInMonthMarch,
            PrecipitationDaysRatio = 15f/DaysInMonthMarch,
            AverageWindSpeed = 16,
            FogDaysRatio = 23f/DaysInMonthMarch,
            DayLengthAverage = 12.5f,
          },
          new MonthlyClimateData() // April
          {
            TemperatureAverage = 7,
            TemperatureHighAverage = 12, TemperatureLowAverage = 3,
            TemperatureHighest = 28, TemperatureLowest = -7,
            PrecipitationAverage = 40f/DaysInMonthApril,
            PrecipitationDaysRatio = 15f/DaysInMonthApril,
            AverageWindSpeed = 14,
            FogDaysRatio = 19f/DaysInMonthApril,
            DayLengthAverage = 14.4f,
          },
          new MonthlyClimateData() // May
          {
            TemperatureAverage = 12,
            TemperatureHighAverage = 17, TemperatureLowAverage = 7,
            TemperatureHighest = 30, TemperatureLowest = -2,
            PrecipitationAverage = 60f/DaysInMonthMay,
            PrecipitationDaysRatio = 15f/DaysInMonthMay,
            AverageWindSpeed = 12,
            FogDaysRatio = 19f/DaysInMonthMay,
            DayLengthAverage = 16.1f,
          },
          new MonthlyClimateData() // June
          {
            TemperatureAverage = 16,
            TemperatureHighAverage = 20, TemperatureLowAverage = 11,
            TemperatureHighest = 31, TemperatureLowest = 1,
            PrecipitationAverage = 80f/DaysInMonthJune,
            PrecipitationDaysRatio = 16f/DaysInMonthJune,
            AverageWindSpeed = 12,
            FogDaysRatio = 20f/DaysInMonthJune,
            DayLengthAverage = 17,
          },
          new MonthlyClimateData() // July
          {
            TemperatureAverage = 17,
            TemperatureHighAverage = 21, TemperatureLowAverage = 12,
            TemperatureHighest = 33, TemperatureLowest = 6,
            PrecipitationAverage = 60f/DaysInMonthJuly,
            PrecipitationDaysRatio = 14f/DaysInMonthJuly,
            AverageWindSpeed = 12,
            FogDaysRatio = 22f/DaysInMonthJuly,
            DayLengthAverage = 16.6f,
          },
          new MonthlyClimateData() // August
          {
            TemperatureAverage = 17,
            TemperatureHighAverage = 21, TemperatureLowAverage = 12,
            TemperatureHighest = 32, TemperatureLowest = 5,
            PrecipitationAverage = 70f/DaysInMonthAugust,
            PrecipitationDaysRatio = 13f/DaysInMonthAugust,
            AverageWindSpeed = 12,
            FogDaysRatio = 24f/DaysInMonthAugust,
            DayLengthAverage = 15,
          },
          new MonthlyClimateData() // September
          {
            TemperatureAverage = 13,
            TemperatureHighAverage = 17, TemperatureLowAverage = 8,
            TemperatureHighest = 28, TemperatureLowest = -2,
            PrecipitationAverage = 50f/DaysInMonthSeptember,
            PrecipitationDaysRatio = 13f/DaysInMonthSeptember,
            AverageWindSpeed = 12,
            FogDaysRatio = 25f/DaysInMonthSeptember,
            DayLengthAverage = 13.1f,
          },
          new MonthlyClimateData() // October
          {
            TemperatureAverage = 8,
            TemperatureHighAverage = 12, TemperatureLowAverage = 4,
            TemperatureHighest = 26, TemperatureLowest = -7,
            PrecipitationAverage = 40f/DaysInMonthOctober,
            PrecipitationDaysRatio = 13f/DaysInMonthOctober,
            AverageWindSpeed = 14,
            FogDaysRatio = 24f/DaysInMonthOctober,
            DayLengthAverage = 11.2f,
          },
          new MonthlyClimateData() // November
          {
            TemperatureAverage = 2,
            TemperatureHighAverage = 5, TemperatureLowAverage = 0,
            TemperatureHighest = 18, TemperatureLowest = -17,
            PrecipitationAverage = 40f/DaysInMonthNovember,
            PrecipitationDaysRatio = 17f/DaysInMonthNovember,
            AverageWindSpeed = 14,
            FogDaysRatio = 23f/DaysInMonthNovember,
            DayLengthAverage = 9.6f,
          },
          new MonthlyClimateData() // December
          {
            TemperatureAverage = 0,
            TemperatureHighAverage = 2, TemperatureLowAverage = -3,
            TemperatureHighest = 17, TemperatureLowest = -22,
            PrecipitationAverage = 40f/DaysInMonthDecember,
            PrecipitationDaysRatio = 20f/DaysInMonthDecember,
            AverageWindSpeed = 16,
            FogDaysRatio = 23f/DaysInMonthDecember,
            DayLengthAverage = 8.8f,
          },
        }
      }},

      #endregion Poland, Kraków

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
            PrecipitationAverage = 30f/DaysInMonthJanuary,
            PrecipitationDaysRatio = 6f/DaysInMonthJanuary,
            AverageWindSpeed = 17,
            FogDaysRatio = 20f/DaysInMonthJanuary,
            DayLengthAverage = 8.5f,
          },
          new MonthlyClimateData() // February
          {
            TemperatureAverage = -7,
            TemperatureHighAverage = -4, TemperatureLowAverage = -11,
            TemperatureHighest = 10, TemperatureLowest = -33,
            PrecipitationAverage = 20f/DaysInMonthFebruary,
            PrecipitationDaysRatio = 5f/DaysInMonthFebruary,
            AverageWindSpeed = 14,
            FogDaysRatio = 19f/DaysInMonthFebruary,
            DayLengthAverage = 10.3f,
          },
          new MonthlyClimateData() // March
          {
            TemperatureAverage = -2,
            TemperatureHighAverage = 1, TemperatureLowAverage = -5,
            TemperatureHighest = 16, TemperatureLowest = -27,
            PrecipitationAverage = 30f/DaysInMonthMarch,
            PrecipitationDaysRatio = 7f/DaysInMonthMarch,
            AverageWindSpeed = 14,
            FogDaysRatio = 23f/DaysInMonthMarch,
            DayLengthAverage = 12.5f,
          },
          new MonthlyClimateData() // April
          {
            TemperatureAverage = 5,
            TemperatureHighAverage = 9, TemperatureLowAverage = 1,
            TemperatureHighest = 23, TemperatureLowest = -8,
            PrecipitationAverage = 30f/DaysInMonthApril,
            PrecipitationDaysRatio = 10f/DaysInMonthApril,
            AverageWindSpeed = 14,
            FogDaysRatio = 20f/DaysInMonthApril,
            DayLengthAverage = 14.9f,
          },
          new MonthlyClimateData() // May
          {
            TemperatureAverage = 12,
            TemperatureHighAverage = 17, TemperatureLowAverage = 6,
            TemperatureHighest = 28, TemperatureLowest = -6,
            PrecipitationAverage = 50f/DaysInMonthMay,
            PrecipitationDaysRatio = 12f/DaysInMonthMay,
            AverageWindSpeed = 14,
            FogDaysRatio = 20f/DaysInMonthMay,
            DayLengthAverage = 17.2f,
          },
          new MonthlyClimateData() // June
          {
            TemperatureAverage = 15,
            TemperatureHighAverage = 20, TemperatureLowAverage = 10,
            TemperatureHighest = 32, TemperatureLowest = 0,
            PrecipitationAverage = 60f/DaysInMonthJune,
            PrecipitationDaysRatio = 12f/DaysInMonthJune,
            AverageWindSpeed = 14,
            FogDaysRatio = 21f/DaysInMonthJune,
            DayLengthAverage = 18.5f,
          },
          new MonthlyClimateData() // July
          {
            TemperatureAverage = 17,
            TemperatureHighAverage = 21, TemperatureLowAverage = 12,
            TemperatureHighest = 35, TemperatureLowest = 5,
            PrecipitationAverage = 80f/DaysInMonthJuly,
            PrecipitationDaysRatio = 11f/DaysInMonthJuly,
            AverageWindSpeed = 14,
            FogDaysRatio = 21f/DaysInMonthJuly,
            DayLengthAverage = 17.8f,
          },
          new MonthlyClimateData() // August
          {
            TemperatureAverage = 15,
            TemperatureHighAverage = 20, TemperatureLowAverage = 11,
            TemperatureHighest = 32, TemperatureLowest = 0,
            PrecipitationAverage = 70f/DaysInMonthAugust,
            PrecipitationDaysRatio = 11f/DaysInMonthAugust,
            AverageWindSpeed = 14,
            FogDaysRatio = 24f/DaysInMonthAugust,
            DayLengthAverage = 15.7f,
          },
          new MonthlyClimateData() // September
          {
            TemperatureAverage = 10,
            TemperatureHighAverage = 13, TemperatureLowAverage = 6,
            TemperatureHighest = 28, TemperatureLowest = -6,
            PrecipitationAverage = 50f/DaysInMonthSeptember,
            PrecipitationDaysRatio = 11f/DaysInMonthSeptember,
            AverageWindSpeed = 16,
            FogDaysRatio = 22f/DaysInMonthSeptember,
            DayLengthAverage = 13.3f,
          },
          new MonthlyClimateData() // October
          {
            TemperatureAverage = 3,
            TemperatureHighAverage = 7, TemperatureLowAverage = 0,
            TemperatureHighest = 22, TemperatureLowest = -13,
            PrecipitationAverage = 50f/DaysInMonthOctober,
            PrecipitationDaysRatio = 15f/DaysInMonthOctober,
            AverageWindSpeed = 16,
            FogDaysRatio = 21f/DaysInMonthOctober,
            DayLengthAverage = 11,
          },
          new MonthlyClimateData() // November
          {
            TemperatureAverage = -2,
            TemperatureHighAverage = 0, TemperatureLowAverage = -4,
            TemperatureHighest = 10, TemperatureLowest = -25,
            PrecipitationAverage = 40f/DaysInMonthNovember,
            PrecipitationDaysRatio = 9f/DaysInMonthNovember,
            AverageWindSpeed = 16,
            FogDaysRatio = 20f/DaysInMonthNovember,
            DayLengthAverage = 8.9f,
          },
          new MonthlyClimateData() // December
          {
            TemperatureAverage = -6,
            TemperatureHighAverage = -3, TemperatureLowAverage = -8,
            TemperatureHighest = 10, TemperatureLowest = -42,
            PrecipitationAverage = 40f/DaysInMonthDecember,
            PrecipitationDaysRatio = 6f/DaysInMonthDecember,
            AverageWindSpeed = 17,
            FogDaysRatio = 19f/DaysInMonthDecember,
            DayLengthAverage = 7.9f,
          },
        }
      }},

      #endregion Russia, Moscow

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
            PrecipitationAverage = 65f/DaysInMonthJanuary,
            PrecipitationDaysRatio = 6f/DaysInMonthJanuary,
            AverageWindSpeed = 12,
            FogDaysRatio = 4f/DaysInMonthJanuary,
            DayLengthAverage = 10.4f,
          },
          new MonthlyClimateData() // February
          {
            TemperatureAverage = 12.2f,
            TemperatureHighAverage = 17.9f, TemperatureLowAverage = 6.7f,
            TemperatureHighest = 26, TemperatureLowest = -2,
            PrecipitationAverage = 54f/DaysInMonthFebruary,
            PrecipitationDaysRatio = 6f/DaysInMonthFebruary,
            AverageWindSpeed = 12,
            FogDaysRatio = 3f/DaysInMonthFebruary,
            DayLengthAverage = 11.3f,
          },
          new MonthlyClimateData() // March
          {
            TemperatureAverage = 14.7f,
            TemperatureHighAverage = 21.2f, TemperatureLowAverage = 8.2f,
            TemperatureHighest = 31, TemperatureLowest = 0,
            PrecipitationAverage = 38f/DaysInMonthMarch,
            PrecipitationDaysRatio = 5f/DaysInMonthMarch,
            AverageWindSpeed = 12,
            FogDaysRatio = 3f/DaysInMonthMarch,
            DayLengthAverage = 12.4f,
          },
          new MonthlyClimateData() // April
          {
            TemperatureAverage = 16.4f,
            TemperatureHighAverage = 22.7f, TemperatureLowAverage = 10.1f,
            TemperatureHighest = 33, TemperatureLowest = 1,
            PrecipitationAverage = 57f/DaysInMonthApril,
            PrecipitationDaysRatio = 7f/DaysInMonthApril,
            AverageWindSpeed = 16,
            FogDaysRatio = 2f/DaysInMonthApril,
            DayLengthAverage = 13.7f,
          },
          new MonthlyClimateData() // May
          {
            TemperatureAverage = 19.7f,
            TemperatureHighAverage = 26.4f, TemperatureLowAverage = 13.1f,
            TemperatureHighest = 38, TemperatureLowest = 6,
            PrecipitationAverage = 34f/DaysInMonthMay,
            PrecipitationDaysRatio = 4f/DaysInMonthMay,
            AverageWindSpeed = 16,
            FogDaysRatio = 1f/DaysInMonthMay,
            DayLengthAverage = 14.7f,
          },
          new MonthlyClimateData() // June
          {
            TemperatureAverage = 23.9f,
            TemperatureHighAverage = 31, TemperatureLowAverage = 16.7f,
            TemperatureHighest = 43, TemperatureLowest = 7,
            PrecipitationAverage = 13f/DaysInMonthJune,
            PrecipitationDaysRatio = 2f/DaysInMonthJune,
            AverageWindSpeed = 16,
            FogDaysRatio = 1f/DaysInMonthJune,
            DayLengthAverage = 15.2f,
          },
          new MonthlyClimateData() // July
          {
            TemperatureAverage = 27.4f,
            TemperatureHighAverage = 35.3f, TemperatureLowAverage = 19.4f,
            TemperatureHighest = 43, TemperatureLowest = 13,
            PrecipitationAverage = 2f/DaysInMonthJuly,
            PrecipitationDaysRatio = 0f/DaysInMonthJuly,
            AverageWindSpeed = 16,
            FogDaysRatio = 0f/DaysInMonthJuly,
            DayLengthAverage = 14.9f,
          },
          new MonthlyClimateData() // August
          {
            TemperatureAverage = 27.2f,
            TemperatureHighAverage = 35, TemperatureLowAverage = 19.5f,
            TemperatureHighest = 45, TemperatureLowest = 12,
            PrecipitationAverage = 6f/DaysInMonthAugust,
            PrecipitationDaysRatio = 0f/DaysInMonthAugust,
            AverageWindSpeed = 16,
            FogDaysRatio = 0f/DaysInMonthAugust,
            DayLengthAverage = 14,
          },
          new MonthlyClimateData() // September
          {
            TemperatureAverage = 24.5f,
            TemperatureHighAverage = 31.6f, TemperatureLowAverage = 17.5f,
            TemperatureHighest = 43, TemperatureLowest = 8,
            PrecipitationAverage = 23f/DaysInMonthSeptember,
            PrecipitationDaysRatio = 2f/DaysInMonthSeptember,
            AverageWindSpeed = 14,
            FogDaysRatio = 1f/DaysInMonthSeptember,
            DayLengthAverage = 12.8f,
          },
          new MonthlyClimateData() // October
          {
            TemperatureAverage = 19.6f,
            TemperatureHighAverage = 25.6f, TemperatureLowAverage = 13.5f,
            TemperatureHighest = 36, TemperatureLowest = 3,
            PrecipitationAverage = 62f/DaysInMonthOctober,
            PrecipitationDaysRatio = 6f/DaysInMonthOctober,
            AverageWindSpeed = 12,
            FogDaysRatio = 2f/DaysInMonthOctober,
            DayLengthAverage = 11.6f,
          },
          new MonthlyClimateData() // November
          {
            TemperatureAverage = 14.8f,
            TemperatureHighAverage = 20.1f, TemperatureLowAverage = 9.3f,
            TemperatureHighest = 31, TemperatureLowest = -1,
            PrecipitationAverage = 84f/DaysInMonthNovember,
            PrecipitationDaysRatio = 6f/DaysInMonthNovember,
            AverageWindSpeed = 12,
            FogDaysRatio = 2f/DaysInMonthNovember,
            DayLengthAverage = 10.6f,
          },
          new MonthlyClimateData() // December
          {
            TemperatureAverage = 11.8f,
            TemperatureHighAverage = 16.6f, TemperatureLowAverage = 6.9f,
            TemperatureHighest = 23, TemperatureLowest = -5,
            PrecipitationAverage = 95f/DaysInMonthDecember,
            PrecipitationDaysRatio = 8f/DaysInMonthDecember,
            AverageWindSpeed = 12,
            FogDaysRatio = 3f/DaysInMonthDecember,
            DayLengthAverage = 10.1f,
          },
        }
      }},

      #endregion Spain, Seville

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
            PrecipitationAverage = 39f/DaysInMonthJanuary,
            PrecipitationDaysRatio = 25f/DaysInMonthJanuary,
            AverageWindSpeed = 14,
            FogDaysRatio = 16f/DaysInMonthJanuary,
            DayLengthAverage = 7.8f,
          },
          new MonthlyClimateData() // February
          {
            TemperatureAverage = -3,
            TemperatureHighAverage = 0, TemperatureLowAverage = -6,
            TemperatureHighest = 12, TemperatureLowest = -27,
            PrecipitationAverage = 27f/DaysInMonthFebruary,
            PrecipitationDaysRatio = 20f/DaysInMonthFebruary,
            AverageWindSpeed = 12,
            FogDaysRatio = 15f/DaysInMonthFebruary,
            DayLengthAverage = 10,
          },
          new MonthlyClimateData() // March
          {
            TemperatureAverage = 0,
            TemperatureHighAverage = 2, TemperatureLowAverage = -3,
            TemperatureHighest = 16, TemperatureLowest = -20,
            PrecipitationAverage = 26f/DaysInMonthMarch,
            PrecipitationDaysRatio = 21f/DaysInMonthMarch,
            AverageWindSpeed = 16,
            FogDaysRatio = 18f/DaysInMonthMarch,
            DayLengthAverage = 12.6f,
          },
          new MonthlyClimateData() // April
          {
            TemperatureAverage = 3,
            TemperatureHighAverage = 8, TemperatureLowAverage = 0,
            TemperatureHighest = 26, TemperatureLowest = -10,
            PrecipitationAverage = 30f/DaysInMonthApril,
            PrecipitationDaysRatio = 20f/DaysInMonthApril,
            AverageWindSpeed = 16,
            FogDaysRatio = 13f/DaysInMonthApril,
            DayLengthAverage = 15.4f,
          },
          new MonthlyClimateData() // May
          {
            TemperatureAverage = 10,
            TemperatureHighAverage = 15, TemperatureLowAverage = 5,
            TemperatureHighest = 27, TemperatureLowest = -5,
            PrecipitationAverage = 30f/DaysInMonthMay,
            PrecipitationDaysRatio = 17f/DaysInMonthMay,
            AverageWindSpeed = 12,
            FogDaysRatio = 10f/DaysInMonthMay,
            DayLengthAverage = 18.2f,
          },
          new MonthlyClimateData() // June
          {
            TemperatureAverage = 14,
            TemperatureHighAverage = 19, TemperatureLowAverage = 9,
            TemperatureHighest = 30, TemperatureLowest = 1,
            PrecipitationAverage = 45f/DaysInMonthJune,
            PrecipitationDaysRatio = 18f/DaysInMonthJune,
            AverageWindSpeed = 14,
            FogDaysRatio = 13f/DaysInMonthJune,
            DayLengthAverage = 20.1f,
          },
          new MonthlyClimateData() // July
          {
            TemperatureAverage = 17,
            TemperatureHighAverage = 21, TemperatureLowAverage = 12,
            TemperatureHighest = 32, TemperatureLowest = 5,
            PrecipitationAverage = 72f/DaysInMonthJuly,
            PrecipitationDaysRatio = 20f/DaysInMonthJuly,
            AverageWindSpeed = 12,
            FogDaysRatio = 14f/DaysInMonthJuly,
            DayLengthAverage = 19,
          },
          new MonthlyClimateData() // August
          {
            TemperatureAverage = 16,
            TemperatureHighAverage = 20, TemperatureLowAverage = 11,
            TemperatureHighest = 35, TemperatureLowest = -1,
            PrecipitationAverage = 66f/DaysInMonthAugust,
            PrecipitationDaysRatio = 19f/DaysInMonthAugust,
            AverageWindSpeed = 12,
            FogDaysRatio = 17f/DaysInMonthAugust,
            DayLengthAverage = 16.3f,
          },
          new MonthlyClimateData() // September
          {
            TemperatureAverage = 11,
            TemperatureHighAverage = 14, TemperatureLowAverage = 7,
            TemperatureHighest = 26, TemperatureLowest = -5,
            PrecipitationAverage = 55f/DaysInMonthSeptember,
            PrecipitationDaysRatio = 20f/DaysInMonthSeptember,
            AverageWindSpeed = 14,
            FogDaysRatio = 15f/DaysInMonthSeptember,
            DayLengthAverage = 13.5f,
          },
          new MonthlyClimateData() // October
          {
            TemperatureAverage = 6,
            TemperatureHighAverage = 8, TemperatureLowAverage = 3,
            TemperatureHighest = 20, TemperatureLowest = -11,
            PrecipitationAverage = 50f/DaysInMonthOctober,
            PrecipitationDaysRatio = 20f/DaysInMonthOctober,
            AverageWindSpeed = 9,
            FogDaysRatio = 17f/DaysInMonthOctober,
            DayLengthAverage = 10.8f,
          },
          new MonthlyClimateData() // November
          {
            TemperatureAverage = 1,
            TemperatureHighAverage = 3, TemperatureLowAverage = 0,
            TemperatureHighest = 12, TemperatureLowest = -15,
            PrecipitationAverage = 53f/DaysInMonthNovember,
            PrecipitationDaysRatio = 23f/DaysInMonthNovember,
            AverageWindSpeed = 12,
            FogDaysRatio = 14f/DaysInMonthNovember,
            DayLengthAverage = 8.4f,
          },
          new MonthlyClimateData() // December
          {
            TemperatureAverage = -2,
            TemperatureHighAverage = 0, TemperatureLowAverage = -5,
            TemperatureHighest = 10, TemperatureLowest = -26,
            PrecipitationAverage = 46f/DaysInMonthDecember,
            PrecipitationDaysRatio = 25f/DaysInMonthDecember,
            AverageWindSpeed = 12,
            FogDaysRatio = 15f/DaysInMonthDecember,
            DayLengthAverage = 7.1f,
          },
        }
      }},

      #endregion Sweden, Stockholm

      #region USA, Anchorage

      // http://www.weatherbase.com/weather/weatherall.php3?s=37207&cityname=Anchorage%2C+Alaska%2C+United+States+of+America&units=
      new ClimatePreset() { PresetName = "USA, Anchorage", PresetCode = "PRESET_USA_ANCHORAGE", ClimateProperties = new ClimateControlProperties()
      {
        SnowFallTemperature = 2f, SnowMeltTemperature = 8f, SolarDayLength = 24f,
        ClimateData = new MonthlyClimateData[]
        {
          new MonthlyClimateData() // January
          {
            TemperatureAverage = -8.3f,
            TemperatureHighAverage = -4.9f, TemperatureLowAverage = -11.6f,
            TemperatureHighest = 10, TemperatureLowest = -36.7f,
            PrecipitationAverage = 17.8f/DaysInMonthJanuary,
            PrecipitationDaysRatio = 8.2f/DaysInMonthJanuary,
            AverageWindSpeed = 10.8f,
            FogDaysRatio = 11f/DaysInMonthJanuary,
            DayLengthAverage = 7.6f,
          },
          new MonthlyClimateData() // February
          {
            TemperatureAverage = -6.6f,
            TemperatureHighAverage = -3f, TemperatureLowAverage = -10.1f,
            TemperatureHighest = 8.9f, TemperatureLowest = -33.3f,
            PrecipitationAverage = 17.8f/DaysInMonthFebruary,
            PrecipitationDaysRatio = 7.1f/DaysInMonthFebruary,
            AverageWindSpeed = 10.8f,
            FogDaysRatio = 9f/DaysInMonthFebruary,
            DayLengthAverage = 9.9f,
          },
          new MonthlyClimateData() // March
          {
            TemperatureAverage = -3,
            TemperatureHighAverage = 1.1f, TemperatureLowAverage = -7.1f,
            TemperatureHighest = 10.6f, TemperatureLowest = -31.1f,
            PrecipitationAverage = 15.2f/DaysInMonthMarch,
            PrecipitationDaysRatio = 5.9f/DaysInMonthMarch,
            AverageWindSpeed = 11.7f,
            FogDaysRatio = 5f/DaysInMonthMarch,
            DayLengthAverage = 12.7f,
          },
          new MonthlyClimateData() // April
          {
            TemperatureAverage = 2.7f,
            TemperatureHighAverage = 6.9f, TemperatureLowAverage = -1.6f,
            TemperatureHighest = 20.6f, TemperatureLowest = -20f,
            PrecipitationAverage = 12.7f/DaysInMonthApril,
            PrecipitationDaysRatio = 5f/DaysInMonthApril,
            AverageWindSpeed = 11.9f,
            FogDaysRatio = 4f/DaysInMonthApril,
            DayLengthAverage = 15.7f,
          },
          new MonthlyClimateData() // May
          {
            TemperatureAverage = 8.8f,
            TemperatureHighAverage = 13.3f, TemperatureLowAverage = 4.2f,
            TemperatureHighest = 25, TemperatureLowest = -8.3f,
            PrecipitationAverage = 17.8f/DaysInMonthMay,
            PrecipitationDaysRatio = 7.3f/DaysInMonthMay,
            AverageWindSpeed = 13.5f,
            FogDaysRatio = 1f/DaysInMonthMay,
            DayLengthAverage = 18.8f,
          },
          new MonthlyClimateData() // June
          {
            TemperatureAverage = 12.9f,
            TemperatureHighAverage = 17.1f, TemperatureLowAverage = 8.7f,
            TemperatureHighest = 29.4f, TemperatureLowest = 0.6f,
            PrecipitationAverage = 25.4f/DaysInMonthJune,
            PrecipitationDaysRatio = 8.5f/DaysInMonthJune,
            AverageWindSpeed = 13.4f,
            FogDaysRatio = 2f/DaysInMonthJune,
            DayLengthAverage = 22,
          },
          new MonthlyClimateData() // July
          {
            TemperatureAverage = 14.9f,
            TemperatureHighAverage = 18.6f, TemperatureLowAverage = 11.2f,
            TemperatureHighest = 28.9f, TemperatureLowest = 3.3f,
            PrecipitationAverage = 45.7f/DaysInMonthJuly,
            PrecipitationDaysRatio = 12f/DaysInMonthJuly,
            AverageWindSpeed = 11.9f,
            FogDaysRatio = 4f/DaysInMonthJuly,
            DayLengthAverage = 20.2f,
          },
          new MonthlyClimateData() // August
          {
            TemperatureAverage = 13.7f,
            TemperatureHighAverage = 17.5f, TemperatureLowAverage = 10,
            TemperatureHighest = 27.8f, TemperatureLowest = -0.6f,
            PrecipitationAverage = 83.8f/DaysInMonthAugust,
            PrecipitationDaysRatio = 14.6f/DaysInMonthAugust,
            AverageWindSpeed = 11.1f,
            FogDaysRatio = 5f/DaysInMonthAugust,
            DayLengthAverage = 16.6f,
          },
          new MonthlyClimateData() // September
          {
            TemperatureAverage = 9.2f,
            TemperatureHighAverage = 12.8f, TemperatureLowAverage = 5.6f,
            TemperatureHighest = 22.8f, TemperatureLowest = -7.2f,
            PrecipitationAverage = 76.2f/DaysInMonthSeptember,
            PrecipitationDaysRatio = 14.8f/DaysInMonthSeptember,
            AverageWindSpeed = 11.3f,
            FogDaysRatio = 6f/DaysInMonthSeptember,
            DayLengthAverage = 13.5f,
          },
          new MonthlyClimateData() // October
          {
            TemperatureAverage = 1.6f,
            TemperatureHighAverage = 4.7f, TemperatureLowAverage = -1.6f,
            TemperatureHighest = 17.8f, TemperatureLowest = -20.6f,
            PrecipitationAverage = 50.8f/DaysInMonthOctober,
            PrecipitationDaysRatio = 11.9f/DaysInMonthOctober,
            AverageWindSpeed = 10.9f,
            FogDaysRatio = 7f/DaysInMonthOctober,
            DayLengthAverage = 10.7f,
          },
          new MonthlyClimateData() // November
          {
            TemperatureAverage = -5.4f,
            TemperatureHighAverage = -2.3f, TemperatureLowAverage = -8.6f,
            TemperatureHighest = 12.2f, TemperatureLowest = -29.4f,
            PrecipitationAverage = 30.5f/DaysInMonthNovember,
            PrecipitationDaysRatio = 9.4f/DaysInMonthNovember,
            AverageWindSpeed = 10.8f,
            FogDaysRatio = 10f/DaysInMonthNovember,
            DayLengthAverage = 8.1f,
          },
          new MonthlyClimateData() // December
          {
            TemperatureAverage = -7.2f,
            TemperatureHighAverage = -4, TemperatureLowAverage = -10.4f,
            TemperatureHighest = 8.9f, TemperatureLowest = -34.4f,
            PrecipitationAverage = 27.9f/DaysInMonthDecember,
            PrecipitationDaysRatio = 10.5f/DaysInMonthDecember,
            AverageWindSpeed = 10.1f,
            FogDaysRatio = 12f/DaysInMonthDecember,
            DayLengthAverage = 6.7f,
          },
        }
      }},

      #endregion USA, Anchorage

      #region USA, Denver

      // http://www.weatherbase.com/weather/weatherall.php3?s=96427&cityname=Denver%2C+Colorado%2C+United+States+of+America&units=
      new ClimatePreset() { PresetName = "USA, Denver", PresetCode = "PRESET_USA_DENVER", ClimateProperties = new ClimateControlProperties()
      {
        SnowFallTemperature = 2f, SnowMeltTemperature = 8f, SolarDayLength = 24f,
        ClimateData = new MonthlyClimateData[]
        {
          new MonthlyClimateData() // January
          {
            TemperatureAverage = -0.6f,
            TemperatureHighAverage = 6.9f, TemperatureLowAverage = -8.1f,
            TemperatureHighest = 22.8f, TemperatureLowest = -31.7f,
            PrecipitationAverage = 12.7f/DaysInMonthJanuary,
            PrecipitationDaysRatio = 5.1f/DaysInMonthJanuary,
            AverageWindSpeed = float.NaN,
            FogDaysRatio = 5f/DaysInMonthJanuary,
            DayLengthAverage = 10.2f,
          },
          new MonthlyClimateData() // February
          {
            TemperatureAverage = 0.4f,
            TemperatureHighAverage = 7.8f, TemperatureLowAverage = -6.9f,
            TemperatureHighest = 25, TemperatureLowest = -34.4f,
            PrecipitationAverage = 12.7f/DaysInMonthFebruary,
            PrecipitationDaysRatio = 5.6f/DaysInMonthFebruary,
            AverageWindSpeed = float.NaN,
            FogDaysRatio = 6f/DaysInMonthFebruary,
            DayLengthAverage = 11.2f,
          },
          new MonthlyClimateData() // March
          {
            TemperatureAverage = 4.4f,
            TemperatureHighAverage = 12, TemperatureLowAverage = -3.1f,
            TemperatureHighest = 28.9f, TemperatureLowest = -23.9f,
            PrecipitationAverage = 33f/DaysInMonthMarch,
            PrecipitationDaysRatio = 7.4f/DaysInMonthMarch,
            AverageWindSpeed = float.NaN,
            FogDaysRatio = 7f/DaysInMonthMarch,
            DayLengthAverage = 12.5f,
          },
          new MonthlyClimateData() // April
          {
            TemperatureAverage = 8.6f,
            TemperatureHighAverage = 16.1f, TemperatureLowAverage = 1.2f,
            TemperatureHighest = 32.2f, TemperatureLowest = -18.9f,
            PrecipitationAverage = 43.2f/DaysInMonthApril,
            PrecipitationDaysRatio = 8.4f/DaysInMonthApril,
            AverageWindSpeed = float.NaN,
            FogDaysRatio = 5f/DaysInMonthApril,
            DayLengthAverage = 13.8f,
          },
          new MonthlyClimateData() // May
          {
            TemperatureAverage = 14,
            TemperatureHighAverage = 21.4f, TemperatureLowAverage = 6.6f,
            TemperatureHighest = 35.6f, TemperatureLowest = -6.1f,
            PrecipitationAverage = 58.4f/DaysInMonthMay,
            PrecipitationDaysRatio = 10.8f/DaysInMonthMay,
            AverageWindSpeed = float.NaN,
            FogDaysRatio = 5f/DaysInMonthMay,
            DayLengthAverage = 14.9f,
          },
          new MonthlyClimateData() // June
          {
            TemperatureAverage = 19.4f,
            TemperatureHighAverage = 27.3f, TemperatureLowAverage = 11.6f,
            TemperatureHighest = 40.6f, TemperatureLowest = -1.1f,
            PrecipitationAverage = 43.2f/DaysInMonthJune,
            PrecipitationDaysRatio = 8.2f/DaysInMonthJune,
            AverageWindSpeed = float.NaN,
            FogDaysRatio = 3f/DaysInMonthJune,
            DayLengthAverage = 15.5f,
          },
          new MonthlyClimateData() // July
          {
            TemperatureAverage = 23.1f,
            TemperatureHighAverage = 31.2f, TemperatureLowAverage = 15,
            TemperatureHighest = 40.6f, TemperatureLowest = -1.1f,
            PrecipitationAverage = 53.3f/DaysInMonthJuly,
            PrecipitationDaysRatio = 8.5f/DaysInMonthJuly,
            AverageWindSpeed = float.NaN,
            FogDaysRatio = 2f/DaysInMonthJuly,
            DayLengthAverage = 15.2f,
          },
          new MonthlyClimateData() // August
          {
            TemperatureAverage = 21.9f,
            TemperatureHighAverage = 29.8f, TemperatureLowAverage = 14.1f,
            TemperatureHighest = 40, TemperatureLowest = 5,
            PrecipitationAverage = 53.3f/DaysInMonthAugust,
            PrecipitationDaysRatio = 9.1f/DaysInMonthAugust,
            AverageWindSpeed = float.NaN,
            FogDaysRatio = 3f/DaysInMonthAugust,
            DayLengthAverage = 14.1f,
          },
          new MonthlyClimateData() // September
          {
            TemperatureAverage = 16.9f,
            TemperatureHighAverage = 25.1f, TemperatureLowAverage = 8.6f,
            TemperatureHighest = 36.1f, TemperatureLowest = -8.3f,
            PrecipitationAverage = 27.9f/DaysInMonthSeptember,
            PrecipitationDaysRatio = 6.8f/DaysInMonthSeptember,
            AverageWindSpeed = float.NaN,
            FogDaysRatio = 4f/DaysInMonthSeptember,
            DayLengthAverage = 12.9f,
          },
          new MonthlyClimateData() // October
          {
            TemperatureAverage = 10.2f,
            TemperatureHighAverage = 18.3f, TemperatureLowAverage = 2.1f,
            TemperatureHighest = 31.7f, TemperatureLowest = -16.1f,
            PrecipitationAverage = 27.9f/DaysInMonthOctober,
            PrecipitationDaysRatio = 5.4f/DaysInMonthOctober,
            AverageWindSpeed = float.NaN,
            FogDaysRatio = 4f/DaysInMonthOctober,
            DayLengthAverage = 11.6f,
          },
          new MonthlyClimateData() // November
          {
            TemperatureAverage = 3.7f,
            TemperatureHighAverage = 11.3f, TemperatureLowAverage = -3.9f,
            TemperatureHighest = 26.7f, TemperatureLowest = -22.2f,
            PrecipitationAverage = 20.3f/DaysInMonthNovember,
            PrecipitationDaysRatio = 5.8f/DaysInMonthNovember,
            AverageWindSpeed = float.NaN,
            FogDaysRatio = 6f/DaysInMonthNovember,
            DayLengthAverage = 10.5f,
          },
          new MonthlyClimateData() // December
          {
            TemperatureAverage = -1.1f,
            TemperatureHighAverage = 6.3f, TemperatureLowAverage = -8.5f,
            TemperatureHighest = 23.9f, TemperatureLowest = -31.7f,
            PrecipitationAverage = 15.2f/DaysInMonthDecember,
            PrecipitationDaysRatio = 5.4f/DaysInMonthDecember,
            AverageWindSpeed = float.NaN,
            FogDaysRatio = 5f/DaysInMonthDecember,
            DayLengthAverage = 9.9f,
          },
        }
      }},

      #endregion USA, Denver

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
            PrecipitationAverage = 81.3f/DaysInMonthJanuary,
            PrecipitationDaysRatio = 10f/DaysInMonthJanuary,
            AverageWindSpeed = 21.1f,
            FogDaysRatio = 0f/DaysInMonthJanuary,
            DayLengthAverage = 10.2f,
          },
          new MonthlyClimateData() // February
          {
            TemperatureAverage = 1.8f,
            TemperatureHighAverage = 5.7f, TemperatureLowAverage = -1.9f,
            TemperatureHighest = 23.9f, TemperatureLowest = -26.1f,
            PrecipitationAverage = 71.1f/DaysInMonthFebruary,
            PrecipitationDaysRatio = 9f/DaysInMonthFebruary,
            AverageWindSpeed = 21.1f,
            FogDaysRatio = 0f/DaysInMonthFebruary,
            DayLengthAverage = 11.2f,
          },
          new MonthlyClimateData() // March
          {
            TemperatureAverage = 5.7f,
            TemperatureHighAverage = 9.9f, TemperatureLowAverage = 1.4f,
            TemperatureHighest = 30, TemperatureLowest = -16.1f,
            PrecipitationAverage = 101.6f/DaysInMonthMarch,
            PrecipitationDaysRatio = 11f/DaysInMonthMarch,
            AverageWindSpeed = 21.1f,
            FogDaysRatio = 0f/DaysInMonthMarch,
            DayLengthAverage = 12.5f,
          },
          new MonthlyClimateData() // April
          {
            TemperatureAverage = 11.5f,
            TemperatureHighAverage = 16.1f, TemperatureLowAverage = 6.9f,
            TemperatureHighest = 35.6f, TemperatureLowest = -11.1f,
            PrecipitationAverage = 101.6f/DaysInMonthApril,
            PrecipitationDaysRatio = 11f/DaysInMonthApril,
            AverageWindSpeed = 19.8f,
            FogDaysRatio = 0f/DaysInMonthApril,
            DayLengthAverage = 13.8f,
          },
          new MonthlyClimateData() // May
          {
            TemperatureAverage = 16.9f,
            TemperatureHighAverage = 21.8f, TemperatureLowAverage = 12.2f,
            TemperatureHighest = 37.2f, TemperatureLowest = 0,
            PrecipitationAverage = 96.5f/DaysInMonthMay,
            PrecipitationDaysRatio = 11f/DaysInMonthMay,
            AverageWindSpeed = 17.9f,
            FogDaysRatio = 0f/DaysInMonthMay,
            DayLengthAverage = 15,
          },
          new MonthlyClimateData() // June
          {
            TemperatureAverage = 22.3f,
            TemperatureHighAverage = 26.9f, TemperatureLowAverage = 17.7f,
            TemperatureHighest = 38.3f, TemperatureLowest = 6.7f,
            PrecipitationAverage = 99.1f/DaysInMonthJune,
            PrecipitationDaysRatio = 9f/DaysInMonthJune,
            AverageWindSpeed = 16.7f,
            FogDaysRatio = 0f/DaysInMonthJune,
            DayLengthAverage = 15.6f,
          },
          new MonthlyClimateData() // July
          {
            TemperatureAverage = 25.2f,
            TemperatureHighAverage = 29.6f, TemperatureLowAverage = 20.8f,
            TemperatureHighest = 41.1f, TemperatureLowest = 11.1f,
            PrecipitationAverage = 114.3f/DaysInMonthJuly,
            PrecipitationDaysRatio = 8f/DaysInMonthJuly,
            AverageWindSpeed = 16.1f,
            FogDaysRatio = 0f/DaysInMonthJuly,
            DayLengthAverage = 15.3f,
          },
          new MonthlyClimateData() // August
          {
            TemperatureAverage = 24.6f,
            TemperatureHighAverage = 28.7f, TemperatureLowAverage = 20.5f,
            TemperatureHighest = 40, TemperatureLowest = 10,
            PrecipitationAverage = 104.1f/DaysInMonthAugust,
            PrecipitationDaysRatio = 9f/DaysInMonthAugust,
            AverageWindSpeed = 15.9f,
            FogDaysRatio = 0f/DaysInMonthAugust,
            DayLengthAverage = 14.2f,
          },
          new MonthlyClimateData() // September
          {
            TemperatureAverage = 20.6f,
            TemperatureHighAverage = 24.6f, TemperatureLowAverage = 16.6f,
            TemperatureHighest = 38.9f, TemperatureLowest = 3.9f,
            PrecipitationAverage = 94f/DaysInMonthSeptember,
            PrecipitationDaysRatio = 8f/DaysInMonthSeptember,
            AverageWindSpeed = 17.1f,
            FogDaysRatio = 0f/DaysInMonthSeptember,
            DayLengthAverage = 12.9f,
          },
          new MonthlyClimateData() // October
          {
            TemperatureAverage = 14.5f,
            TemperatureHighAverage = 18.4f, TemperatureLowAverage = 10.6f,
            TemperatureHighest = 34.4f, TemperatureLowest = -2.2f,
            PrecipitationAverage = 96.5f/DaysInMonthOctober,
            PrecipitationDaysRatio = 7f/DaysInMonthOctober,
            AverageWindSpeed = 18,
            FogDaysRatio = 0f/DaysInMonthOctober,
            DayLengthAverage = 11.5f,
          },
          new MonthlyClimateData() // November
          {
            TemperatureAverage = 9.1f,
            TemperatureHighAverage = 12.6f, TemperatureLowAverage = 5.4f,
            TemperatureHighest = 28.9f, TemperatureLowest = -15,
            PrecipitationAverage = 86.4f/DaysInMonthNovember,
            PrecipitationDaysRatio = 10f/DaysInMonthNovember,
            AverageWindSpeed = 19.8f,
            FogDaysRatio = 1f/DaysInMonthNovember,
            DayLengthAverage = 10.4f,
          },
          new MonthlyClimateData() // December
          {
            TemperatureAverage = 3.4f,
            TemperatureHighAverage = 6.8f, TemperatureLowAverage = 0.1f,
            TemperatureHighest = 23.9f, TemperatureLowest = -25,
            PrecipitationAverage = 91.4f/DaysInMonthDecember,
            PrecipitationDaysRatio = 11f/DaysInMonthDecember,
            AverageWindSpeed = 20.8f,
            FogDaysRatio = 0f/DaysInMonthDecember,
            DayLengthAverage = 9.8f,
          },
        }
      }},

      #endregion USA, New York

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
      //      TemperatureHighAverage = ,
      //      TemperatureLowAverage = ,
      //      TemperatureHighest = ,
      //      TemperatureLowest = ,
      //      PrecipitationAverage = f/DaysInMonthJanuary,
      //      PrecipitationDaysRatio = f/DaysInMonthJanuary,
      //      AverageWindSpeed = ,
      //      FogDaysRatio = f/DaysInMonthJanuary,
      //      DayLengthAverage = f,
      //    },
      //    new MonthlyClimateData() // February
      //    {
      //      TemperatureAverage = ,
      //      TemperatureHighAverage = ,
      //      TemperatureLowAverage = ,
      //      TemperatureHighest = ,
      //      TemperatureLowest = ,
      //      PrecipitationAverage = f/DaysInMonthFebruary,
      //      PrecipitationDaysRatio = f/DaysInMonthFebruary,
      //      AverageWindSpeed = ,
      //      FogDaysRatio = f/DaysInMonthFebruary,
      //      DayLengthAverage = f,
      //    },
      //    new MonthlyClimateData() // March
      //    {
      //      TemperatureAverage = ,
      //      TemperatureHighAverage = ,
      //      TemperatureLowAverage = ,
      //      TemperatureHighest = ,
      //      TemperatureLowest = ,
      //      PrecipitationAverage = f/DaysInMonthMarch,
      //      PrecipitationDaysRatio = f/DaysInMonthMarch,
      //      AverageWindSpeed = ,
      //      FogDaysRatio = f/DaysInMonthMarch,
      //      DayLengthAverage = f,
      //    },
      //    new MonthlyClimateData() // April
      //    {
      //      TemperatureAverage = ,
      //      TemperatureHighAverage = ,
      //      TemperatureLowAverage = ,
      //      TemperatureHighest = ,
      //      TemperatureLowest = ,
      //      PrecipitationAverage = f/DaysInMonthApril,
      //      PrecipitationDaysRatio = f/DaysInMonthApril,
      //      AverageWindSpeed = ,
      //      FogDaysRatio = f/DaysInMonthApril,
      //      DayLengthAverage = f,
      //    },
      //    new MonthlyClimateData() // May
      //    {
      //      TemperatureAverage = ,
      //      TemperatureHighAverage = ,
      //      TemperatureLowAverage = ,
      //      TemperatureHighest = ,
      //      TemperatureLowest = ,
      //      PrecipitationAverage = f/DaysInMonthMay,
      //      PrecipitationDaysRatio = f/DaysInMonthMay,
      //      AverageWindSpeed = ,
      //      FogDaysRatio = f/DaysInMonthMay,
      //      DayLengthAverage = f,
      //    },
      //    new MonthlyClimateData() // June
      //    {
      //      TemperatureAverage = ,
      //      TemperatureHighAverage = ,
      //      TemperatureLowAverage = ,
      //      TemperatureHighest = ,
      //      TemperatureLowest = ,
      //      PrecipitationAverage = f/DaysInMonthJune,
      //      PrecipitationDaysRatio = f/DaysInMonthJune,
      //      AverageWindSpeed = ,
      //      FogDaysRatio = f/DaysInMonthJune,
      //      DayLengthAverage = f,
      //    },
      //    new MonthlyClimateData() // July
      //    {
      //      TemperatureAverage = ,
      //      TemperatureHighAverage = ,
      //      TemperatureLowAverage = ,
      //      TemperatureHighest = ,
      //      TemperatureLowest = ,
      //      PrecipitationAverage = f/DaysInMonthJuly,
      //      PrecipitationDaysRatio = f/DaysInMonthJuly,
      //      AverageWindSpeed = ,
      //      FogDaysRatio = f/DaysInMonthJuly,
      //      DayLengthAverage = f,
      //    },
      //    new MonthlyClimateData() // August
      //    {
      //      TemperatureAverage = ,
      //      TemperatureHighAverage = ,
      //      TemperatureLowAverage = ,
      //      TemperatureHighest = ,
      //      TemperatureLowest = ,
      //      PrecipitationAverage = f/DaysInMonthAugust,
      //      PrecipitationDaysRatio = f/DaysInMonthAugust,
      //      AverageWindSpeed = ,
      //      FogDaysRatio = f/DaysInMonthAugust,
      //      DayLengthAverage = f,
      //    },
      //    new MonthlyClimateData() // September
      //    {
      //      TemperatureAverage = ,
      //      TemperatureHighAverage = ,
      //      TemperatureLowAverage = ,
      //      TemperatureHighest = ,
      //      TemperatureLowest = ,
      //      PrecipitationAverage = f/DaysInMonthSeptember,
      //      PrecipitationDaysRatio = f/DaysInMonthSeptember,
      //      AverageWindSpeed = ,
      //      FogDaysRatio = f/DaysInMonthSeptember,
      //      DayLengthAverage = f,
      //    },
      //    new MonthlyClimateData() // October
      //    {
      //      TemperatureAverage = ,
      //      TemperatureHighAverage = ,
      //      TemperatureLowAverage = ,
      //      TemperatureHighest = ,
      //      TemperatureLowest = ,
      //      PrecipitationAverage = f/DaysInMonthOctober,
      //      PrecipitationDaysRatio = f/DaysInMonthOctober,
      //      AverageWindSpeed = ,
      //      FogDaysRatio = f/DaysInMonthOctober,
      //      DayLengthAverage = f,
      //    },
      //    new MonthlyClimateData() // November
      //    {
      //      TemperatureAverage = ,
      //      TemperatureHighAverage = ,
      //      TemperatureLowAverage = ,
      //      TemperatureHighest = ,
      //      TemperatureLowest = ,
      //      PrecipitationAverage = f/DaysInMonthNovember,
      //      PrecipitationDaysRatio = f/DaysInMonthNovember,
      //      AverageWindSpeed = ,
      //      FogDaysRatio = f/DaysInMonthNovember,
      //      DayLengthAverage = f,
      //    },
      //    new MonthlyClimateData() // December
      //    {
      //      TemperatureAverage = ,
      //      TemperatureHighAverage = ,
      //      TemperatureLowAverage = ,
      //      TemperatureHighest = ,
      //      TemperatureLowest = ,
      //      PrecipitationAverage = f/DaysInMonthDecember,
      //      PrecipitationDaysRatio = f/DaysInMonthDecember,
      //      AverageWindSpeed = ,
      //      FogDaysRatio = f/DaysInMonthDecember,
      //      DayLengthAverage = f,
      //    },
      //  }
      //}},

      #endregion Empty Pattern to use
    };
  }
}