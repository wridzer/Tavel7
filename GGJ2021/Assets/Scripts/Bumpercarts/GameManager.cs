using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int player;
    private int enims;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindGameObjectsWithTag("Player").Length;
        enims = GameObject.FindGameObjectsWithTag("Enemy").Length;

        if(player == 0)
        {
            Debug.Log("Game Over"); //Enter lose condition here
        }
        if(enims == 0)
        {
            Debug.Log("Winner Winner Chicken Dinner"); //Enter win condition here
        }
    }
}
