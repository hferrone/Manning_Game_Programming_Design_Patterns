using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupportAlly
{
    public string allyType;    
    public List<GameObject> components = new List<GameObject>();
    public GameObject parent;

    public SupportAlly(string newAlly)    
    {
        allyType = newAlly;
        parent = new GameObject(newAlly);
    }

    public void AddComponent(string name)    
    {
        GameObject go = Utilities.CreateFromSO(name);
        go.transform.SetParent(parent.transform);
        components.Add(go);
        Debug.Log($"{name} component added!");
    }

    public string GetBlueprint()    
    {
        if (components.Count == 0)    
        {
            return "No components listed, use the Director class!";    
        }

        var blueprintLog = $"Support type: {allyType}\n\n";    

        foreach (GameObject component in components)    
        {
            blueprintLog += $" - {component.name} --- installed\n";    
        }

        return blueprintLog;    
    }
}