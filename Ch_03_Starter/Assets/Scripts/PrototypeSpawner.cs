using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrototypeSpawner : MonoBehaviour
{
    void Start()
    {
        EnemyData ogre = new EnemyData(10, "RAWR", "Ogre");
        ogre.Print();
    }
}