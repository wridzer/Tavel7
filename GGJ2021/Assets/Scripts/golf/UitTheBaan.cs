using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UitTheBaan : MonoBehaviour
{
    [SerializeField] float Xpos;
    [SerializeField] float Ypos;
    public GameObject Player;
    public Rigidbody2D rb2D;

    private void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.tag == "Player" && rb2D.velocity.magnitude < 0.1) {
            Player.transform.position = new Vector3(Xpos, Ypos, -1);
            rb2D.velocity = new Vector3(0, 0, 0);
        }
        
    }

    
    // Update is called once per frame
    void Update()
    {

    }
}
