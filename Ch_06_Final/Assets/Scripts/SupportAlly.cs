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
    public AllyType allyType;
    public GameObject parent;
    public List<string> components = new List<string>();

    public SupportAlly(AllyType type)
    {
        allyType = type;
        parent = new GameObject(type.ToString());
    }

    public void AddComponent(string name)
    {
        GameObject go = Utilities.CreateFromSO(name);
        go.transform.SetParent(parent.transform);

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