using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class NPCSpawner
{
    protected List<NPC> _npcs = new List<NPC>();
    public List<NPC> NPCs
    {
        get { return _npcs; }
    }

    public GameObject Spawner { get; protected set; }

    public NPCSpawner()
    {
        this.Spawner = new GameObject("Default Spawner");
        this.CreateNPCs();
    }

    public abstract void CreateNPCs();
}