using System;
using System.Collections.Generic;

namespace PowerStationModel;

public class Superheater : SteamCircuitComponent
{
    private double _temperatureIncrease;  // Temperature increase in °C

    public Superheater(string name, double temperatureIncrease) : base()
    {
        _temperatureIncrease = temperatureIncrease;
        SpecID =_typeSpecificID++;
        Name = name;
    }
    public override void Update()
    {
        Console.WriteLine("SuperHeater is Heating!");
    }
}
