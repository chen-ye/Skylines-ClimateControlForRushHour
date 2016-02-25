using System;
using ICities;

namespace Runaurufu.ClimateControl
{
  public class ClimateControlThreading : ThreadingExtensionBase
  {
    public override void OnCreated(IThreading threading)
    {
      base.OnCreated(threading);

      ClimateControlEngine.Instance.ThreadingManager = threading;
    }

    public override void OnUpdate(float realTimeDelta, float simulationTimeDelta)
    {
      base.OnUpdate(realTimeDelta, simulationTimeDelta);

      try
      {
        ClimateControlEngine.Instance.UpdateClimate();
      }
      catch (Exception ex)
      {
        //Logger.Log(ex.Message);
        //Logger.Log(ex.ToString());
      }
    }
  }
}
