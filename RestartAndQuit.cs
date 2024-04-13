using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartAndQuit : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("Scene");
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}
