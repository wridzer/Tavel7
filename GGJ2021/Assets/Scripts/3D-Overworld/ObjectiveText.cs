using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveText : MonoBehaviour
{
    [SerializeField] private GameObject text;

    // Start is called before the first frame update
    private void Awake()
    {
        StartCoroutine(TextDissapear());
    }

    public IEnumerator TextDissapear()
    {
        yield return new WaitForSeconds(5);
        text.SetActive(false);
    }
}
