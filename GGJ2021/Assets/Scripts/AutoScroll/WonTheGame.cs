using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WonTheGame : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player") { print("Je ruikt naar natte hond, kun je alsjeblieft ergens anders zitten?"); }
    }
}
