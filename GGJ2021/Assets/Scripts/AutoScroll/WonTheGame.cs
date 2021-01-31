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
            scoreKeep.GetComponent<ScoreKeep>().Platform();
            SceneManager.LoadScene(1);
        }
    }
}
