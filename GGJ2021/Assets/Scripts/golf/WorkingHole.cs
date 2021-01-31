using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkingHole : MonoBehaviour
{
    [SerializeField] float Xpos;
    [SerializeField] float Ypos;
    [SerializeField] float XposSpeed;
    [SerializeField] float YposSpeed;

    public GameObject Player;
    public Rigidbody2D rb2D;
    public GameObject camara;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (rb2D.velocity.magnitude < 3)
        {
            Player.transform.position = new Vector3(Xpos, Ypos, -1);
            rb2D.velocity = new Vector3(XposSpeed, YposSpeed, 0);
            StartCoroutine(CameraDelay());
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    

    private IEnumerator CameraDelay()
        {
        yield return new WaitForSeconds(2);
        camara.transform.position = new Vector3(camara.transform.position.x + 20, 1, -10);
        
        }

}
