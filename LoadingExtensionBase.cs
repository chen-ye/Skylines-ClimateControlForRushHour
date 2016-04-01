using ColossalFramework;
using ColossalFramework.UI;
using ICities;
using Runaurufu.ClimateControl.UI;
using Runaurufu.Utility;
using UnityEngine;

namespace Runaurufu.ClimateControl
{
  public class ClimateControlLoading : LoadingExtensionBase
  {
    private WeatherUI weatherUI = null;

    public void AddGUIToggle()
    {
      UIButton toggle = UIFactory.CreateButton(GameObject.Find("ZoomButton").GetComponent<UIMultiStateButton>().parent);

      toggle.area = new Vector4(12f, -50f, 38f, 38f);
      // toggle.width = 38f;
      // toggle.height = 38f;
      toggle.playAudioEvents = true;
      toggle.normalBgSprite = "OptionBase";
      toggle.focusedBgSprite = "OptionBaseFocus";
      toggle.hoveredBgSprite = "OptionBaseHover";
      toggle.pressedBgSprite = "OptionBasePressed";
      toggle.normalFgSprite = "InfoIconEntertainmentDisabled";
      toggle.tooltip = "Climate Control";
      toggle.scaleFactor = 0.75f;
      toggle.eventClicked += (MouseEventHandler)((component, eventParam) =>
      {
        if (this.weatherUI.isVisible)
          this.weatherUI.Hide();
        else
          this.weatherUI.Show();

       // bool flag = !this.weatherUI.gameObject.active;
        toggle.normalBgSprite = this.weatherUI.isVisible ? "OptionBasePressed" : "OptionBase";
        //this.weatherUI.gameObject.SetActive(flag);
      });
    }

    public void CreateControlPanels()
    {
     // this.weatherUI = new GameObject("WeatherUI").AddComponent<WeatherUI>();
      this.weatherUI = UIView.GetAView().AddUIComponent(typeof(WeatherUI)) as WeatherUI;
    //  this.weatherUI.anchor = UIAnchorStyle.Left;

    //  UIView.GetAView().AttachUIComponent(this.weatherUI.gameObject);
      this.weatherUI.isVisible = false;
      //this.weatherUI.gameObject.SetActive(false);
    }

    public override void OnLevelLoaded(LoadMode mode)
    {      
      base.OnLevelLoaded(mode);

      if (mode != LoadMode.LoadGame && mode != LoadMode.NewGame)
        return;

      //Logger.Log(this.loadingManager.currentTheme);
      //this.loadingManager.currentTheme = "Tropical";

      WeatherManager wm = Singleton<WeatherManager>.instance;
      if (wm == null)
        return;

      GlobalConfig.LoadConfig();

      ClimatePreset presetToUse = ModSettings.CurrentClimatePreset;

      if (presetToUse.PresetCode == ModSettings.COMPANION_PRESET_CODE)
      {
        // Other mod will handle climate initialization!
      }
      else if (presetToUse.PresetCode == ModSettings.DEFAULT_PRESET_CODE)
      {
        if (ClimateControlEngine.Instance.IsInitialized == false)
          ClimateControlEngine.Instance.Initialize(ClimateControlEngine.GetDefaultWeatherProperites());
      }
      else
      {
        ClimateControlEngine.Instance.Initialize(presetToUse.ClimateProperties);
      }

      this.AddGUIToggle();
      this.CreateControlPanels();
    }

    public override void OnLevelUnloading()
    {
      base.OnLevelUnloading();

      ClimateControlEngine.Instance.Uninitialize();
    }
  }
}
