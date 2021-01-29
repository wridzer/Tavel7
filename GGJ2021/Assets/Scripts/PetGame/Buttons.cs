using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public int petScore, feedScore, playScore;

    void Start()
    {
        
    }

    void Update()
    {
        if(feedScore == 5)
        {
            //fat
        }
        if (feedScore == 10)
        {
            //ever fatter
        }
        if (feedScore == 15)
        {
            //EVEN FATTER
        }
        if (feedScore == 20)
        {
            //EXPLOSION
        }
    }

    public void pet()
    {
        Debug.Log("pet");
        petScore++;

        //pet anime
    }
    public void Feed()
    {
        Debug.Log("Feed");
        feedScore++;

        //feed anime
    }
    public void Play()
    {
        Debug.Log("Play");
        playScore++;

        //play anime
    }
}
