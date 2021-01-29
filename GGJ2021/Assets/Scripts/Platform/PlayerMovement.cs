using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody2D Rb2D;

    [SerializeField]
    int HSpeed = 0;
    [SerializeField]
    int JSpeed = 0;

    void Update()
    {
        if (Input.GetKey("a") && !Input.GetKey("d")) { Rb2D.velocity = new Vector3(-HSpeed, Rb2D.velocity.y, 0); }
        else if (!Input.GetKey("a") && Input.GetKey("d")) { Rb2D.velocity = new Vector3(HSpeed, Rb2D.velocity.y, 0); }
        else { Rb2D.velocity = new Vector3(0, Rb2D.velocity.y, 0); }
    }
}
