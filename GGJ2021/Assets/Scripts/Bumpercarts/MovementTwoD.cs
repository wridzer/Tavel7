﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovementTwoD : MonoBehaviour
{
    private Rigidbody2D rb;

    public float moveSpeed = 10;
    public float turnSpeed = 5;
    public float hitPower = 10;
    private Vector2 bump;
    private Vector2 bumpE;

    public AudioSource audioS;
    public AudioClip hitSF, deathSF;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bump = new Vector2(0, hitPower);
        bumpE = new Vector2(0, hitPower * 4f);
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
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            rb.AddForceAtPosition(bump, collision.transform.position);
            collision.rigidbody.AddForceAtPosition(bumpE, transform.position);
            audioS.PlayOneShot(hitSF);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            rb.AddForceAtPosition(bump, collision.transform.position);
            collision.rigidbody.AddForceAtPosition(bumpE, transform.position);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Deadzone")
        {
            StartCoroutine(Timer());
        }
    }

    public IEnumerator Timer()
    {
        audioS.PlayOneShot(deathSF);
        yield return new WaitForSeconds(1);
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene);
    }
}
