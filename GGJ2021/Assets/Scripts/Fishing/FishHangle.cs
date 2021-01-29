using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FishHangle : MonoBehaviour
{
    private Vector3 mousePosition;
    public float max;

    public bool hasFish = false;

    public int fishPoints;

    private GameObject fish;

    public Text fishScore;


    void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        
        if(mousePosition.y <= max)
            transform.position = Vector2.Lerp(new Vector2(0, transform.position.y), new Vector2(0, mousePosition.y), .1f);

        fishScore.text = fishPoints.ToString();
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
