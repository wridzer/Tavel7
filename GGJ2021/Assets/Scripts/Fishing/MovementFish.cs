using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementFish : MonoBehaviour
{
    public GameObject CP1, CP2;
    private GameObject target;
    public float SPEED;

    public FishHangle fishH;

    private void Start()
    {
        target = CP2;
    }

    void Update()
    {
        float step = SPEED * Time.deltaTime;

        if(target == CP1 || target == CP2)
            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, step);

        else if (target == fishH.gameObject)
            transform.position = target.transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == CP1)
            target = CP2;

        if (collision.gameObject == CP2)
            target = CP1;

        if (collision.gameObject.tag == "FishHangel" && fishH.hasFish == false)
        {
            target = collision.gameObject;
        }
    }
}
