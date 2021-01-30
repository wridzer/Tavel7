using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{
    public GameObject CP, CP1;
    [SerializeField] private int checkP1, checkP2, finishP, finishE;
    private bool enimFin, playFin = false;

    public AudioClip winSF, loseSF;
    public AudioSource audioS;

    public GameObject winCheck;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(finishP == 3)
        {
            playFin = true;
        }
        if(finishE == 4)
        {
            enimFin = true;
        }
        if(enimFin == true && playFin == false)
        {
            Debug.Log("Lost");
            audioS.PlayOneShot(loseSF);
        }
        if(enimFin == false && playFin == true)
        {
            Debug.Log("Won");
            audioS.PlayOneShot(winSF);
            winCheck.GetComponent<ScoreKeep>().Race();
            SceneManager.LoadScene(1);
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
}
