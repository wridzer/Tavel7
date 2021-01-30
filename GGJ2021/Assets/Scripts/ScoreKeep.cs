using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreKeep : MonoBehaviour
{

    static public int golf = 0, bump = 0, race = 0, fish = 0, date = 0, platform = 0, pet = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (race == 1 && SceneManager.sceneCount == 1)
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            player.transform.position = new Vector3(0.586f, 0.87f, 3f);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Race()
    {
        race++; 
    }
}
