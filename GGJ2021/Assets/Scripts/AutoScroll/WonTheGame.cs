using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WonTheGame : MonoBehaviour
{
    public AudioSource audioS;
    public AudioClip winSF;
    public GameObject scoreKeep;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player") 
        {
            StartCoroutine(Win());
        }
    }

    public IEnumerator Win()
    {
        audioS.PlayOneShot(winSF);
        yield return new WaitForSeconds(1);
        scoreKeep.GetComponent<ScoreKeep>().Platform();
        SceneManager.LoadScene(1);
    }
}
