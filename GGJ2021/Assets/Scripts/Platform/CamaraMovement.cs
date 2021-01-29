using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraMovement : MonoBehaviour
{
    public GameObject Player;
    float transitionSpeed = 4;
    // Start is called before the first frame update
    void Start()
    {
        //joppe hou je bek
    }

        // Update is called once per frame
        void FixedUpdate()
        {
            transform.position = transform.position = Vector3.Lerp(transform.position, new Vector3(Player.transform.position.x + 2, transform.position.y, transform.position.z), Time.deltaTime * transitionSpeed); ;

        }
   
}

