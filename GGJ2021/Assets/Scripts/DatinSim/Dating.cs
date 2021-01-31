using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dating : MonoBehaviour
{
    public AudioSource audioS;
    public AudioSource musicS;
    public AudioClip winSF;
    public AudioClip click;
    public AudioClip Lose;
    public AudioClip Music;
    public GameObject scoreKeep;

    public Image UlluIdel;
    public Image UlluConfu;
    public Image UlluShok;
    public Image UlluCrazy;
    public Image UlluIntres;
    public Image UlluHappy;

    public Image chadIdel;
    public Image chadCri;
    public Image chadHappy;
    public Image chadQes;
    public Image chadTumbup;
    public Image chadLift;
    public Image chadDissa;

    public Image startChad;
    public Image startUllu;

    public GameObject chad;
    public GameObject UWU;

    public GameObject C1Abutton;
    public GameObject C1Bbutton;
    public GameObject C1Cbutton;
    public GameObject C2Abutton;
    public GameObject C2Bbutton;
    public GameObject C2Cbutton;
    public GameObject C3Abutton;
    public GameObject C3Bbutton;
    public GameObject C3Cbutton;
    
    public GameObject U1Abutton;
    public GameObject U1Bbutton;
    public GameObject U1Cbutton;
    public GameObject U2Abutton;
    public GameObject U2Bbutton;
    public GameObject U2Cbutton;
    public GameObject U3Abutton;
    public GameObject U3Bbutton;
    public GameObject U3Cbutton;

    public GameObject RestartButton;

    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;

    public Text text5;
    public Text text6;
    public Text text7;
    public Text text8;
    public Text text9;
    public Text text10;
    public Text text11;
    public Text text12;
    public Text text13;
    public Text text14;
    public Text text15;
    public Text text16;

    public Text text17;
    public Text text18;
    public Text text19;
    public Text text20;
    public Text text21;
    public Text text22;
    public Text text23;
    public Text text24;
    public Text text25;
    public Text text26;
    public Text text27;
    public Text text28;
    public Text text29;
    public Text text30;
    public Text text31;
    public Text text32;
    public Text text33;
    public Text text34;
    public Text text35;
    public Text text36;
    public Text text37;
    public Text text38;
    public Text text39;
    public Text text40;
    public Text text41;
    public Text text42;
    public Text text43;
    public Text text44;
    public Text text45;

    public Text text46;
    public Text text47;
    public Text text48;
    public Text text49;
    public Text text50;
    public Text text51;
    public Text text52;
    public Text text53;
    public Text text54;
    public Text text55;
    public Text text56;
    public Text text57;
    public Text text58;
    public Text text59;
    public Text text60;
    public Text text61;
    public Text text62;
    public Text text63;
    public Text text64;
    public Text text65;
    public Text text66;
    public Text text67;
    public Text text68;
    public Text text69;
    public Text text70;
    public Text text71;
    public Text text72;
    public Text text73;
    public Text text74;
    public Text text75;
    public Text text76;
    public Text text77;
    public Text text78;
    public Text text79;
    public Text text80;

    void Start()
    {
        startFalse();
        StartCoroutine(BeginScene());
    }

    public void ChadRick()
    {
        StartCoroutine(ChadRickC());
    }
    public void C1A()
    {
        StartCoroutine(C1Ac());
    }
    public void C1B()
    {
        StartCoroutine(C1Bc());
    }
    public void C1C()
    {
        StartCoroutine(C1Cc());
    }
    public void C2A()
    {
        StartCoroutine(C2Ac());
    }
    public void C2B()
    {
        StartCoroutine(C2Bc());
    }
    public void C2C()
    {
        StartCoroutine(C2Cc());
    }
    public void C3A()
    {
        StartCoroutine(C3Ac());
    }
    public void C3B()
    {
        StartCoroutine(C3Bc());
    }
    public void C3C()
    {
        StartCoroutine(C3Cc());
    }

    public void UlluUWU()
    {
        StartCoroutine(UlluUWUC());
    }
    public void U1A()
    {
        StartCoroutine(U1Ac());
    }
    public void U1B()
    {
        StartCoroutine(U1Bc());
    }
    public void U1C()
    {
        StartCoroutine(U1Cc());
    }
    public void U2A()
    {
        StartCoroutine(U2Ac());
    }
    public void U2B()
    {
        StartCoroutine(U2Bc());
    }
    public void U2C()
    {
        StartCoroutine(U2Cc());
    }
    public void U3A()
    {
        StartCoroutine(U3Ac());
    }
    public void U3B()
    {
        StartCoroutine(U3Bc());
    }
    public void U3C()
    {
        StartCoroutine(U3Cc());
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            audioS.PlayOneShot(click);
        }
    }

    public IEnumerator BeginScene()
    {
        text1.enabled = true;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        startChad.enabled = true;
        startUllu.enabled = true;
        text1.enabled = false;
        chad.SetActive(true);
        UWU.SetActive(true);
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;
    }

    public IEnumerator ChadRickC()
    {
        //Chadrick.enabled = true;
        chad.SetActive(false);
        UWU.SetActive(false);
        startChad.enabled = false;
        startUllu.enabled = false;
        chadIdel.enabled = true;
        text2.enabled = true;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text2.enabled = false;
        text3.enabled = true;
        chadIdel.enabled = false;
        chadCri.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text3.enabled = false;
        text4.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        C1Abutton.SetActive(true);
        C1Bbutton.SetActive(true);
        C1Cbutton.SetActive(true);
        text4.enabled = false;
        yield return null;
    }
    public IEnumerator C1Ac()
    {
        C1Abutton.SetActive(false);
        C1Bbutton.SetActive(false);
        C1Cbutton.SetActive(false);
        text5.enabled = true;
        chadIdel.enabled = false;
        chadCri.enabled = false;
        chadDissa.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text5.enabled = false;
        text6.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text6.enabled = false;
        text7.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text7.enabled = false;
        text8.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text8.enabled = false;
        chadDissa.enabled = false;
        RestartButton.SetActive(true);
    }
    public IEnumerator C1Bc()
    {
        C1Abutton.SetActive(false);
        C1Bbutton.SetActive(false);
        C1Cbutton.SetActive(false);
        text9.enabled = true;
        chadIdel.enabled = false;
        chadCri.enabled = false;
        chadTumbup.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text9.enabled = false;
        text10.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text10.enabled = false;
        text11.enabled = true;
        chadTumbup.enabled = false;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text11.enabled = false;
        text12.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text12.enabled = false;
        RestartButton.SetActive(true);
    }
    public IEnumerator C1Cc()
    {
        C1Abutton.SetActive(false);
        C1Bbutton.SetActive(false);
        C1Cbutton.SetActive(false);
        chadIdel.enabled = false;
        chadCri.enabled = false;
        chadTumbup.enabled = true;
        text13.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text13.enabled = false;
        text14.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text14.enabled = false;
        text15.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text15.enabled = false;
        text16.enabled = true;
        chadTumbup.enabled = false;
        chadQes.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text16.enabled = false;
        C2Abutton.SetActive(true);
        C2Bbutton.SetActive(true);
        C2Cbutton.SetActive(true);
    }
    public IEnumerator C2Ac()
    {
        C2Abutton.SetActive(false);
        C2Bbutton.SetActive(false);
        C2Cbutton.SetActive(false);
        chadQes.enabled = false;
        chadDissa.enabled = true;
        text17.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text17.enabled = false;
        text18.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text18.enabled = false;
        chadDissa.enabled = false;
        RestartButton.SetActive(true);
    }
    public IEnumerator C2Bc()
    {
        C2Abutton.SetActive(false);
        C2Bbutton.SetActive(false);
        chadQes.enabled = false;
        chadDissa.enabled = true;
        C2Cbutton.SetActive(false);
        text19.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text19.enabled = false;
        text20.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text20.enabled = false;
        text21.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        chadDissa.enabled = false;
        chadCri.enabled = true;
        text21.enabled = false;
        text22.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text22.enabled = false;
        text23.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text23.enabled = false;
        chadCri.enabled = false;
        RestartButton.SetActive(true);
    }
    public IEnumerator C2Cc()
    {
        C2Abutton.SetActive(false);
        C2Bbutton.SetActive(false);
        C2Cbutton.SetActive(false);
        text24.enabled = true;
        chadQes.enabled = false;
        chadTumbup.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        chadTumbup.enabled = false;
        chadHappy.enabled = true;
        text24.enabled = false;
        text25.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text25.enabled = false;
        text26.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text26.enabled = false;
        text27.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text27.enabled = false;
        C3Abutton.SetActive(true);
        C3Bbutton.SetActive(true);
        C3Cbutton.SetActive(true);
    }
    public IEnumerator C3Ac()
    {
        C3Abutton.SetActive(false);
        C3Bbutton.SetActive(false);
        C3Cbutton.SetActive(false);
        chadHappy.enabled = false;
        chadQes.enabled = true;
        text28.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        chadTumbup.enabled = true;
        chadQes.enabled = false;
        text28.enabled = false;
        text29.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text29.enabled = false;
        text30.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text30.enabled = false;
        text31.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text31.enabled = false;
        text32.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null; text30.enabled = false;

        chadTumbup.enabled = false;
        chadLift.enabled = true;
        text32.enabled = false;
        text33.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null; text30.enabled = false;

        text33.enabled = false;
        text34.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null; text30.enabled = false;

        text34.enabled = false;
        chadLift.enabled = false;
        StartCoroutine(WinCond());
    }
    public IEnumerator C3Bc()
    {
        C3Abutton.SetActive(false);
        C3Bbutton.SetActive(false);
        C3Cbutton.SetActive(false);
        chadHappy.enabled = false;
        chadDissa.enabled = true;
        text35.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text35.enabled = false;
        text36.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        chadDissa.enabled = false;
        chadLift.enabled = true;
        text36.enabled = false;
        text37.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text37.enabled = false;
        text38.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text38.enabled = false;
        text39.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text39.enabled = false;
        chadLift.enabled = false;
        RestartButton.SetActive(true);
    }
    public IEnumerator C3Cc()
    {
        C3Abutton.SetActive(false);
        C3Bbutton.SetActive(false);
        C3Cbutton.SetActive(false);
        chadHappy.enabled = false;
        chadCri.enabled = true;
        text40.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text40.enabled = false;
        text41.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text41.enabled = false;
        text42.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text42.enabled = false;
        text43.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text43.enabled = false;
        text44.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text44.enabled = false;
        text45.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text45.enabled = false;
        chadCri.enabled = false;
        RestartButton.SetActive(true);
    }

    public IEnumerator UlluUWUC()
    {
        chad.SetActive(false);
        UWU.SetActive(false);
        startChad.enabled = false;
        startUllu.enabled = false;
        UlluIdel.enabled = true;
        text46.enabled = true;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        UlluIdel.enabled = false;
        UlluConfu.enabled = true;
        text46.enabled = false;
        text47.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text47.enabled = false;
        text48.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text48.enabled = false;
        text49.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text49.enabled = false;
        U1Abutton.SetActive(true);
        U1Bbutton.SetActive(true);
        U1Cbutton.SetActive(true);
        yield return null;
    }
    public IEnumerator U1Ac()
    {
        U1Abutton.SetActive(false);
        U1Bbutton.SetActive(false);
        U1Cbutton.SetActive(false);
        text50.enabled = true;
        UlluConfu.enabled = false;
        UlluShok.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text50.enabled = false;
        text51.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text51.enabled = false;
        UlluShok.enabled = false;
        RestartButton.SetActive(true);
    }
    public IEnumerator U1Bc()
    {
        U1Abutton.SetActive(false);
        U1Bbutton.SetActive(false);
        U1Cbutton.SetActive(false);
        text52.enabled = true;
        UlluConfu.enabled = false;
        UlluCrazy.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text52.enabled = false;
        text53.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text53.enabled = false;
        text54.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text54.enabled = false;
        UlluCrazy.enabled = false;
        RestartButton.SetActive(true);
    }
    public IEnumerator U1Cc()
    {
        U1Abutton.SetActive(false);
        U1Bbutton.SetActive(false);
        U1Cbutton.SetActive(false);
        text55.enabled = true;
        UlluConfu.enabled = false;
        UlluShok.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        UlluShok.enabled = false;
        UlluHappy.enabled = true;
        text55.enabled = false;
        text56.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text56.enabled = false;
        text57.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text57.enabled = false;
        text58.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        U2Abutton.SetActive(true);
        U2Bbutton.SetActive(true);
        U2Cbutton.SetActive(true);
        text58.enabled = false;
    }
    public IEnumerator U2Ac()
    {
        U2Abutton.SetActive(false);
        U2Bbutton.SetActive(false);
        U2Cbutton.SetActive(false);
        text59.enabled = true;
        UlluHappy.enabled = false;
        UlluShok.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        UlluShok.enabled = false;
        UlluHappy.enabled = true;
        text59.enabled = false;
        text60.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text60.enabled = false;
        text61.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        UlluHappy.enabled = false;
        UlluIdel.enabled = true;
        text61.enabled = false;
        text62.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        U3Abutton.SetActive(true);
        U3Bbutton.SetActive(true);
        U3Cbutton.SetActive(true);
        text62.enabled = false;
    }
    public IEnumerator U2Bc()
    {
        U2Abutton.SetActive(false);
        U2Bbutton.SetActive(false);
        U2Cbutton.SetActive(false);
        UlluHappy.enabled = false;
        UlluShok.enabled = true;
        text63.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text63.enabled = false;
        text64.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text64.enabled = false;
        UlluShok.enabled = false;
        RestartButton.SetActive(true);
    }
    public IEnumerator U2Cc()
    {
        U2Abutton.SetActive(false);
        U2Bbutton.SetActive(false);
        U2Cbutton.SetActive(false);
        UlluHappy.enabled = false;
        UlluCrazy.enabled = true;
        text65.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text65.enabled = false;
        text66.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text66.enabled = false;
        UlluCrazy.enabled = false;
        RestartButton.SetActive(true);
    }
    public IEnumerator U3Ac()
    {
        U3Abutton.SetActive(false);
        U3Bbutton.SetActive(false);
        U3Cbutton.SetActive(false);
        text67.enabled = true;
        UlluIdel.enabled = false;
        UlluShok.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        UlluShok.enabled = false;
        UlluCrazy.enabled = true;
        text67.enabled = false;
        text68.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text68.enabled = false;
        text69.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text70.enabled = false;
        UlluCrazy.enabled = false;
        RestartButton.SetActive(true);
    }
    public IEnumerator U3Bc()
    {
        U3Abutton.SetActive(false);
        U3Bbutton.SetActive(false);
        U3Cbutton.SetActive(false);
        text71.enabled = true;
        UlluIdel.enabled = false;
        UlluHappy.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        UlluIdel.enabled = true;
        UlluHappy.enabled = false;
        text71.enabled = false;
        text72.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text72.enabled = false;
        text73.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text73.enabled = false;
        UlluHappy.enabled = false;
        RestartButton.SetActive(true);
    }
    public IEnumerator U3Cc()
    {
        U3Abutton.SetActive(false);
        U3Bbutton.SetActive(false);
        U3Cbutton.SetActive(false);
        text74.enabled = true;
        UlluIdel.enabled = false;
        UlluHappy.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        UlluIdel.enabled = true;
        UlluHappy.enabled = false;
        text74.enabled = false;
        text75.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text75.enabled = false;
        text76.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text76.enabled = false;
        text77.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        UlluIdel.enabled = false;
        UlluHappy.enabled = true;
        text77.enabled = false;
        text78.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        UlluIdel.enabled = true;
        UlluHappy.enabled = false;
        text78.enabled = false;
        text79.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text79.enabled = false;
        text80.enabled = true;
        yield return null;

        while (!Input.GetMouseButtonDown(0))
            yield return null;

        text80.enabled = false;
        StartCoroutine(WinCond());
    }

    public void restartScreen()
    {
        SceneManager.LoadScene("DatingSim");
    }

    public void startFalse()
    {
        UlluCrazy.enabled = false;
        UlluConfu.enabled = false;
        UlluHappy.enabled = false;
        UlluIdel.enabled = false;
        UlluIntres.enabled = false;
        UlluShok.enabled = false;

        chadCri.enabled = false;
        chadHappy.enabled = false;
        chadIdel.enabled = false;
        chadLift.enabled = false;
        chadQes.enabled = false;
        chadTumbup.enabled = false;
        chadDissa.enabled = false;

        startChad.enabled = false;
        startUllu.enabled = false;

        chad.SetActive(false);
        UWU.SetActive(false);
        C1Abutton.SetActive(false);
        C1Bbutton.SetActive(false);
        C1Cbutton.SetActive(false);
        C2Abutton.SetActive(false);
        C2Bbutton.SetActive(false);
        C2Cbutton.SetActive(false);
        C3Abutton.SetActive(false);
        C3Bbutton.SetActive(false);
        C3Cbutton.SetActive(false);
        U1Abutton.SetActive(false);
        U1Bbutton.SetActive(false);
        U1Cbutton.SetActive(false);
        U2Abutton.SetActive(false);
        U2Bbutton.SetActive(false);
        U2Cbutton.SetActive(false);
        U3Abutton.SetActive(false);
        U3Bbutton.SetActive(false);
        U3Cbutton.SetActive(false);
        RestartButton.SetActive(false);

        text1.enabled = false;
        text2.enabled = false;
        text3.enabled = false;
        text4.enabled = false;
        text5.enabled = false;
        text6.enabled = false;
        text7.enabled = false;
        text8.enabled = false;
        text9.enabled = false;
        text10.enabled = false;
        text11.enabled = false;
        text12.enabled = false;
        text13.enabled = false;
        text14.enabled = false;
        text15.enabled = false;
        text16.enabled = false;
        text17.enabled = false;
        text18.enabled = false;
        text19.enabled = false;
        text20.enabled = false;
        text21.enabled = false;
        text22.enabled = false;
        text23.enabled = false;
        text24.enabled = false;
        text25.enabled = false;
        text26.enabled = false;
        text27.enabled = false;
        text28.enabled = false;
        text29.enabled = false;
        text30.enabled = false;
        text31.enabled = false;
        text32.enabled = false;
        text33.enabled = false;
        text34.enabled = false;
        text35.enabled = false;
        text36.enabled = false;
        text37.enabled = false;
        text38.enabled = false;
        text39.enabled = false;
        text40.enabled = false;
        text41.enabled = false;
        text42.enabled = false;
        text43.enabled = false;
        text44.enabled = false;
        text45.enabled = false;
        text46.enabled = false;
        text47.enabled = false;
        text48.enabled = false;
        text49.enabled = false;
        text50.enabled = false;
        text51.enabled = false;
        text52.enabled = false;
        text53.enabled = false;
        text54.enabled = false;
        text55.enabled = false;
        text56.enabled = false;
        text57.enabled = false;
        text58.enabled = false;
        text59.enabled = false;
        text60.enabled = false;
        text61.enabled = false;
        text62.enabled = false;
        text63.enabled = false;
        text64.enabled = false;
        text65.enabled = false;
        text66.enabled = false;
        text67.enabled = false;
        text68.enabled = false;
        text69.enabled = false;
        text70.enabled = false;
        text71.enabled = false;
        text72.enabled = false;
        text73.enabled = false;
        text74.enabled = false;
        text75.enabled = false;
        text76.enabled = false;
        text77.enabled = false;
        text78.enabled = false;
        text79.enabled = false;
        text80.enabled = false;
    }

    public IEnumerator WinCond()
    {
        audioS.PlayOneShot(winSF);
        yield return new WaitForSeconds(1);
        scoreKeep.GetComponent<ScoreKeep>().Date();
        SceneManager.LoadScene(7);
    }
}
