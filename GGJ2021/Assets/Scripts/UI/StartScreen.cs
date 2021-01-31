using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    public GameObject scoreKeep;

    public void Play()
    {
        scoreKeep.GetComponent<ScoreKeep>().KeepPos(new Vector3(-0.79f, 2.09f, -7.16f), new Quaternion(0,0,0,0));
        SceneManager.LoadScene(1);
    }
    
    public void Quit()
    {
        Application.Quit();
        Debug.Log("YEET");
    }
}
