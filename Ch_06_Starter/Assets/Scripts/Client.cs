using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Client : MonoBehaviour
{
    public Text BlueprintLog;

    public void Build()
    {
        var go = Utilities.Create("TankBody");

        Debug.Log("Nothing to build yet...");
    }
}