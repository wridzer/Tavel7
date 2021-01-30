using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golfing : MonoBehaviour
{
    [SerializeField]
    bool GolfHitCheck = false;
        
    private void OnMouseDown()
    {
        GolfHitCheck = true;
    }

    private void OnMouseUp()
    {
        if (GolfHitCheck = true)
        {}
        GolfHitCheck = false; 
    }

    void Update()
    {
        
    }
}
