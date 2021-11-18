using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Arena : MonoBehaviour
{
    public Text score;

    void Start()
    {
        score.text += SOManager.Instance.score;
    }

    void Update()
    {
        // TODO:
        // - Get updated scores from the Singleton manager
        score.text = "Score: " + SOManager.Instance.score;
    }
}