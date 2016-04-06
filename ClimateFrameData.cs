using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Runaurufu.ClimateControl
{
  public class ClimateFrameData
  {
    /// <summary>
    /// 
    /// </summary>
    public float YearProgressStart { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public float YearProgressEnd { get; set; }
    /// <summary>
    /// How many days in year this frame occupies
    /// </summary>
    public float YearProgressLength
    {
      get { return this.YearProgressEnd - this.YearProgressStart; }
    }

    public float YearProgressDayLength
    {
      get { return this.YearProgressLength * 366f; }
    }

    // Temperature

    /// <summary>
    /// [C]
    /// </summary>
    public float TemperatureHighest { get; set; }
    public float TemperatureHighAverage { get; set; }
    public float TemperatureAverage { get; set; }
    public float TemperatureLowAverage { get; set; }
    public float TemperatureLowest { get; set; }

    // Precipitation: Rainfall & Snowfall

    /// <summary>
    /// [mm / day]
    /// </summary>
    public float PrecipitationAverage { get; set; }
    /// <summary>
    /// 0 - no rain/snow, 1 - rain/snow all time
    /// </summary>
    public float PrecipitationDaysRatio { get; set; }

    // Wind

    /// <summary>
    /// [km / h]
    /// </summary>
    public float AverageWindSpeed { get; set; }

    // Fog

    /// <summary>
    /// 0 - no fog, 1 - fog all time
    /// </summary>
    public float FogDaysRatio { get; set; }

    // Solar

    /// <summary>
    /// [h]
    /// </summary>
    public float DayLengthAverage { get; set; }

    public ClimateFrameData() { }

    public ClimateFrameData(MonthlyClimateData data, float start, float end, float solarDayLength)
    {
      this.YearProgressStart = start;
      this.YearProgressEnd = end;

      this.TemperatureHighest = data.TemperatureHighest;
      this.TemperatureHighAverage = data.TemperatureHighest;
      this.TemperatureAverage = data.TemperatureAverage;
      this.TemperatureLowAverage = data.TemperatureLowAverage;
      this.TemperatureLowest = data.TemperatureLowest;

      this.PrecipitationAverage = data.PrecipitationAverage;
      this.PrecipitationDaysRatio = data.PrecipitationDaysRatio;

      this.AverageWindSpeed = data.AverageWindSpeed;

      this.FogDaysRatio = data.FogDaysRatio;

      this.DayLengthAverage = data.DayLengthAverage;

      this.FixNaNData(solarDayLength);
    }

    private void FixNaNData(float solarDayLength)
    {
      // DayLength
      if (float.IsNaN(this.DayLengthAverage))
        this.DayLengthAverage = solarDayLength * 0.5f;

      float dayLengthRatio = this.DayLengthAverage / solarDayLength;

      // Temperatures
      bool isNanTH = float.IsNaN(this.TemperatureHighest);
      bool isNanTHA = float.IsNaN(this.TemperatureHighAverage);
      bool isNanTA = float.IsNaN(this.TemperatureAverage);
      bool isNanTLA = float.IsNaN(this.TemperatureLowAverage);
      bool isNanTL = float.IsNaN(this.TemperatureLowest);

      if (isNanTH && isNanTHA && isNanTA && isNanTLA && isNanTL)
      {
        // that kind of sucks
        this.TemperatureHighest = 20;
        this.TemperatureHighAverage = 15;
        this.TemperatureAverage = 10;
        this.TemperatureLowAverage = 0;
        this.TemperatureLowest = -10;
      }
      else if (isNanTH || isNanTHA || isNanTA || isNanTLA || isNanTL)
      {
        if (isNanTA)
        {
          if (isNanTHA == false && isNanTLA == false)
          {
            this.TemperatureAverage = this.TemperatureHighAverage * dayLengthRatio + this.TemperatureLowAverage * (1 - dayLengthRatio);
            isNanTA = false;
          }
          else if (isNanTHA && isNanTLA)
          {
            if (isNanTH == false && isNanTL == false)
            {
              this.TemperatureAverage = this.TemperatureHighest * dayLengthRatio + this.TemperatureLowest * (1 - dayLengthRatio);
              isNanTA = false;
            }
            else if (isNanTH == false)
            {
              this.TemperatureAverage = this.TemperatureHighest > 0 ? this.TemperatureHighest * 0.6f : (this.TemperatureHighest - 10);
              isNanTA = false;
            }
            else //if(isNanTL == false)
            {
              this.TemperatureAverage = this.TemperatureLowest < 0 ? this.TemperatureLowest * 0.6f : (this.TemperatureLowest + 10);
              isNanTA = false;
            }
          }
          else
          {
            if (isNanTH == false && isNanTL == false)
            {
              if (isNanTHA)
                this.TemperatureAverage = this.TemperatureLowAverage + 5;
              else
                this.TemperatureAverage = this.TemperatureHighAverage - 5;
              isNanTA = false;
            }
            else if (isNanTH)
            {
              this.TemperatureAverage = this.TemperatureLowAverage + (this.TemperatureLowAverage - this.TemperatureLowest) * 0.5f;
              isNanTA = false;
            }
            else //if(isNanTL)
            {
              this.TemperatureAverage = this.TemperatureHighAverage - (this.TemperatureHighest - this.TemperatureHighAverage) * 0.5f;
              isNanTA = false;
            }
          }
        }

        if (isNanTH)
        {
          if (isNanTL)
          {
            if (isNanTHA)
              this.TemperatureHighest = this.TemperatureAverage + 15;
            else
              this.TemperatureHighest = this.TemperatureAverage + 2 * (this.TemperatureHighAverage - this.TemperatureAverage);
            isNanTH = false;
          }
          else
          {
            if (isNanTHA && isNanTLA)
              this.TemperatureHighest = this.TemperatureAverage + (this.TemperatureAverage - this.TemperatureLowest);
            else if(isNanTHA == false && isNanTLA == false)
            {
              float f1 = this.TemperatureAverage - this.TemperatureLowAverage;
              float f2 = this.TemperatureLowAverage - this.TemperatureLowest;
              float f3 = this.TemperatureHighAverage - this.TemperatureAverage;

              if(f3 > f1)
              {
                if (f3 > f2)
                  this.TemperatureHighest = this.TemperatureHighAverage + 2 * f3;
                else
                  this.TemperatureHighest = this.TemperatureHighAverage + f2;
              }
              else
              {
                this.TemperatureHighest = this.TemperatureHighAverage + f2;
              }
            }
            else if(isNanTHA)
            {
              this.TemperatureHighest = this.TemperatureAverage + (this.TemperatureAverage - this.TemperatureLowest);
            }
            else //if(isNanTLA)
            {
              float f1 = this.TemperatureAverage - this.TemperatureLowest;
              float f2 = this.TemperatureHighAverage - this.TemperatureAverage;

              if(f2 < f1)
                this.TemperatureHighest = this.TemperatureHighAverage + f1;
              else
                this.TemperatureHighest = this.TemperatureHighAverage + 2 * f2;
            }
            isNanTH = false;
          }
        }

        if (isNanTL)
        {
          if (isNanTLA)
            this.TemperatureLowest = this.TemperatureAverage - (this.TemperatureHighest - this.TemperatureAverage);
          else
          {
            if(isNanTHA)
              this.TemperatureLowest = this.TemperatureLowAverage - (this.TemperatureHighest - this.TemperatureAverage) * 0.5f;
            else
              this.TemperatureLowest = this.TemperatureLowAverage - (this.TemperatureHighest - this.TemperatureHighAverage);
          }
          isNanTL = false;
        }
       
        if(isNanTHA)
        {
          this.TemperatureHighAverage = this.TemperatureHighest * 0.33f + this.TemperatureAverage * 0.66f;
          isNanTHA = false;
        }

        if(isNanTLA)
        {
          this.TemperatureLowAverage = this.TemperatureLowest * 0.33f + this.TemperatureAverage * 0.66f;
          isNanTLA = false;
        }
      }

      // Precipitation

      bool isNanPA = float.IsNaN(this.PrecipitationAverage);
      bool isNanPDR = float.IsNaN(this.PrecipitationDaysRatio);

      if(isNanPA && isNanPDR)
      {
        this.PrecipitationAverage = 3.5f;
        this.PrecipitationDaysRatio = 0.15f;
      }
      else if(isNanPA)
      {
        this.PrecipitationAverage = solarDayLength * 4f * this.PrecipitationDaysRatio;
      }
      else if(isNanPDR)
      {
        this.PrecipitationDaysRatio = Mathf.Clamp01(this.PrecipitationAverage / 120f);
      }

      // Wind
      if (float.IsNaN(this.AverageWindSpeed))
        this.AverageWindSpeed = 15f;

      // Fog
      if (float.IsNaN(this.FogDaysRatio))
        this.FogDaysRatio = 0.15f;
    }

    public static void CreateSmoothingFrames(MonthlyClimateData data1, MonthlyClimateData data2, float solarDayLength, out ClimateFrameData data1EndSmooth, out ClimateFrameData data2StartSmooth)
    {
      data1EndSmooth = new ClimateFrameData();
      data2StartSmooth = new ClimateFrameData();

      float factor1 = 0.6f, factor2 = 0.4f;

      data1EndSmooth.TemperatureHighest = data1.TemperatureHighest * factor1 + data2.TemperatureHighest * factor2;
      data1EndSmooth.TemperatureHighAverage = data1.TemperatureHighAverage * factor1 + data2.TemperatureHighAverage * factor2;
      data1EndSmooth.TemperatureAverage = data1.TemperatureAverage * factor1 + data2.TemperatureAverage * factor2;
      data1EndSmooth.TemperatureLowAverage = data1.TemperatureLowAverage * factor1 + data2.TemperatureLowAverage * factor2;
      data1EndSmooth.TemperatureLowest = data1.TemperatureLowest * factor1 + data2.TemperatureLowest * factor2;

      data1EndSmooth.PrecipitationAverage = data1.PrecipitationAverage * factor1 + data2.PrecipitationAverage * factor2;
      data1EndSmooth.PrecipitationDaysRatio = data1.PrecipitationDaysRatio * factor1 + data2.PrecipitationDaysRatio * factor2;

      data1EndSmooth.AverageWindSpeed = data1.AverageWindSpeed * factor1 + data2.AverageWindSpeed * factor2;

      data1EndSmooth.FogDaysRatio = data1.FogDaysRatio * factor1 + data2.FogDaysRatio * factor2;

      data1EndSmooth.DayLengthAverage = data1.DayLengthAverage * factor1 + data2.DayLengthAverage * factor2;

      data1EndSmooth.FixNaNData(solarDayLength);

      factor1 = 0.4f;
      factor2 = 0.6f;

      data2StartSmooth.TemperatureHighest = data1.TemperatureHighest * factor1 + data2.TemperatureHighest * factor2;
      data2StartSmooth.TemperatureHighAverage = data1.TemperatureHighAverage * factor1 + data2.TemperatureHighAverage * factor2;
      data2StartSmooth.TemperatureAverage = data1.TemperatureAverage * factor1 + data2.TemperatureAverage * factor2;
      data2StartSmooth.TemperatureLowAverage = data1.TemperatureLowAverage * factor1 + data2.TemperatureLowAverage * factor2;
      data2StartSmooth.TemperatureLowest = data1.TemperatureLowest * factor1 + data2.TemperatureLowest * factor2;

      data2StartSmooth.PrecipitationAverage = data1.PrecipitationAverage * factor1 + data2.PrecipitationAverage * factor2;
      data2StartSmooth.PrecipitationDaysRatio = data1.PrecipitationDaysRatio * factor1 + data2.PrecipitationDaysRatio * factor2;

      data2StartSmooth.AverageWindSpeed = data1.AverageWindSpeed * factor1 + data2.AverageWindSpeed * factor2;

      data2StartSmooth.FogDaysRatio = data1.FogDaysRatio * factor1 + data2.FogDaysRatio * factor2;

      data2StartSmooth.DayLengthAverage = data1.DayLengthAverage * factor1 + data2.DayLengthAverage * factor2;

      data2StartSmooth.FixNaNData(solarDayLength);
    }
  }
}
