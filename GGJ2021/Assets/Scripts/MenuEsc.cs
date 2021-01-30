using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuEsc : MonoBehaviour
{
    public GameObject Menu;

    private void Start()
    {
        Menu.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Menu.SetActive(true);
        }
    }

    public void Resume()
    {
        Menu.SetActive(false);
    }

    public void Arcade()
    {
        SceneManager.LoadScene("TODO"); //insert 3d world
    }

    public void Exit()
    {
        Application.Quit();
    }
}
