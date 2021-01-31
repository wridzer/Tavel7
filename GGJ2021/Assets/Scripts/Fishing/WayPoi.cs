using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoi : MonoBehaviour
{
    private float timer = 0.5f;
    public GameObject wayPoi;
    Vector3 wp;

    // Start is called before the first frame update
    void Start()
    {
        wp = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0)
        {
            UpdatePosition();
            timer = 0.1f;
        }
    }
    void UpdatePosition()
    {
        wayPoi.transform.position = transform.position + wp;
    }
}
