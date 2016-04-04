using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Runaurufu.ClimateControl
{
  /// <summary>
  /// What kind of precipitation do you experience?
  /// </summary>
  public enum PrecipitationType : byte
  {
    /// <summary>
    /// Just ordinary rainfall.
    /// </summary>
    Rain = 0,
    /// <summary>
    /// Just ordinary snowfall.
    /// </summary>
    Snow = 1,
  }

  public enum Frequency : int
  {
    AlmostNever = 0,
    Rarely = 1,
    BelowAverage = 2,
    OnAverage = 3,
    AboveAverage = 4,
    Often = 5,
    AlmostConstantly = 6,
  }

  public enum Level : int
  {
    None = 0,
    Low = 1,
    Quarter = 2,
    BelowHalf = 3,
    Half = 4,
    AboveHalf = 5,
    ThreeQuarter = 6,
    High = 7,
    Full = 8,
  }
}
