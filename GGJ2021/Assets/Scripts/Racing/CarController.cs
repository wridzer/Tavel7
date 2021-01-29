using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private Rigidbody2D rb;

    public float moveSpeed = 10;
    public float turnSpeed = 5;
    public float brakeSpeed = 5;

    public GameObject gm;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Vector2 moving = new Vector2(0, moveSpeed);
            rb.AddRelativeForce(moving);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.angularVelocity += turnSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.angularVelocity += -turnSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
                rb.drag = 4;
        } else { rb.drag = 2; }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Finish")
        {
            gm.GetComponent<GameManger>().StartTimer();
        }
    }
}
