using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyData 
{
    public int Damage;
    public string Message;
    public string Name;

    public EnemyData(int dmg, string msg, string name)
    {
        this.Damage = dmg;
        this.Message = msg;
        this.Name = name;
    }

    public void Print()
    {
        Debug.LogFormat($"{Message}! {Name} can hit for {Damage} HP.");
    }
}