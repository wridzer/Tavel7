using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FishHangle : MonoBehaviour
{
    private Vector3 dobberPosition;
    public float max;
    public float min;

    public KeyCode moveUp;
    public KeyCode moveDown;

    public bool hasFish = false;
    public bool hasBadFish = false;

    public int fishPoints;

    private GameObject fish;
    public GameObject line, scoreKeep;

    public Text fishScore;
    public Text gameOverText;
    public Text youWinText;

    public int speed = 12;

    public AudioSource audioS;
    public AudioClip winSF, loseSF;

    private void Start()
    {
        gameOverText.enabled = false;
        youWinText.enabled = false;
    }

    void Update()
    {
        if (Input.GetKey(moveUp) && (gameObject.transform.position.y <= min))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
        }
        else if (Input.GetKey(moveDown) && (gameObject.transform.position.y >= max))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed * -1);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }

        line.GetComponent<LineRenderer>().SetPosition(1, new Vector3(this.gameObject.transform.position.x - 0.0625f, this.gameObject.transform.position.y, this.gameObject.transform.position.z));

        fishScore.text = fishPoints.ToString();
        if (fishPoints >= 3)
        {
            StartCoroutine(WinCond());
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Fish")
        {
            hasFish = true;
            fish = collision.gameObject;
        }
        if (collision.gameObject.tag == "BadFish")
        {
            hasBadFish = true;
            fish = collision.gameObject;
        }

        if (collision.gameObject.tag == "FishBucket" && hasFish == true)
        {
            hasFish = false;
            fish.SetActive(false);
            fishPoints++;
        }
        if (collision.gameObject.tag == "FishBucket" && hasBadFish == true)
        {
            hasBadFish = false;
            fish.SetActive(false);
            fishPoints--;
            if(fishPoints == -1)
            {
                StartCoroutine(GameOverScreen());
            }
        }
    }

    public IEnumerator GameOverScreen()
    {
        gameOverText.enabled = true;
        //geluid
        Time.timeScale = 0.2f;
        yield return new WaitForSeconds(3);
        gameOverText.enabled = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("Fishing");
    }

    public IEnumerator WinCond()
    {
        audioS.PlayOneShot(winSF);
        yield return new WaitForSeconds(1);
        scoreKeep.GetComponent<ScoreKeep>().Fish();
        SceneManager.LoadScene(7);
    }
}
