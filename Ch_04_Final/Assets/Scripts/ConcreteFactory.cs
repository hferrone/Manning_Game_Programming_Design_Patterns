using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteFactory
{
    public virtual Item NormalItem()
    {
        return new Pebble();
    }

    public virtual Item RareItem()
    {
        return new CursedKnife();
    }

    public virtual Item HealingItem()
    {
        return new Potion();
    }

    public List<Item> CreateInventory()
    {
        return new List<Item>()
        {
            NormalItem(),
            RareItem(),
            HealingItem(),
        };
    }
}

public class HealingFactory : ConcreteFactory
{
    public override Item NormalItem()
    {
        return new Potion();
    }
}