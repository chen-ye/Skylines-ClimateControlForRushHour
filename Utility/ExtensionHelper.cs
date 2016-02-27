using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Runaurufu.Utility
{
  static class ExtensionHelper
  {
    public static object InvokeMethod(this object obj, string name, params object[] parameters)
    {
      Type t = obj.GetType();
      MethodInfo method = t.GetMethod(name, BindingFlags.Instance | BindingFlags.NonPublic);
      if(method == null)
      {
        DebugOutputPanel.AddMessage(ColossalFramework.Plugins.PluginManager.MessageType.Error, string.Format("Invoke failed! (method {0} not found in type {1})", name, t.Name));
        return null;
      }

      try
      {
        return method.Invoke(obj, parameters);
      }
      catch(Exception ex)
      {
        DebugOutputPanel.AddMessage(ColossalFramework.Plugins.PluginManager.MessageType.Error, string.Format("Invoke failed (method {0} in type {1}) with message: {2}", name, t.Name, ex.Message));
        DebugOutputPanel.AddMessage(ColossalFramework.Plugins.PluginManager.MessageType.Error, ex.ToString());
        return null;
      }
    }

    public static void SetFieldValue(this object obj, string name, object value)
    {
      Type t = obj.GetType();
      FieldInfo field = t.GetField(name, BindingFlags.NonPublic | BindingFlags.Instance);

      if (field == null)
      {
        DebugOutputPanel.AddMessage(ColossalFramework.Plugins.PluginManager.MessageType.Error, string.Format("SetFieldValue failed! (field {0} not found in type {1})", name, t.Name));
        return;
      }

      try
      {
        field.SetValue(obj, value);

      }
      catch (Exception ex)
      {
        DebugOutputPanel.AddMessage(ColossalFramework.Plugins.PluginManager.MessageType.Error, string.Format("SetFieldValue failed (field {0} in type {1}) with message: {2} ", name, t.Name, ex.Message));
        return;
      }
    }

    public static object GetFieldValue(this object obj, string name)
    {
      Type t = obj.GetType();
      FieldInfo field = t.GetField(name, BindingFlags.NonPublic | BindingFlags.Instance);

      if (field == null)
      {
        DebugOutputPanel.AddMessage(ColossalFramework.Plugins.PluginManager.MessageType.Error, string.Format("GetFieldValue failed! (field {0} not found in type {1})", name, t.Name));
        return null;
      }

      try
      {
        return field.GetValue(obj);

      }
      catch (Exception ex)
      {
        DebugOutputPanel.AddMessage(ColossalFramework.Plugins.PluginManager.MessageType.Error, string.Format("GetFieldValue failed (field {0} in type {1}) with message {2}", name, t.Name, ex.Message));
        return null;
      }
    }
  }
}
