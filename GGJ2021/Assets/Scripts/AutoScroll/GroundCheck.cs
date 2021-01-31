using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    [SerializeField]
    int counter = 0;

    public AudioSource audioS;
    public AudioClip landSF;

    public bool OnGround = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        counter++;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        counter--;
    }

    void Update()
    {
        if (counter != 0) 
        { 
            OnGround = true; 
            //audioS.PlayOneShot(landSF);
        }
        else { OnGround = false; }
    }
}
