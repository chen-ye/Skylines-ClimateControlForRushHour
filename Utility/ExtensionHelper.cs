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
      MethodInfo method = t.GetMethod(name);
      if(method == null)
      {
        return null;
      }

      try
      {
        return method.Invoke(obj, parameters);
      }
      catch(Exception ex)
      {
        return null;
      }
    }
  }
}
