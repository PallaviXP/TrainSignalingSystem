using System;

namespace TrainSignalingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Train!");


            TrainRoute trainRoute = new TrainRoute
            {
                StartStation = new Station { StationName = "A" },
                DestinationStation = new Station { StationName = "B"},
               
            };
            trainRoute.SignalsOnRoute = new Dictionary<Signal, int>();
            trainRoute.SignalsOnRoute.Add(new Signal("S0"), 2000);
            trainRoute.SignalsOnRoute.Add(new Signal("S1"), 4000);
            trainRoute.SignalsOnRoute.Add(new Signal("S2"), 5000);
            trainRoute.SignalsOnRoute.Add(new Signal("S3"), 6000);
            
            Train train = new Train{
                TrainName = "XYZ",
                CurrentTrainRoute = trainRoute
            };

            train.RunTheTrain();


        }

       
    }
}
