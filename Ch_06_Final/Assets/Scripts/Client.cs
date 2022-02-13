using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Client : MonoBehaviour
{
    public Text BlueprintLog;

    private Director _director = new Director();
    private IBuilder _builder;

    public void Build()
    {
        //var go = Utilities.Create("TankBody");
        //Debug.Log("Nothing to build yet...");

        _builder = new TankBuilder();
        _director.ConstructWith(_builder);
        SupportAlly ally = _builder.GetAlly();

        //SupportAlly test = new SupportAlly(AllyType.Tank);

        BlueprintLog.text = ally.GetBlueprint();
    }
}