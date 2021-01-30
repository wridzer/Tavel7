using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int player;
    private int enims;

    private int waveCount;
    public GameObject enim;

    public AudioSource audioS;
    public AudioClip winSF, loseSF, deathSF;

    public Text scoreT;

    // Start is called before the first frame update
    void Start()
    {
        waveCount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindGameObjectsWithTag("Player").Length;
        enims = GameObject.FindGameObjectsWithTag("Enemy").Length;

        if(player == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            audioS.PlayOneShot(loseSF);
        }
        if(enims == 0)
        {
            audioS.PlayOneShot(deathSF);
            waveCount++;
            SpawnEnim();
        }

        scoreT.text = (waveCount - 1).ToString() + "/3";
    }

    void SpawnEnim()
    {
        if (waveCount < 4)
        {
            Instantiate(enim, new Vector3(0, 0, 0), transform.rotation);
        }
        if (waveCount >= 4)
        {
            Debug.Log("Win");
        }
    }
}
