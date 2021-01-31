using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheDeathZone : MonoBehaviour
{
    public AudioSource audioS;
    public AudioClip deathSF;
    public GameObject Player;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player") { Player.transform.position = new Vector3(-9, -1, 0); audioS.PlayOneShot(deathSF); }
    }


    void Update()
    {
        
    }
}
