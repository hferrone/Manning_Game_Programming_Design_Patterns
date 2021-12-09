using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    public ItemButton ButtonPrefab;

    void Start()
    {
        // #1 Abstract factory implementation
        List<AbstractFactory> factories = new List<AbstractFactory>()
        {
            new PebbleFactory(),
            new CursedKnifeFactory(),
            new PotionFactory()
        };

        foreach (AbstractFactory factory in factories)
        {
            var button = Instantiate(ButtonPrefab);
            Item item = factory.Create();

            button.Configure(item);
            button.transform.SetParent(this.transform);
        }

        // #2 Concrete Factory implementation
        //var concreteFactory = new ConcreteFactory();

        //foreach (Item item in concreteFactory.CreateInventory())
        //{
        //    var button = Instantiate(ButtonPrefab);
        //    //Item item = factory.Create();

        //    button.Configure(item);
        //    button.transform.SetParent(this.transform);
        //}

        // #3 Parameterized Factory implementation
        //var itemFactory = new MultiItemFactory();
        //List<Item> items = new List<Item>()
        //{
        //    itemFactory.Create(Category.Normal),
        //    itemFactory.Create(Category.Rare),
        //    itemFactory.Create(Category.Healing)
        //};

        //foreach(Item item in items)
        //{
        //    var button = Instantiate(ButtonPrefab);
        //    button.Configure(item);
        //    button.transform.SetParent(this.transform);
        //}

        // #4 Custom Factory implementation
        //var itemFactory = new CustomItems();

        //foreach (Item item in itemFactory.Items)
        //{
        //    var button = Instantiate(ButtonPrefab);

        //    button.Configure(item);
        //    button.transform.SetParent(this.transform);
        //}
    }
}