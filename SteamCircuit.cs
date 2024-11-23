using System.Collections.Generic;
using System.ComponentModel;

namespace PowerStationModel;

public class SteamCircuit
{
    public string Name;
    public List<SteamCircuitComponent> ComponentList = new List<SteamCircuitComponent>();

    public SteamCircuit(string name)
    {
        Name = name;
    }

    public void Add(SteamCircuitComponent component)
    {
        ComponentList.Add(component);
    }

    public void Update()
    {
        foreach (SteamCircuitComponent component in ComponentList)
        {
            component.Update();
        }
    }
}
