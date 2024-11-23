using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace PowerStationModel
{
    public class Pipe : SteamCircuitComponent
    {
        public Fluid PipeFluid;

        private float OuterDiameter;    
        private float InternalDiameter;
        private float Thickness;
        //private Material PipeMaterial;
        public float InternalPressure = 0f;
        public float ExternalPressure = 0f;
        private float OuterRadius;
        private float InnerRadius;
        //private float Length;
        //private float Volume;
        public float FlowRate = 0;
        public float FluidVelocity;
        public float HydraulicArea;
        public float FluidDensity = 0;
        //private float SurfaceRoughness;
        //private float RelativeRoughness;
        //private float FrictionFactor;

        public Pipe(float outerDiamter, float thickness, string name = null) : base()
        {
            SpecID = _typeSpecificID++;
            Name = name ?? $"Pipe {SpecID}";
            OuterDiameter = outerDiamter;
            Thickness = thickness;
            //PipeMaterial = material;

            InternalDiameter = outerDiamter - 2*thickness;
            OuterRadius = outerDiamter/2;
            InnerRadius = OuterRadius - Thickness;

            //SurfaceRoughness = PipeMaterial.SurfaceRoughness;
            //RelativeRoughness = SurfaceRoughness/InternalDiameter;

            HydraulicArea = (float)Math.PI*InnerRadius*InnerRadius;
            FluidVelocity = FlowRate/HydraulicArea;

            //Volume = HydraulicArea*Length;
        }

        float AxialStress()
        {
            return (InternalPressure*InnerRadius*InnerRadius - ExternalPressure*OuterRadius*OuterRadius)/(OuterRadius*OuterRadius-InnerRadius*InnerRadius);
        }

        float HoopStress(float radius)
        {
            return (InternalPressure*InnerRadius*InnerRadius - ExternalPressure*OuterRadius*OuterRadius)/(OuterRadius*OuterRadius-InnerRadius*InnerRadius) + (InnerRadius*InnerRadius*OuterRadius*OuterRadius*(ExternalPressure-InternalPressure)/(radius*radius*(OuterRadius*OuterRadius-InnerRadius*InnerRadius)));
        }

        float RadialStress(float radius)
        {
            return (InternalPressure*InnerRadius*InnerRadius - ExternalPressure*OuterRadius*OuterRadius)/(OuterRadius*OuterRadius-InnerRadius*InnerRadius) - (InnerRadius*InnerRadius*OuterRadius*OuterRadius*(ExternalPressure-InternalPressure)/(radius*radius*(OuterRadius*OuterRadius-InnerRadius*InnerRadius)));
        }

        public float CalculateReynoldsNumber()
        {           
            return FluidDensity * FluidVelocity * InternalDiameter / PipeFluid.Viscosity;
        }
        public override void Update()
        {
            Console.WriteLine($"Pipe {SpecID} is transporting fluid. Diameter: {OuterDiameter} meters.");
        }
    }
}
