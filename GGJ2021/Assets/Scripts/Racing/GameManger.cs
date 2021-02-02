using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManger : MonoBehaviour
{
    public GameObject CP, CP1;
    [SerializeField] private int checkP1, checkP2, finishP, finishE, lapCounter;
    private bool enimFin, playFin = false;

    public AudioClip winSF, loseSF;
    public AudioSource audioS;

    public GameObject winCheck, loseText, lapCount;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (finishP == 3)
        {
            playFin = true;
        }
        if(finishE == 4)
        {
            enimFin = true;
        }
        if(enimFin == true && playFin == false)
        {
            StartCoroutine(LoseCond());
        }
        if(enimFin == false && playFin == true)
        {
            StartCoroutine(WinCond());
        }
        lapCounter = finishP + 1;
        if (lapCounter != 4)
        {
            lapCount.GetComponent<Text>().text = lapCounter.ToString() + "/3";
        }
        if (lapCounter == 4)
        {
            lapCount.GetComponent<Text>().text = "You Win!";
        }
    }

    public void Check1()
    {
        if(finishP == checkP1)
        {
            checkP1++;
        }
    }

    public void Check2()
    {
        if (checkP1 == checkP2 + 1)
        {
            checkP2++;
        }
    }

    public void Finish()
    {
        if (checkP2 == finishP + 1)
        {
            finishP++;
        }
    }
    public void FinishE()
    {
        finishE++;
    }

    public IEnumerator WinCond()
    {
        audioS.PlayOneShot(winSF);
        yield return new WaitForSeconds(3);
        winCheck.GetComponent<ScoreKeep>().Race();
        SceneManager.LoadScene(7);
    }

    public IEnumerator LoseCond()
    {
        audioS.PlayOneShot(loseSF);
        loseText.SetActive(true);
        yield return new WaitForSeconds(3);
        loseText.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
