using System;
using System.Collections.Generic;
using System.Dynamic;

namespace PowerStationModel
{
    public abstract class SteamCircuitComponent
    {
        protected static int _circuitID = 1;
        public static int _typeSpecificID = 1;
        public int CircuitID { get; set;}
        public int SpecID {get; set;}
        public string Name {get; set;}
        public List<SteamCircuitComponent> ConnectedComponents {get; set;} = new List<SteamCircuitComponent>();
        public abstract void Update();

        public SteamCircuitComponent()
        {
            CircuitID = _circuitID++;

            Console.WriteLine($"{this.Name} has CircuitID: {CircuitID} and SpecID: {SpecID}");
        }
      
        public void Connect(SteamCircuitComponent otherComponent)
        {
            ConnectedComponents.Add(otherComponent);
            otherComponent.ConnectedComponents.Add(this);
            Console.WriteLine($"{this.Name} connected to {otherComponent.Name}");
        }
    }
}
