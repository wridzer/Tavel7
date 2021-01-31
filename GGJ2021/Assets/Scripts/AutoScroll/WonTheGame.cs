using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WonTheGame : MonoBehaviour
{
    public GameObject scoreKeep;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player") 
        {
            print("Je ruikt naar natte hond, kun je alsjeblieft ergens anders zitten?");
            scoreKeep.GetComponent<ScoreKeep>().Platform();
            SceneManager.LoadScene(1);
        }
    }
}
