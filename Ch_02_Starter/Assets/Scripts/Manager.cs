using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    // TODO:
    // - Make this manager a Singleton
    // - Add player score with initial value

    public void StartGame()
    {
        Debug.Log("New game has started...");
        SceneManager.LoadScene(1);
    }
}