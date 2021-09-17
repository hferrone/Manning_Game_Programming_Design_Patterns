using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    // TODO:
    // - Add player score with initial value
    // - Make this manager a Singleton
    public static Manager Instance;

    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            Debug.Log("New instance initialized...");
        }
        else if(Instance != this)
        {
            Destroy(this.gameObject);
            Debug.Log("Duplicate instance found and deleted...");
        }

        DontDestroyOnLoad(this.gameObject);
    }

    public void StartGame()
    {
        Debug.Log("New game has started...");
        SceneManager.LoadScene(1);
    }
}