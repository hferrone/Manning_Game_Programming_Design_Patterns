using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrototypeSpawner : MonoBehaviour
{
    // S2
    public PrototypeComponent Ogre;
    public PrototypeComponent Serpent;
    public PrototypeComponent AshKnight;

    void Start()
    {
        // S1
        EnemyData ogre = new EnemyData(10, "RAWR", "Ogre", new EnemyInfo(1));
        ogre.Print();

        EnemyData shallowOgre = (EnemyData)ogre.ShallowClone();
        shallowOgre.Print();

        EnemyData deepOgre = (EnemyData)ogre.DeepClone();
        deepOgre.Info = new EnemyInfo(2);
        deepOgre.Print();

        // S2
        for (int i = 0; i < 4; i++)
        {
            var random = Random.Range(1, 4);
            switch(random)
            {
                case 1:
                    var clonedOgre = Ogre.Clone<Ogre>();
                    break;
                case 2:
                    var clonedSerpent = Serpent.Clone<Serpent>();
                    break;
                case 3:
                    var clonedAshKnight = AshKnight.Clone<AshKnight>();
                    break;
            }
        }
    }
}