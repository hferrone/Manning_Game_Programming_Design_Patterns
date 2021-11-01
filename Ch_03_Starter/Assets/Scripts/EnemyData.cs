using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyData 
{
    public int Damage;
    public string Message;
    public string EnemyName;

    public EnemyData(int dmg, string msg, string name)
    {
        this.Damage = dmg;
        this.Message = msg;
        this.EnemyName = name;
    }

    public void Print()
    {
        Debug.LogFormat($"{Message}! {EnemyName} can hit for {Damage} HP.");
    }
}