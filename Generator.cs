using System;
using System.Collections.Generic;

namespace PowerStationModel
{
    public class Generator : SteamCircuitComponent
    {
        public float HertzTarget;
        public float RPM;
        public float TorqueLoad;
        public float OutputPower { get; set; } // MW

        public Generator(float hertzTarget, string name = null) : base()
        {
            SpecID = _typeSpecificID++;
            HertzTarget = hertzTarget;
            Name = name ?? $"Generator {SpecID}";
        }

        public override void Update()
        {
            Console.WriteLine($"Generator {SpecID} is generating up to {OutputPower} MW.");
        }

        public void Shutdown()
        {
            Console.WriteLine($"Generator {SpecID} shut down.");
        }
    }
}
