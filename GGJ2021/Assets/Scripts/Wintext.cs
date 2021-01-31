using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wintext : MonoBehaviour
{
    public GameObject winText;

    // Update is called once per frame
    void Update()
    {
        if (ScoreKeep.golf > 0 && ScoreKeep.bump > 0 && ScoreKeep.race > 0 && ScoreKeep.fish > 0 && ScoreKeep.date > 0 && ScoreKeep.platform > 0)
        {
            winText.SetActive(true);
        }
    }
}
