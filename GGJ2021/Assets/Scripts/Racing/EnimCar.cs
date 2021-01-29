using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnimCar : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float rotSpeed = 5f;
    [SerializeField] private Vector2 playerLoc;
    private Rigidbody2D rb;
    public GameObject corner0, corner1, corner2, corner3, corner4, corner5, corner6, corner7;
    List<GameObject> corners;
    private GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = corner0;
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
        if(collision.tag == "Corner")
        {
            NextCorner();
        }
    }

    void NextCorner()
    {
        if(target == corner0)
        {
            target = corner1;
        }
        if(target == corner1)
        {
            target = corner2;
        }
        if(target == corner2)
        {
            target = corner3;
        }
        if(target == corner3)
        {
            target = corner4;
        }
        if(target == corner4)
        {
            target = corner5;
        }
        if(target == corner5)
        {
            target = corner6;
        }
        if(target == corner6)
        {
            target = corner7;
        }
        if(target == corner7)
        {
            target = corner0;
        }
    }
}
