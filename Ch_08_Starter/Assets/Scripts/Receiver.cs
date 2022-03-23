using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receiver
{
    public void Move()
    {
        Debug.Log("Move command received and executed!");
    }

    public void Shoot()
    {
        Debug.Log("Shoot command received and executed!");
    }
}