using System;
using System.Collections.Generic;

namespace TrainSignalingSystem
{
    public class Train
    {
        public string TrainName { get; set;}
        public TrainRoute CurrentTrainRoute { get; set; }
    }

    public class TrainRoute
    {
        public Station StartStation  { get; set;}
        public Station DestinationStation  { get; set;}
        public Dictionary<Signal, int> SignalsOnRoute { get; set; }
    }

    public class Station
    {
        public string StationName {get; set;}       
    }

     public class Signal
    {
        public Signal(int signalId)
        {
            this.SignalId = signalId;
        }
        public int SignalId {get; set;}
        public SignalStatus CurrentSignalStatus { get; set; }
    }

    public enum SignalStatus
    {
        Green,
        Red
    }
}
