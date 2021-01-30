using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dating : MonoBehaviour
{
    public Image main;
    public Image Chadrick;
    public Image Ullu;

    public GameObject chad;
    public GameObject UWU;

    public Text text1;
    public Text text2;
    public Text text3;

    void Start()
    {
        startFalse();

        StartCoroutine(BeginScene());
    }

    void Update()
    {
        
    }

    public void ChadRick()
    {
        StartCoroutine(ChadRickC());
    }
    public void UlluUWU()
    {
        StartCoroutine(UlluUWUC());
    }

    public IEnumerator BeginScene()
    {
        main.enabled = true;
        text1.enabled = true;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text1.enabled = false;
        chad.SetActive(true);
        UWU.SetActive(true);
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;
    }

    public IEnumerator ChadRickC()
    {
        chad.SetActive(false);
        UWU.SetActive(false);
        text2.enabled = true;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text3.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;
    }
    public IEnumerator UlluUWUC()
    {
        chad.SetActive(false);
        UWU.SetActive(false);

        while (!Input.GetMouseButtonDown(0))
            yield return null;
    }

    public void startFalse()
    {
        main.enabled = false;
        Chadrick.enabled = false;
        Ullu.enabled = false;

        //buttons
        chad.SetActive(false);
        UWU.SetActive(false);

        //tekst
        text1.enabled = false;
        text2.enabled = false;
        text3.enabled = false;
    }
}
