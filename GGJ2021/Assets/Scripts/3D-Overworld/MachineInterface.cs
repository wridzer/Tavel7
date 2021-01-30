using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MachineInterface : MonoBehaviour
{
    public int minigame;
    public Text outOfOrder;
    public Text interText;

    public GameObject player, cutSceneCam;

    public void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            if (minigame != 0)
            {
                StartCoroutine(CutScene());
            }
            if (minigame == 0)
            {
                StartCoroutine(textGone());
            }
        } else
        {
            interText.GetComponent<Text>().enabled = true;
        }
    }

    public IEnumerator textGone()
    {
        outOfOrder.GetComponent<Text>().enabled = true;
        yield return new WaitForSeconds(1.5f);
        outOfOrder.GetComponent<Text>().enabled = false;
    }

    public IEnumerator CutScene()
    {
        cutSceneCam.SetActive(true);
        player.SetActive(false);
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(minigame);
    }
}
