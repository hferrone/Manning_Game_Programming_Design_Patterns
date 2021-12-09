using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CustomFactory
{
    public GameObject Spawner { get; protected set; }

    protected List<Item> _items = new List<Item>();
    public List<Item> Items
    {
        get { return _items; }
    }

    public CustomFactory()
    {
        Spawner = new GameObject();
        Populate();
    }

    public abstract void Populate();
}

public class CustomItems : CustomFactory
{
    public CustomItems()
    {
        Spawner.name = "Custom Factory";
    }

    public override void Populate()
    {
        int itemNum = 0;
        Item item = new Pebble(PrimitiveType.Sphere, Color.grey, itemNum++);

        item.GO.transform.SetParent(Spawner.transform);
        _items.Add(item);

        item = new CursedKnife(PrimitiveType.Cylinder, Color.magenta, itemNum++);
        item.GO.transform.SetParent(Spawner.transform);
        _items.Add(item);

        item = new Potion(PrimitiveType.Capsule, Color.green, itemNum++);
        item.GO.transform.SetParent(Spawner.transform);
        _items.Add(item);
    }
}