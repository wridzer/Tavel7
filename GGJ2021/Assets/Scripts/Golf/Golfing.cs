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
        GolfHitCheck = false; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
