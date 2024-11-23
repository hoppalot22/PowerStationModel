using System;

public class Fluid
{
    // Properties
    public string Name { get; }              // Name of the fluid (e.g., "Water", "Steam")
    public float Density { get; }          // Density in kg/m^3
    public float Viscosity { get; }        // Dynamic viscosity in Pa·s
    public float SpecificHeat { get; }     // Specific heat capacity in J/(kg·K)
    public float ThermalConductivity { get; } // Thermal conductivity in W/(m·K)
    public float BoilingPoint { get; }     // Boiling point at 1 atm in Celsius

    // Constructor
    public Fluid(string name, float density, float viscosity, float specificHeat, 
                 float thermalConductivity, float boilingPoint)
    {
        Name = name;
        Density = density;
        Viscosity = viscosity;
        SpecificHeat = specificHeat;
        ThermalConductivity = thermalConductivity;
        BoilingPoint = boilingPoint;
    }

    // Method to calculate Reynolds number
    public float CalculateReynoldsNumber(float velocity, float characteristicLength)
    {
        // Formula: Re = (Density * Velocity * Length) / Viscosity
        return (Density * velocity * characteristicLength) / Viscosity;
    }

    // Override ToString for debugging and logging
    public override string ToString()
    {
        return $"{Name} - Density: {Density} kg/m^3, Viscosity: {Viscosity} Pa·s, " +
               $"Specific Heat: {SpecificHeat} J/(kg·K), Thermal Conductivity: {ThermalConductivity} W/(m·K), " +
               $"Boiling Point: {BoilingPoint} °C";
    }
}
