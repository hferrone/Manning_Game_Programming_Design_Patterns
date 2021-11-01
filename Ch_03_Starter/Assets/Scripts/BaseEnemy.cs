using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseEnemy : MonoBehaviour
{
    [SerializeField] protected int Damage;
    [SerializeField] protected string Message;
    [SerializeField] protected string EnemyName;

    public virtual void Attack()
    {
        Debug.LogFormat($"{Message}! {EnemyName} attacks for {Damage} HP.");
    }
}