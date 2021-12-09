using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public Text AP;
    public Text EXP;
    public GameObject Player;

    private int _abilityPoints = 0;
    public int AbilityPoints
    {
        get { return _abilityPoints; }
        set
        {
            _abilityPoints = value;
            AP.text = $"AP Cost: {value}";
        }
    }

    private int _experience = 0;
    public int Experience
    {
        get { return _experience; }
        set
        {
            _experience = value;
            EXP.text = $"EXP Boost: {value}";
        }
    }

    public void ChangeColor(Color color)
    {
        var renderer = Player.GetComponent<Renderer>();
        renderer.material.SetColor("_Color", color);
    }
}