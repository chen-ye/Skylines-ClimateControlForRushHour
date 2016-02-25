using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICities;

namespace Runaurufu.ClimateControl
{
  public class Mod : IUserMod
  {
    public string Name
    {
      get
      {
        return "Climate Control";
      }
    }

    public string Description
    {
      get
      {
        return "It is master climate control mod for all your climate alternation needs.";
      }
    }

    public void OnSettingsUI(UIHelperBase helper)
    {
      GlobalConfig.LoadConfig();
      UIHelperBase helperBase = helper.AddGroup("Main options");
      //helperBase.AddDropdown("Day/Night Time",
      //  new string[]
      //  { "Sun Time", "Simulation Time", "Workstation Time" },
      //  ModSettings.CurrentSimulationTimeIndex,
      //  ModSettings.CurrentSimulationTimeIndexChanged);
      helperBase.AddCheckbox("Chirp forecast", GlobalConfig.GetInstance().ChirpForecast, ModSettings.ChirpForecastOnCheckChanged);
      helperBase.AddCheckbox("SnowDump snow melting when hot", GlobalConfig.GetInstance().AlterSnowDumpSnowMelting, ModSettings.AlterSnowDumpSnowMeltingOnCheckChanged);
    //  helperBase.AddCheckbox("Weather alter building fires", GlobalConfig.GetInstance().WeatherAlterFires, ModSettings.WeatherAlterFiresOnCheckChanged);

      helper.AddGroup("Climate Presets").AddDropdown("Climate presets",
        ModSettings.AllPresets.Select(p => p.PresetName).ToArray(),
        ModSettings.CurrentClimatePresetIndex,
        ModSettings.ClimatePresetIndexChanged);
    }
  }

  internal static partial class ModSettings
  {
    //public static int CurrentSimulationTimeIndex
    //{
    //  get
    //  {
    //    switch(GlobalConfig.GetInstance().TimeToUse)
    //    {
    //      case GlobalConfig.TimeType.SimulationTime:
    //        return 1;
    //      case GlobalConfig.TimeType.RealTime:
    //        return 2;
    //      case GlobalConfig.TimeType.SunTime:
    //      default:
    //        return 0;
    //    }
    //  }
    //}

    //public static void CurrentSimulationTimeIndexChanged(int newIndex)
    //{
    //  if (newIndex < 0)
    //    return;

    //  switch (newIndex)
    //  {
    //    case 2:
    //      GlobalConfig.GetInstance().TimeToUse = GlobalConfig.TimeType.RealTime;
    //      break;
    //    case 1:
    //      GlobalConfig.GetInstance().TimeToUse = GlobalConfig.TimeType.SimulationTime;
    //      break;
    //    case 0:
    //    default:
    //      GlobalConfig.GetInstance().TimeToUse = GlobalConfig.TimeType.SunTime;
    //      break;
    //  }
    //  GlobalConfig.SaveConfig();
    //}

    public static void ChirpForecastOnCheckChanged(bool isChecked)
    {
      GlobalConfig.GetInstance().ChirpForecast = isChecked;
      GlobalConfig.SaveConfig();
    }

    public static void AlterSnowDumpSnowMeltingOnCheckChanged(bool isChecked)
    {
      GlobalConfig.GetInstance().AlterSnowDumpSnowMelting = isChecked;
      GlobalConfig.SaveConfig();
    }

    //public static void WeatherAlterFiresOnCheckChanged(bool isChecked)
    //{
    //  GlobalConfig.GetInstance().WeatherAlterFires = isChecked;
    //  GlobalConfig.SaveConfig();
    //}

    public static int CurrentClimatePresetIndex
    {
      get
      {
        string presetCode = GlobalConfig.GetInstance().SelectedClimatePresetCode;
        if (string.IsNullOrEmpty(presetCode))
          return 0;

        int index = Array.FindIndex(AllPresets, p => p.PresetCode == presetCode);
        if (index == -1)
          return 0;
        return index;
      }
    }

    public static ClimatePreset CurrentClimatePreset
    {
      get
      {
        string presetCode = GlobalConfig.GetInstance().SelectedClimatePresetCode;
        ClimatePreset ret = null;
        if (string.IsNullOrEmpty(presetCode) == false)
          ret = AllPresets.FirstOrDefault(p => p.PresetCode == presetCode);

        if (ret == null)
          ret = AllPresets.First(p => p.PresetCode == DEFAULT_PRESET_CODE);

        return ret;
      }
    }

    public static void ClimatePresetIndexChanged(int newIndex)
    {
      if (newIndex < 0 || newIndex >= AllPresets.Length)
        return;

      ClimatePreset selectedPreset = AllPresets[newIndex];

      GlobalConfig.GetInstance().SelectedClimatePresetCode = selectedPreset.PresetCode;
      GlobalConfig.SaveConfig();

      if (selectedPreset.PresetCode == ModSettings.COMPANION_PRESET_CODE)
      {
        // Other mod should handle climate data. Nothing to do here.
        ClimateControlEngine.Instance.Uninitialize();
      }
      else if (selectedPreset.PresetCode == ModSettings.DEFAULT_PRESET_CODE)
      {
        // Revert to default settings?
        ClimateControlEngine.Instance.Initialize(ClimateControlEngine.GetDefaultWeatherProperites());
      }
      else
      {
        ClimateControlEngine.Instance.Initialize(selectedPreset.ClimateProperties);
      }
    }

    public const string DEFAULT_PRESET_CODE = "__DEFAULT__";
    public const string CUSTOM_PRESET_CODE = "__CUSTOM__";
    public const string COMPANION_PRESET_CODE = "__THIRD_PARTY__";
  }

}
