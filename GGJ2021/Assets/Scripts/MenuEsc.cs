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
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0;
        }
    }

    public void Resume()
    {
        Menu.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
    }

    public void Arcade()
    {
        SceneManager.LoadScene(1);
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
    }

    public void Exit()
    {
        Application.Quit();
    }
}
