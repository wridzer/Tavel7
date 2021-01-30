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

    private bool onGrass;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        onGrass = false;
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
            Vector2 moving = new Vector2(0, moveSpeed * Time.deltaTime);
            rb.AddRelativeForce(moving);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.angularVelocity += turnSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.angularVelocity += -turnSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
                rb.drag = 4;
        }
        if (onGrass == true) 
        {
            rb.drag = 5;
        } else { rb.drag = 2; }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Finish")
        {
            gm.GetComponent<GameManger>().StartTimer();
        }
        if(collision.tag == "Terrain")
        {
            onGrass = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.tag == "Terrain")
        {
            onGrass = false;
        }
    }
}
