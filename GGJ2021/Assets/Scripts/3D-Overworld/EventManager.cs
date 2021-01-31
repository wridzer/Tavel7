using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public GameObject scoreKeep;
    public GameObject DoorActive;

    // Update is called once per frame
    void Update()
    {
        if(ScoreKeep.platform > 0)
        {
            DoorActive.SetActive(true);
        }
    }
}
