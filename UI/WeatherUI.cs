using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColossalFramework.UI;
using Runaurufu.Utility;
using UnityEngine;

namespace Runaurufu.ClimateControl.UI
{
  class WeatherUI : UIPanel
  {
    private UILabel temperatureCurrentLabel;
    private UILabel temperatureTargetLabel;

    private UISlider temperatureCurrentSlider;
    private UISlider temperatureTargetSlider;

    private UILabel rainCurrentLabel;
    private UILabel rainTargetLabel;

    private UISlider rainCurrentSlider;
    private UISlider rainTargetSlider;

    private UILabel fogCurrentLabel;
    private UILabel fogTargetLabel;

    private UISlider fogCurrentSlider;
    private UISlider fogTargetSlider;

    private UILabel northernLightsCurrentLabel;
    private UILabel northernLightsTargetLabel;

    private UISlider northernLightsCurrentSlider;
    private UISlider northernLightsTargetSlider;

    private UILabel groundWetnessLabel;

    private UILabel windDirectionLabel;
    private UISlider windDirectionSlider;

    private bool pauseUpdates = false;
    private bool inDragMode = false;
    private Vector2 dragStartMousePosition;
    private Vector2 dragStartPanelPosition;

    public override void Awake()
    {
      this.size = new UnityEngine.Vector2(350f, 950f);
      this.anchor = UIAnchorStyle.Bottom;
      this.backgroundSprite = "ButtonMenu";
      this.autoLayoutPadding = new RectOffset(10, 10, 2, 2);
      this.padding = new RectOffset(0, 0, 0, 5);
      this.autoLayout = true;
      this.autoFitChildrenVertically = true;
      this.autoLayoutDirection = LayoutDirection.Vertical;

      this.temperatureCurrentLabel = this.AddUIComponent<UILabel>();
      this.temperatureCurrentSlider = UIFactory.CreateSlider((UIPanel)this, -500.0f, 500.0f);
      this.temperatureCurrentSlider.eventValueChanged += TemperatureCurrentSlider_eventValueChanged;

      this.temperatureTargetLabel = this.AddUIComponent<UILabel>();
      this.temperatureTargetSlider = UIFactory.CreateSlider((UIPanel)this, -500.0f, 500.0f);
      this.temperatureTargetSlider.eventValueChanged += TemperatureTargetSlider_eventValueChanged;

      this.rainCurrentLabel = this.AddUIComponent<UILabel>();
      this.rainCurrentSlider = UIFactory.CreateSlider((UIPanel)this, 0.0f, 5.0f);
      this.rainCurrentSlider.stepSize = 0.05f;
      this.rainCurrentSlider.eventValueChanged += RainCurrentSlider_eventValueChanged;

      this.rainTargetLabel = this.AddUIComponent<UILabel>();
      this.rainTargetSlider = UIFactory.CreateSlider((UIPanel)this, 0.0f, 5.0f);
      this.rainTargetSlider.stepSize = 0.05f;
      this.rainTargetSlider.eventValueChanged += RainTargetSlider_eventValueChanged;

      this.fogCurrentLabel = this.AddUIComponent<UILabel>();
      this.fogCurrentSlider = UIFactory.CreateSlider((UIPanel)this, 0.0f, 2.0f);
      this.fogCurrentSlider.stepSize = 0.05f;
      this.fogCurrentSlider.eventValueChanged += FogCurrentSlider_eventValueChanged;

      this.fogTargetLabel = this.AddUIComponent<UILabel>();
      this.fogTargetSlider = UIFactory.CreateSlider((UIPanel)this, 0.0f, 2.0f);
      this.fogTargetSlider.stepSize = 0.05f;
      this.fogTargetSlider.eventValueChanged += FogTargetSlider_eventValueChanged;

      this.northernLightsCurrentLabel = this.AddUIComponent<UILabel>();
      this.northernLightsCurrentSlider = UIFactory.CreateSlider((UIPanel)this, 0.0f, 100.0f);
      this.northernLightsCurrentSlider.stepSize = 0.1f;
      this.northernLightsCurrentSlider.eventValueChanged += NorthernLightsCurrentSlider_eventValueChanged;

      this.northernLightsTargetLabel = this.AddUIComponent<UILabel>();
      this.northernLightsTargetSlider = UIFactory.CreateSlider((UIPanel)this, 0.0f, 100.0f);
      this.northernLightsTargetSlider.stepSize = 0.1f;
      this.northernLightsTargetSlider.eventValueChanged += NorthernLightsTargetSlider_eventValueChanged;

      this.groundWetnessLabel = this.AddUIComponent<UILabel>();

      this.windDirectionLabel = this.AddUIComponent<UILabel>();
      this.windDirectionSlider = UIFactory.CreateSlider((UIPanel)this, -180.0f, 180.0f);
      this.windDirectionSlider.stepSize = 0.1f;
      this.windDirectionSlider.eventValueChanged += WindDirectionSlider_eventValueChanged;

      this.position = new Vector3(20f, 300f, 0.0f);
     // this.relativePosition = new Vector3(0.0f,  800f);

      this.eventDragStart += WeatherUI_eventDragStart;
      this.eventMouseDown += WeatherUI_eventMouseDown;
      this.eventMouseUp += WeatherUI_eventMouseUp;
      this.eventMouseLeave += WeatherUI_eventMouseLeave;
      this.eventDragEnd += WeatherUI_eventDragEnd;
      this.eventMouseMove += WeatherUI_eventMouseMove;
    }

    private void WeatherUI_eventMouseDown(UIComponent component, UIMouseEventParameter eventParam)
    {
      if (this.inDragMode == false)
      {
        this.dragStartMousePosition = eventParam.position;
        this.dragStartPanelPosition = this.absolutePosition; 
      }
    }

