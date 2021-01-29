using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishHangle : MonoBehaviour
{
    private Vector3 mousePosition;
    public float max;

    void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        
        if(mousePosition.y <= max)
            transform.position = Vector2.Lerp(new Vector2(0, transform.position.y), new Vector2(0, mousePosition.y), .1f);

    }
}
