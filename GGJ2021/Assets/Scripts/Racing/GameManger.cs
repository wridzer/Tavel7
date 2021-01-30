using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    public GameObject CP, CP1;
    [SerializeField] private int checkP1, checkP2, finishP, finishE;
    private bool enimFin, playFin = false;

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
        }
        if(enimFin == false && playFin == true)
        {
            Debug.Log("Won");
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
