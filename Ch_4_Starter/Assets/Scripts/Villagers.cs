using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elder : NPC
{
    public Elder(PrimitiveType primitive, Color color) : base(primitive, color)
    {
        if(GO != null)
        {
            GO.name = GetType().Name + " NPC";
        }
    }

    public override void Greeting()
    {
        Debug.Log("Welcome traveller - are you here for something special?");
    }
}

public class Villager : NPC
{
    public Villager(PrimitiveType primitive, Color color) : base(primitive, color)
    {
        if (GO != null)
        {
            GO.name = GetType().Name + " NPC";
        }
    }
}