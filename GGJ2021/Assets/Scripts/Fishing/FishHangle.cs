﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FishHangle : MonoBehaviour
{
    private Vector3 dobberPosition;
    public float max;
    public float min;

    public KeyCode moveUp;
    public KeyCode moveDown;

    public bool hasFish = false;

    public int fishPoints;

    private GameObject fish;
    public GameObject line;

    public Text fishScore;

    public int speed = 12;


    void Update()
    {
        if (Input.GetKey(moveUp) && (gameObject.transform.position.y <= min))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
        }
        else if (Input.GetKey(moveDown) && (gameObject.transform.position.y >= max))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed * -1);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }

        fishScore.text = fishPoints.ToString();

        line.GetComponent<LineRenderer>().SetPosition(1, new Vector3(this.gameObject.transform.position.x - 0.0625f, this.gameObject.transform.position.y, this.gameObject.transform.position.z));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Fish")
        {
            hasFish = true;
            fish = collision.gameObject;
        }

        if(collision.gameObject.tag == "FishBucket" && hasFish == true)
        {
            hasFish = false;
            Destroy(fish);
            fishPoints++;
        }
    }
}
