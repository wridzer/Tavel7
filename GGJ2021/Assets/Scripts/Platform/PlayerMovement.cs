using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody2D Rb2D;
    public GroundCheck GroundCheck;

    [SerializeField]
    int HSpeed = 0;
    [SerializeField]
    int JSpeed = 0;

    void Update()
    {
        if (Input.GetKey("a") && !Input.GetKey("d")) { Rb2D.velocity = new Vector3(-HSpeed, Rb2D.velocity.y, 0); }
        else if (!Input.GetKey("a") && Input.GetKey("d")) { Rb2D.velocity = new Vector3(HSpeed, Rb2D.velocity.y, 0); }
        else { Rb2D.velocity = new Vector3(0, Rb2D.velocity.y, 0); }

        if (GroundCheck.OnGround == true && (Input.GetKeyDown("space") || Input.GetKeyDown("w") )) { Rb2D.AddForce(new Vector3(0, JSpeed, 0));}
    }
}
