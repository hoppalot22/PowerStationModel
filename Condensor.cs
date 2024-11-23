using System;
using System.Collections.Generic;
using PowerStationModel;

namespace PowerStationModel
{
public class Condenser : SteamCircuitComponent
    {
        public Condenser() : base()
        {
            SpecID = _typeSpecificID++;
            Name = $"Condensor {SpecID}";
        }
        public override void Update()
        {
            // Simulate condenser's reaction to power generation
            Console.WriteLine($"Condenser Cooling down the steam...");

            // Adjust system conditions by lowering pressure and temperature
            Console.WriteLine("Condenser operating. Lowering pressure and temperature.");
        }
    }
}