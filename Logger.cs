using System;
using System.IO;

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