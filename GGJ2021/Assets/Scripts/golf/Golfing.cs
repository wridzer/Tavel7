using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golfing : MonoBehaviour
{
    [SerializeField]
    bool GolfHitCheck = false;
    public GameObject Mouse;
    public Rigidbody2D rb2D;

    [SerializeField]
    float distanceX;
    [SerializeField]
    float distanceY;
    [SerializeField]
    int GolfPower;

    private void OnMouseDown()
    {
        if (rb2D.velocity.magnitude < 0.1)
        { GolfHitCheck = true; }
    }

    private void OnMouseUp()
    {
        if (GolfHitCheck == true)
        {
            distanceX = Mouse.transform.position.x - this.gameObject.transform.position.x ;
            distanceY = Mouse.transform.position.y - this.gameObject.transform.position.y ;

            rb2D.AddForce(new Vector3(distanceX * Time.deltaTime * GolfPower,distanceY * Time.deltaTime * GolfPower ,0));

            

        }
        GolfHitCheck = false; 
    }

    void Update()
    {
    }
}
