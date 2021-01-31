 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WorkingEndHole : MonoBehaviour
{
    public GameObject scoreKeep;
    public GameObject HoleInOneText, goodJobText, noobText;
    public Golfing golf;
    public GameObject Player;
    public Rigidbody2D rb2D;
    public AudioSource audioS;
    public AudioClip holeInOne, win, loser;
    public int par;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (golf.Hits == 1)
        {
            HoleInOneText.GetComponent<SpriteRenderer>().enabled = true;
            audioS.PlayOneShot(holeInOne);
        }
        else if (golf.Hits <= par)
        {
            goodJobText.GetComponent<SpriteRenderer>().enabled = true;
            audioS.PlayOneShot(win);
        }
        else
        {
            noobText.GetComponent<SpriteRenderer>().enabled = true;
            audioS.PlayOneShot(loser);
        }
        if (rb2D.velocity.magnitude < 3)
        {
            Player.transform.position = new Vector3(0, 0, -1);
            StartCoroutine(CameraDelay());
        }
        golf.Hits = 0;

    }

    private IEnumerator CameraDelay()
    {
        yield return new WaitForSeconds(2);
        //Game Gewonnen;
        scoreKeep.GetComponent<ScoreKeep>().Golf();
        SceneManager.LoadScene(7);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
