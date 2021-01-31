using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golfing : MonoBehaviour
{
    [SerializeField]
    bool GolfHitCheck = false;
    public GameObject Mouse;
    public Rigidbody2D rb2D;
    public GameObject Line;

    [SerializeField] int AantalBinnen;

    [SerializeField]
    float distanceX;
    [SerializeField]
    float distanceY;
    [SerializeField]
    int GolfPower;


    private void OnMouseDown()
    {
        if (rb2D.velocity.magnitude < 0.1)
        {
            GolfHitCheck = true;
        }
    }

    private void OnMouseUp()
    {
        if (GolfHitCheck == true)
        {
            distanceX = Mouse.transform.position.x - this.gameObject.transform.position.x ;
            distanceY = Mouse.transform.position.y - this.gameObject.transform.position.y ;

            rb2D.AddForce(new Vector2(Mathf.Clamp(distanceX,-4,4) * GolfPower,Mathf.Clamp(distanceY,-4,4) * GolfPower));
        }
        GolfHitCheck = false; 
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Terrain")
        {
            AantalBinnen++;
        }

    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.tag == "Terrain")
        {
            AantalBinnen--;
        }

    }

    void Update()
    {
        if (AantalBinnen > 0)
        {
            rb2D.drag = 30f;
        }
        else
        {
            rb2D.drag = 1.5f;
        }

        if (GolfHitCheck == true)
        {   
            Line.GetComponent<LineRenderer>().SetPosition(0, new Vector3 (Mathf.Clamp(Mouse.transform.position.x,-4 + this.gameObject.transform.position.x, 4 + this.gameObject.transform.position.x), Mathf.Clamp(Mouse.transform.position.y,-4 + this.gameObject.transform.position.y, 4 + this.gameObject.transform.position.y),0));
            Line.GetComponent<LineRenderer>().SetPosition(1, this.gameObject.transform.position);
        }
        else
        {
            Line.GetComponent<LineRenderer>().SetPosition(0, new Vector3(0,0,0));
            Line.GetComponent<LineRenderer>().SetPosition(1, new Vector3(0,0,0));
        }
    }
}
