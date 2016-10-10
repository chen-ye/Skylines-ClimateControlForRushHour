using ColossalFramework.UI;
using UnityEngine;

namespace Runaurufu.Utility
{
  public class UIFactory
  {
    public static UITextureAtlas[] s_atlases;

    public static UIButton CreateButton(UIComponent parent)
    {
      UIButton uiButton = parent.AddUIComponent<UIButton>();
      uiButton.size = new Vector2(90f, 30f);
      uiButton.textScale = 0.9f;
      uiButton.normalBgSprite = "ButtonMenu";
      uiButton.hoveredBgSprite = "ButtonMenuHovered";
      uiButton.pressedBgSprite = "ButtonMenuPressed";
      uiButton.disabledBgSprite = "ButtonMenuDisabled";
      uiButton.disabledTextColor = new Color32(byte.MaxValue/*(byte)sbyte.MinValue*/, byte.MaxValue/*(byte)sbyte.MinValue*/, byte.MaxValue/*(byte)sbyte.MinValue*/, byte.MaxValue);
      uiButton.canFocus = false;
      return uiButton;
    }

    public static UISlider CreateSlider(UIPanel parent, float min, float max)
    {
      UIPanel uiPanel = parent.AddUIComponent<UIPanel>();
      uiPanel.backgroundSprite = "ChirpScrollbarTrack";
      uiPanel.size = new Vector2(parent.width - (float)(parent.autoLayoutPadding.left * 2), 17f);
      UISlider uiSlider = uiPanel.AddUIComponent<UISlider>();
      uiSlider.area = new Vector4(8f, 0.0f, uiPanel.width - 16f, 15f);
      uiSlider.height = 17f;
      uiSlider.autoSize = false;
      uiSlider.maxValue = max;
      uiSlider.minValue = min;
      uiSlider.fillPadding = new RectOffset(10, 10, 0, 0);
      UISprite uiSprite = uiSlider.AddUIComponent<UISprite>();
      uiSprite.size = new Vector2(16f, 16f);
      uiSprite.position = (Vector3)new Vector2(0.0f, 0.0f);
      uiSprite.spriteName = "ToolbarIconZoomOutGlobeDisabled";
      uiSlider.value = 0.0f;
      uiSlider.thumbObject = (UIComponent)uiSprite;
      return uiSlider;
    }

    public static UICheckBox CreateCheckBox(UIComponent parent)
    {
      UICheckBox uiCheckBox = parent.AddUIComponent<UICheckBox>();
      uiCheckBox.width = parent.width;
      uiCheckBox.height = 20f;
      uiCheckBox.clipChildren = true;
      UISprite uiSprite = uiCheckBox.AddUIComponent<UISprite>();
      uiSprite.spriteName = "ToggleBase";
      uiSprite.size = new Vector2(16f, 16f);
      uiSprite.relativePosition = Vector3.zero;
      uiCheckBox.checkedBoxObject = (UIComponent)uiSprite.AddUIComponent<UISprite>();
      ((UISprite)uiCheckBox.checkedBoxObject).spriteName = "ToggleBaseFocused";
      uiCheckBox.checkedBoxObject.size = new Vector2(16f, 16f);
      uiCheckBox.checkedBoxObject.relativePosition = Vector3.zero;
      uiCheckBox.label = uiCheckBox.AddUIComponent<UILabel>();
      uiCheckBox.label.text = " ";
      uiCheckBox.label.textScale = 0.9f;
      uiCheckBox.label.relativePosition = new Vector3(22f, 2f);
      return uiCheckBox;
    }

    public static UICheckBox CreateIconToggle(UIComponent parent, string atlas, string checkedSprite, string uncheckedSprite)
    {
      UICheckBox checkBox = parent.AddUIComponent<UICheckBox>();
      checkBox.width = 35f;
      checkBox.height = 35f;
      checkBox.clipChildren = true;
      UIPanel panel = checkBox.AddUIComponent<UIPanel>();
      panel.backgroundSprite = "IconPolicyBaseRect";
      panel.size = checkBox.size;
      panel.relativePosition = Vector3.zero;
      checkBox.eventCheckChanged += (PropertyChangedEventHandler<bool>)((c, b) =>
      {
        panel.backgroundSprite = !checkBox.isChecked ? "IconPolicyBaseRectDisabled" : "IconPolicyBaseRect";
        panel.Invalidate();
      });
      checkBox.eventMouseEnter += (MouseEventHandler)((c, p) => panel.backgroundSprite = "IconPolicyBaseRectHovered");
      checkBox.eventMouseLeave += (MouseEventHandler)((c, p) =>
      {
        if (checkBox.isChecked)
          panel.backgroundSprite = "IconPolicyBaseRect";
        else
          panel.backgroundSprite = "IconPolicyBaseRectDisabled";
      });
      UISprite uiSprite = panel.AddUIComponent<UISprite>();
      uiSprite.atlas = UIFactory.GetAtlas(atlas);
      uiSprite.spriteName = uncheckedSprite;
      uiSprite.size = checkBox.size;
      uiSprite.relativePosition = Vector3.zero;
      checkBox.checkedBoxObject = (UIComponent)uiSprite.AddUIComponent<UISprite>();
      ((UISprite)checkBox.checkedBoxObject).atlas = uiSprite.atlas;
      ((UISprite)checkBox.checkedBoxObject).spriteName = checkedSprite;
      checkBox.checkedBoxObject.size = checkBox.size;
      checkBox.checkedBoxObject.relativePosition = Vector3.zero;
      return checkBox;
    }

