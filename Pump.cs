using System;
using System.Collections.Generic;

namespace PowerStationModel
{
    public class Pump : SteamCircuitComponent
    {
        public double FlowRate { get; set; } // m³/s
        public SteamCircuitComponent InletComponent;
        public SteamCircuitComponent OutletComponent;

        public Pump(int id, double flowRate) : base()
        {
            SpecID = _typeSpecificID++;
            FlowRate = flowRate;
            Name = $"Pump {id}";
        }

        public override void Update()
        {
            Console.WriteLine($"Pump {Name} is Pumping {FlowRate} L/s");
        }

        public void Start()
        {
            Console.WriteLine($"Pump {SpecID} started, Flow Rate: {FlowRate} m³/s");
        }

        public void Stop()
        {
            Console.WriteLine($"Pump {SpecID} stopped.");
        }
    }
}
