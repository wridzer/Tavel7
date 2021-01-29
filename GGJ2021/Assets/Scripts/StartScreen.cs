using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("3DWorld");
    }
    
    public void Quit()
    {
        Application.Quit();
        Debug.Log("YEET");
    }
}
