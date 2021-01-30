using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaasEiland : MonoBehaviour
{
    public GameObject Railz;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Railz.GetComponent<SpriteRenderer>().enabled = true;
    }
}
