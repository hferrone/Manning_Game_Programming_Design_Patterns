using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractFactory
{
    public GameObject Spawner { get; protected set; }

    public AbstractFactory()
    {
        Spawner = new GameObject();
    }

    //public abstract Item Create();
    public abstract Item Create();
}

public class PebbleFactory : AbstractFactory
{
    public PebbleFactory()
    {
        Spawner.name = "Pebble Factory";
    }

    //public override Item Create()
    //{
    //    return new Pebble();
    //}

    public override Item Create()
    {
        var prefab = Resources.Load("Pebble") as GameObject;
        var item = new Pebble(prefab);

        item.GO.transform.position = new Vector3(-2.2f, 0.3f, -7f);
        item.GO.transform.SetParent(Spawner.transform);

        return item;
    }
}

public class CursedKnifeFactory : AbstractFactory
{
    //public override Item Create()
    //{
    //    return new CursedKnife();
    //}
    public CursedKnifeFactory()
    {
        Spawner.name = "Cursed Factory";
    }

    public override Item Create()
    {
        var prefab = Resources.Load("Knife") as GameObject;
        var item = new CursedKnife(prefab);

        item.GO.transform.position = new Vector3(-0.6f, 0.3f, -7.6f);
        item.GO.transform.SetParent(Spawner.transform);

        return item;
    }
}

public class PotionFactory : AbstractFactory
{
    //public override Item Create()
    //{
    //    return new Potion();
    //}

    public PotionFactory()
    {
        Spawner.name = "Potion Factory";
    }

    public override Item Create()
    {
        var prefab = Resources.Load("Potion") as GameObject;
        var item = new Potion(prefab);

        item.GO.transform.position = new Vector3(0.6f, 0.3f, -7f);
        item.GO.transform.SetParent(Spawner.transform);

        return item;
    }
}