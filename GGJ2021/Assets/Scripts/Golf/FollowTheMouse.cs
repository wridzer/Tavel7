using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTheMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 MouseFollow = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = MouseFollow;
    }
}
