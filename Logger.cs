using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Runaurufu.ClimateControl
{
  public static class Logger
  {
    private static readonly string LogFileName = GlobalConfig.ConfigName + ".log";

    public static void Log(string message)
    {
      File.AppendAllText(LogFileName, message + Environment.NewLine);
    }
  }
}
