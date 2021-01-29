using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMover : MonoBehaviour
{
    public Rigidbody2D Rb2D;
    public GroundCheck GroundCheck;

    [SerializeField]
    int HSpeed = 0;
    [SerializeField]
    int JSpeed = 0;

    void Update()
    {
       Rb2D.velocity = new Vector3(HSpeed, Rb2D.velocity.y, 0);
       if (GroundCheck.OnGround == true && (Input.GetKeyDown("space") || Input.GetKeyDown("w"))) { Rb2D.AddForce(new Vector3(0, JSpeed, 0)); }
    }
}
