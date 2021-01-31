using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementFish : MonoBehaviour
{
    public GameObject CP1, CP2;
    private GameObject target;
    public float SPEED;
    private Vector3 scaleChange;

    public FishHangle fishH;
    public GameObject wayPoi;
    public Vector3 playerLoc;

    private bool caught;

    private void Start()
    {
        target = CP2;
        caught = false;
    }

    void Update()
    {
        playerLoc = new Vector3(transform.position.x, wayPoi.transform.position.y, transform.position.z);
        float step = SPEED * Time.deltaTime;

        if(target == CP1 || target == CP2)
            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, step);

        else if (target == fishH.gameObject)
            transform.position = target.transform.position;

        if(caught == true)
        {
            OnHangle();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == CP1)
        {
            target = CP2;
            Vector3 newScale = gameObject.transform.localScale;
            newScale.x *= -1;
            gameObject.transform.localScale = newScale;
        }
            

        if (collision.gameObject == CP2)
        {
            target = CP1;
            Vector3 newScale = gameObject.transform.localScale;
            newScale.x *= -1;
            gameObject.transform.localScale = newScale;
        }

        if (collision.gameObject.tag == "FishHangel" && fishH.hasFish == false && fishH.hasBadFish == false)
        {
            caught = true;
        }
    }

    public void OnHangle()
    {
        transform.position = playerLoc;
    }
}
