using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item
{
    public abstract string Name { get; }
    public GameObject GO;

    public Item() { }
    public Item(GameObject prefab)
    {
        GO = GameObject.Instantiate(prefab);
        GO.name = GetType().Name + "(Item)";
    }

    public Item(PrimitiveType type, Color color, int itemNum)
    {
        GO = GameObject.CreatePrimitive(type);
        GO.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);

        var renderer = this.GO.GetComponent<Renderer>();
        renderer.material.SetColor("_Color", color);

        var playerPos = GameObject.Find("Player").transform.position;
        var horOffset = (Vector3.left.x + 0.4f) * (itemNum / 1.1f);
        GO.transform.position = new Vector3(horOffset, 0.25f, playerPos.z - 2); ;
    }

    public abstract void Equip();
}

public class Pebble : Item
{
    public override string Name => "Pebble";

    public Pebble() { }
    public Pebble(GameObject prefab) : base(prefab) { }
    public Pebble(PrimitiveType type, Color color, int itemNum) : base(type, color, itemNum)
    {
        if (GO != null)
        {
            GO.name = Name + " (Item)";
        }
    }

    public override void Equip()
    {
        Debug.Log($"You skipped your pebble at a nearby lake.");
    }
}

public class CursedKnife : Item
{
    public override string Name => "Cursed Knife";

    public CursedKnife() { }
    public CursedKnife(GameObject prefab) : base(prefab) { }
    public CursedKnife(PrimitiveType type, Color color, int itemNum) : base(type, color, itemNum)
    {
        if (GO != null)
        {
            GO.name = Name + " (Weapon)";
        }
    }

    public override void Equip()
    {
        var player = GameObject.FindObjectOfType<Player>();
        player.SetColor(Color.magenta);

        Debug.Log($"Woops, you're cursed...");
    }
}

public class Potion : Item
{
    public override string Name => "Potion";

    public Potion() { }
    public Potion(GameObject prefab) : base(prefab) { }
    public Potion(PrimitiveType type, Color color, int itemNum) : base(type, color, itemNum)
    {
        if (GO != null)
        {
            GO.name = Name + " (Consumable)";
        }
    }

    public override void Equip()
    {
        var player = GameObject.FindObjectOfType<Player>();
        player.SetColor(Color.green);

        var manager = GameObject.FindObjectOfType<Manager>();
        manager.HP += 5;
        manager.Boost++;

        Debug.Log($"Potion healed you for 5 HP!");
    }
}