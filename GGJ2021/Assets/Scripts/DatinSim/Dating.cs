using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dating : MonoBehaviour
{
    public Image main;
    public Image sean;
    public Image youri;
    public Image wridzer;
    public Image joppe;

    public Text text1;

    void Start()
    {
        startFalse();
    }

    void Update()
    {
        
    }

    public IEnumerator NextText()
    {
        //tekst

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        //tekst

        yield return null;
    }

    public void startFalse()
    {
        main.enabled = false;
        sean.enabled = false;
        youri.enabled = false;
        wridzer.enabled = false;
        joppe.enabled = false;

        text1.enabled = false;
    }
}
