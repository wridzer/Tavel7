using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnimCar : MonoBehaviour
{
    private GameObject target;
    public float moveSpeed = 2f;
    public float rotSpeed = 5f;
    [SerializeField] private Vector2 playerLoc;
    private Rigidbody2D rb;
    public GameObject corner0, corner1, corner2, corner3, corner4, corner5, corner6, corner7;
    List<GameObject> corners = new List<GameObject>();
    private int cornerCount;
    public GameObject gm;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = corner0;
        corners.Add(corner0);
        corners.Add(corner1);
        corners.Add(corner2);
        corners.Add(corner3);
        corners.Add(corner4);
        corners.Add(corner5);
        corners.Add(corner6);
        corners.Add(corner7);
        for (int i = 0; i == 7; i++)
        {
            GameObject curCor = corners[i];
            curCor.GetComponent<BoxCollider2D>().enabled = false;
        }
        target.GetComponent<BoxCollider2D>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        playerLoc = new Vector2(target.transform.position.x, target.transform.position.y);
        rb.transform.position = Vector2.MoveTowards(transform.position, playerLoc, moveSpeed * Time.deltaTime);

        Vector3 dir = target.transform.position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg * rotSpeed;
        rb.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Corner")
        {
            target.GetComponent<BoxCollider2D>().enabled = false;
            NextCorner();
        }
        if (collision.tag == "Finish")
        {
            gm.GetComponent<GameManger>().FinishE();
        }
    }
    void NextCorner()
    {
        cornerCount++;
        if(cornerCount > 7)
        {
            cornerCount = 0;
        }
        target = corners[cornerCount];
        target.GetComponent<BoxCollider2D>().enabled = true;
    }
}
