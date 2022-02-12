using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AllyType
{
    Tank,
    Bomber
}

public class SupportAlly
{
    public AllyType allyType { get; private set; }
    public List<string> components = new List<string>();

    public SupportAlly(AllyType type)
    {
        allyType = type;
    }

    public void AddComponent(string name)
    {
        components.Add(name);
    }

    public string GetBlueprint()
    {
        if(components.Count == 0)
        {
            return "No components installed, make sure to use the Director class!";
        }

        var blueprintLog = $"Support type: {allyType.ToString()}\n\n";
        foreach(string component in components)
        {
            blueprintLog += $"  - {component} --- installed\n";
        }

        return blueprintLog;
    }
}