using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheDeathZone : MonoBehaviour
{

    public GameObject Player;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player") { Player.transform.position = new Vector3(-5, -2, 0); }
        else { print("je moeder"); }
    }


    void Update()
    {
        
    }
}
