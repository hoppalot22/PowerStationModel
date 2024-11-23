using System;

namespace PowerStationModel
{
    public class Material
    {
        public string Name { get; set; } // Material name (e.g., Steel, Aluminum)
        public float SurfaceRoughness { get; set; } // Micrometers (µm)
        public float Hardness { get; set; } // Vickers Hardness (VHN)
        public float YieldStrength { get; set; } // MPa (megapascals)
        public float ThermalConductivity { get; set; } // W/(m·K)
        public float Density { get; set; } // kg/m³

        // Constructor to initialize material properties
        public Material(
            string name, 
            float surfaceRoughness, 
            float hardness, 
            float yieldStrength, 
            float thermalConductivity,
            float density)
        {
            Name = name;
            SurfaceRoughness = surfaceRoughness;
            Hardness = hardness;
            YieldStrength = yieldStrength;
            ThermalConductivity = thermalConductivity;
            Density = density;
        }

        // Method to display material properties
        public void DisplayProperties()
        {
            Console.WriteLine($"Material: {Name}");
            Console.WriteLine($"Surface Roughness: {SurfaceRoughness} µm");
            Console.WriteLine($"Hardness: {Hardness} VHN");
            Console.WriteLine($"Yield Strength: {YieldStrength} MPa");
            Console.WriteLine($"Thermal Conductivity: {ThermalConductivity} W/(m·K)");
            Console.WriteLine($"Density: {Density} kg/m³");
        }
    }
}
