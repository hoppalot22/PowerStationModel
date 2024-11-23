using System;
using System.Collections.Generic;

namespace PowerStationModel
{
    public class Turbine : SteamCircuitComponent
    {
        public double PowerOutput { get; set; } // MW
        public Turbine(string name, double powerOutput) : base()
        {
            SpecID = _typeSpecificID++;
            PowerOutput = powerOutput;
            Name = name;
        }

        public override void Update()
        {
            Console.WriteLine($"{Name} is spinning, generating {PowerOutput} MW.");
        }

        public void Stop()
        {
            Console.WriteLine($"{Name} stopped.");
        }
    }
}
