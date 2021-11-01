using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

// S1
public interface IPrototype
{
    public IPrototype ShallowClone();
    public IPrototype DeepClone();
}

// S1
public class EnemyInfo
{
    public int ID;
    public EnemyInfo(int id)
    {
        this.ID = id;
    }
}

public class EnemyData : IPrototype
{
    public int Damage;
    public string Message;
    public string EnemyName;

    // S1
    public EnemyInfo Info;

    public EnemyData(int dmg, string msg, string name, EnemyInfo info)
    {
        this.Damage = dmg;
        this.Message = msg;
        this.EnemyName = name;
        this.Info = info;
    }

    public void Print()
    {
        Debug.LogFormat($"{Message}! {EnemyName}({Info.ID}) can hit for {Damage} HP.");
    }

    // S1
    public IPrototype ShallowClone()
    {
        IPrototype newPrototype = null;

        try
        {
            newPrototype = (IPrototype)base.MemberwiseClone();
        }
        catch (Exception e)
        {
            Debug.LogError("Error cloning: " + e);
        }

        return newPrototype;
    }

    public IPrototype DeepClone()
    {
        EnemyData newProrotype = (EnemyData)ShallowClone();
        newProrotype.Info = new EnemyInfo(this.Info.ID);

        return newProrotype;
    }
}