using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    void Start()
    {
        OldTown oldTownFactory = new OldTown();
        oldTownFactory.Welcome();
    }
}