    private void WeatherUI_eventMouseLeave(UIComponent component, UIMouseEventParameter eventParam)
    {
      this.inDragMode = false;
    }

    private void WeatherUI_eventMouseUp(UIComponent component, UIMouseEventParameter eventParam)
    {
      this.inDragMode = false;
    }

    private void WeatherUI_eventDragStart(UIComponent component, UIDragEventParameter eventParam)
    {
      this.inDragMode = true;
    }

    private void WeatherUI_eventMouseMove(UIComponent component, UIMouseEventParameter eventParam)
    {
      if (this.inDragMode)
      {
        float dx = eventParam.position.x - this.dragStartMousePosition.x;
        float dy = this.dragStartMousePosition.y - eventParam.position.y;

        this.absolutePosition = new Vector3(this.dragStartPanelPosition.x + dx, this.dragStartPanelPosition.y + dy, 0.0f);
      }
    }

    private void WeatherUI_eventDragEnd(UIComponent component, UIDragEventParameter eventParam)
    {
      this.inDragMode = false;
    }

    private void TemperatureCurrentSlider_eventValueChanged(UIComponent component, float value)
    {
      ClimateControlEngine.Instance.CurrentTemperature = value;
    }

    private void TemperatureTargetSlider_eventValueChanged(UIComponent component, float value)
    {
      ClimateControlEngine.Instance.TargetTemperature = value;
    }

    private void TemperatureSpeedSlider_eventValueChanged(UIComponent component, float value)
    {
      ClimateControlEngine.Instance.TemperatureSpeed = value;
    }

    private void RainCurrentSlider_eventValueChanged(UIComponent component, float value)
    {
      ClimateControlEngine.Instance.CurrentRain = value;
    }

    private void RainTargetSlider_eventValueChanged(UIComponent component, float value)
    {
      ClimateControlEngine.Instance.TargetRain = value;
    }

    private void WindDirectionSlider_eventValueChanged(UIComponent component, float value)
    {
      ClimateControlEngine.Instance.WindDirection = value;
    }

    private void NorthernLightsTargetSlider_eventValueChanged(UIComponent component, float value)
    {
      ClimateControlEngine.Instance.TargetNorthernLights = value;
    }

    private void NorthernLightsCurrentSlider_eventValueChanged(UIComponent component, float value)
    {
      ClimateControlEngine.Instance.CurrentNorthernLights = value;
    }

    private void FogTargetSlider_eventValueChanged(UIComponent component, float value)
    {
      ClimateControlEngine.Instance.TargetFog = value;
    }

    private void FogCurrentSlider_eventValueChanged(UIComponent component, float value)
    {
      ClimateControlEngine.Instance.CurrentFog = value;
    }

    public new void Update()
    {
      if (this.pauseUpdates == false && this.inDragMode == false)
      {
        this.temperatureCurrentLabel.text = "Current Temperature " + ClimateControlEngine.Instance.GetLocalizedTemperature(ClimateControlEngine.Instance.CurrentTemperature) + " (" + (ClimateControlEngine.Instance.CurrentTemperature < ClimateControlEngine.Instance.TargetTemperature ? "+" : "-") + ClimateControlEngine.Instance.GetLocalizedTemperature(ClimateControlEngine.Instance.TemperatureSpeed, 4) + ")";
        this.temperatureCurrentSlider.value = ClimateControlEngine.Instance.CurrentTemperature;

        this.temperatureTargetLabel.text = "Target Temperature " + ClimateControlEngine.Instance.GetLocalizedTemperature(ClimateControlEngine.Instance.TargetTemperature);
        this.temperatureTargetSlider.value = ClimateControlEngine.Instance.TargetTemperature;

        this.rainCurrentLabel.text = "Current Rainfall " + ClimateControlEngine.Instance.CurrentRain.ToString("0.00");
        this.rainCurrentSlider.value = ClimateControlEngine.Instance.CurrentRain;

        this.rainTargetLabel.text = "Target Rainfall " + ClimateControlEngine.Instance.TargetRain.ToString("0.00");
        this.rainTargetSlider.value = ClimateControlEngine.Instance.TargetRain;

        this.fogCurrentLabel.text = "Current Fog " + ClimateControlEngine.Instance.CurrentFog.ToString("0.00");
        this.fogCurrentSlider.value = ClimateControlEngine.Instance.CurrentFog;

        this.fogTargetLabel.text = "Target Fog " + ClimateControlEngine.Instance.TargetFog.ToString("0.00");
        this.fogTargetSlider.value = ClimateControlEngine.Instance.TargetFog;

        this.northernLightsCurrentLabel.text = "Current Northern Lights " + ClimateControlEngine.Instance.CurrentNorthernLights.ToString("0.00");
        this.northernLightsCurrentSlider.value = ClimateControlEngine.Instance.CurrentNorthernLights;

        this.northernLightsTargetLabel.text = "Target Northern Lights " + ClimateControlEngine.Instance.TargetNorthernLights.ToString("0.00");
        this.northernLightsTargetSlider.value = ClimateControlEngine.Instance.TargetNorthernLights;

        this.groundWetnessLabel.text = "Ground Wetness " + ClimateControlEngine.Instance.GroundWetness.ToString("0.00");

        this.windDirectionLabel.text = "Wind Direction " + ClimateControlEngine.Instance.WindDirection.ToString("0.00") + " (" + ClimateControlEngine.Instance.DirectionSpeed.ToString("0.0000") + ")";
        this.windDirectionSlider.value = ClimateControlEngine.Instance.WindDirection;
      }
      base.Update();
    }
  }
}
