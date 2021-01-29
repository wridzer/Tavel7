using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    [SerializeField] private float timer;
    [SerializeField] private int min;
    [SerializeField] private bool started;
    private int fin = 0;

    // Start is called before the first frame update
    void Start()
    {
        started = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (fin >= 2)
        {
            started = false;
            if (timer >= 35)
            {
                Debug.Log("You Lose"); //Insert lose condition
            }
            if (timer < 35)
            {
                Debug.Log("You Win"); //Insert win condition
            }
        }
        if (started == true)
        {
            timer += Time.deltaTime;
            if (timer >= 60)
            {
                timer = 0;
                min++;
            }
        }
    }

    public void StartTimer()
    {
        started = true;
        fin++;
        Debug.Log("FINISH!");
    }
}
