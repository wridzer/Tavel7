using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnimFollow : MonoBehaviour
{
    private GameObject Player;
    public float moveSpeed = 2f;
    public float rotSpeed = 5f;
    [SerializeField] private Vector2 playerLoc;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        playerLoc = new Vector2(Player.transform.position.x, Player.transform.position.y);
        rb.transform.position = Vector2.MoveTowards(transform.position, playerLoc, moveSpeed * Time.deltaTime);
        //rb.transform.LookAt(Player.transform);

        Vector3 dir = Player.transform.position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
