using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartTime : MonoBehaviour
{
    private int startCount = 3;
    private float startCountDis = 3;
    public GameObject startCounter;

    void Awake()
    {
        StartCoroutine(StartCount());
    }

    // Update is called once per frame
    void Update()
    {

        startCounter.GetComponent<Text>().text = Mathf.FloorToInt(startCountDis).ToString();
    }

    public IEnumerator StartCount()
    {
        startCounter.SetActive(true);
        startCountDis -= 1 * Time.deltaTime;
        Time.timeScale = 0;
        yield return new WaitForSeconds(startCount);
        Time.timeScale = 1;
        startCounter.SetActive(false);
    }
}
