using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Category { Normal, Rare, Healing }

public abstract class ParameterizedFactory
{
    public abstract Item Create(Category type);
}

public class MultiItemFactory : ParameterizedFactory
{
    public override Item Create(Category category)
    {
        switch (category)
        {
            case Category.Normal:
                return new Pebble();
            case Category.Rare:
                return new CursedKnife();
            case Category.Healing:
                return new Potion();
            default:
                return null;
        }
    }
}