using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class NPC
{
    public GameObject GO;

    public NPC(PrimitiveType primitive, Color color)
    {
        this.GO = GameObject.CreatePrimitive(primitive);
        var renderer = this.GO.GetComponent<Renderer>();
        renderer.material.SetColor("_Color", color);
    }

    public virtual void Greeting()
    {
        Debug.Log("Isn't our village the best?");
    }
}