using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTwoD : MonoBehaviour
{
    private Rigidbody2D rb;

    public float moveSpeed = 10;
    public float turnSpeed = 5;
    public float hitPower = 10;
    private Vector2 bumping;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bumping = new Vector2(0, -hitPower);
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
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.otherCollider.tag == "Enemy")
        {
            rb.AddRelativeForce(bumping);
            collision.otherCollider.GetComponent<Rigidbody2D>().AddRelativeForce(bumping);
        }
    }
}
