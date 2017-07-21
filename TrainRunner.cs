using System;
using System.Collections.Generic;

namespace TrainSignalingSystem
{
    public class TrainRunner
    {
        public void RunTheTrain(Train train)
        {
            foreach (var signalOnRoute in train.trainRoute.SignalsOnRoute)
            {              
                signalOnRoute.key.CurrentSignalStatus = SignalStatus.Red;
                Task.Delay(signalOnRoute.Value);
            }             
        }
    }

    public class TrainValidator
    {
        
    }
}
