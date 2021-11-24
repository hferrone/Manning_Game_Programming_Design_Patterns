using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldTown : NPCSpawner
{
    public OldTown()
    {
        Spawner.name = GetType().Name + " Factory";
    }

    public override void CreateNPCs()
    {
        NPC newNPC = new Elder(PrimitiveType.Capsule, Color.cyan);
        newNPC.GO.transform.SetParent(Spawner.transform);

        var camPos = GameObject.Find("Main Camera").GetComponent<Transform>().position;
        newNPC.GO.transform.localPosition = new Vector3(camPos.x + 2, camPos.y, camPos.z + 3);

        _npcs.Add(newNPC);

        for(int i = 0; i < 5; i++)
        {
            newNPC = new Villager(PrimitiveType.Cube, Color.yellow);
            newNPC.GO.transform.SetParent(Spawner.transform);

            var randomPosition = new Vector3(Random.Range(-7, 7), 1f, Random.Range(-7, 7));
            newNPC.GO.transform.localPosition = randomPosition;

            _npcs.Add(newNPC);
        }
    }

    public void Welcome()
    {
        foreach(NPC npc in _npcs)
        {
            npc.Greeting();
        }
    }
}