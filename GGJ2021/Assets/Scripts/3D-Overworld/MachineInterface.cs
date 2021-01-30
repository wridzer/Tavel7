using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MachineInterface : MonoBehaviour
{
    public Scene minigame;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(minigame != null)
        {
            //start animation
            string sceneName = minigame.name;
            SceneManager.LoadScene(sceneName);
        }
    }
}