    public static UITextField CreateTextField(UIComponent parent)
    {
      UITextField uiTextField = parent.AddUIComponent<UITextField>();
      uiTextField.size = new Vector2(90f, 20f);
      uiTextField.padding = new RectOffset(6, 6, 3, 3);
      uiTextField.builtinKeyNavigation = true;
      uiTextField.isInteractive = true;
      uiTextField.readOnly = false;
      uiTextField.horizontalAlignment = UIHorizontalAlignment.Center;
      uiTextField.selectionSprite = "EmptySprite";
      uiTextField.selectionBackgroundColor = new Color32((byte)0, (byte)172, (byte)234, byte.MaxValue);
      uiTextField.normalBgSprite = "TextFieldPanelHovered";
      uiTextField.disabledBgSprite = "TextFieldPanel";
      uiTextField.textColor = new Color32((byte)0, (byte)0, (byte)0, byte.MaxValue);
      uiTextField.disabledTextColor = new Color32((byte)0, (byte)0, (byte)0, byte.MaxValue/*(byte)sbyte.MinValue*/);
      uiTextField.color = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
      return uiTextField;
    }

    public static UIDropDown CreateDropDown(UIComponent parent)
    {
      UIDropDown dropDown = parent.AddUIComponent<UIDropDown>();
      dropDown.size = new Vector2(90f, 30f);
      dropDown.listBackground = "GenericPanelLight";
      dropDown.itemHeight = 30;
      dropDown.itemHover = "ListItemHover";
      dropDown.itemHighlight = "ListItemHighlight";
      dropDown.normalBgSprite = "ButtonMenu";
      dropDown.disabledBgSprite = "ButtonMenuDisabled";
      dropDown.hoveredBgSprite = "ButtonMenuHovered";
      dropDown.focusedBgSprite = "ButtonMenu";
      dropDown.listWidth = 90;
      dropDown.listHeight = 500;
      dropDown.foregroundSpriteMode = UIForegroundSpriteMode.Stretch;
      dropDown.popupColor = new Color32((byte)45, (byte)52, (byte)61, byte.MaxValue);
      dropDown.popupTextColor = new Color32((byte)170, (byte)170, (byte)170, byte.MaxValue);
      dropDown.zOrder = 1;
      dropDown.textScale = 0.8f;
      dropDown.verticalAlignment = UIVerticalAlignment.Middle;
      dropDown.horizontalAlignment = UIHorizontalAlignment.Left;
      dropDown.selectedIndex = 0;
      dropDown.textFieldPadding = new RectOffset(8, 0, 8, 0);
      dropDown.itemPadding = new RectOffset(14, 0, 8, 0);
      UIButton button = dropDown.AddUIComponent<UIButton>();
      dropDown.triggerButton = (UIComponent)button;
      button.text = "";
      button.size = dropDown.size;
      button.relativePosition = new Vector3(0.0f, 0.0f);
      button.textVerticalAlignment = UIVerticalAlignment.Middle;
      button.textHorizontalAlignment = UIHorizontalAlignment.Left;
      button.normalFgSprite = "IconDownArrow";
      button.hoveredFgSprite = "IconDownArrowHovered";
      button.pressedFgSprite = "IconDownArrowPressed";
      button.focusedFgSprite = "IconDownArrowFocused";
      button.disabledFgSprite = "IconDownArrowDisabled";
      button.foregroundSpriteMode = UIForegroundSpriteMode.Fill;
      button.horizontalAlignment = UIHorizontalAlignment.Right;
      button.verticalAlignment = UIVerticalAlignment.Middle;
      button.zOrder = 0;
      button.textScale = 0.8f;
      dropDown.eventSizeChanged += (PropertyChangedEventHandler<Vector2>)((c, t) =>
      {
        button.size = t;
        dropDown.listWidth = (int)t.x;
      });
      return dropDown;
    }

    public static void ResizeIcon(UISprite icon, Vector2 maxSize)
    {
      icon.width = icon.spriteInfo.width;
      icon.height = icon.spriteInfo.height;
      if ((double)icon.height == 0.0)
        return;
      float num = icon.width / icon.height;
      if ((double)icon.width > (double)maxSize.x)
      {
        icon.width = maxSize.x;
        icon.height = maxSize.x / num;
      }
      if ((double)icon.height <= (double)maxSize.y)
        return;
      icon.height = maxSize.y;
      icon.width = maxSize.y * num;
    }

    public static UITextureAtlas GetAtlas(string name)
    {
      if (UIFactory.s_atlases == null)
        UIFactory.s_atlases = Resources.FindObjectsOfTypeAll(typeof(UITextureAtlas)) as UITextureAtlas[];
      for (int index = 0; index < UIFactory.s_atlases.Length; ++index)
      {
        if (UIFactory.s_atlases[index].name == name)
          return UIFactory.s_atlases[index];
      }
      return UIView.GetAView().defaultAtlas;
    }

    public static void TruncateLabel(UILabel label, float maxWidth)
    {
      label.autoSize = true;
      while ((double)label.width > (double)maxWidth)
      {
        label.text = label.text.Substring(0, label.text.Length - 4) + "...";
        label.autoSize = true;
      }
    }
  }
}