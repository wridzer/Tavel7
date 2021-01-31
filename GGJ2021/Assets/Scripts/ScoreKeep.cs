using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreKeep : MonoBehaviour
{

    static public int golf = 0, bump = 0, race = 0, fish = 0, date = 0, platform = 0, pet = 0;

    static public Vector3 lastPos;
    static public Quaternion lastRot;

    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        player.transform.position = lastPos;
        player.transform.rotation = lastRot;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Race()
    {
        race++; 
    }
    public void Golf()
    {
        golf++; 
    }
    public void Bump()
    {
        bump++; 
    }
    public void Fish()
    {
        fish++; 
    }
    public void Date()
    {
        date++; 
    }
    public void Platform()
    {
        platform++; 
    }
    public void Pet()
    {
        pet++; 
    }
    public void KeepPos(Vector3 Pos, Quaternion Rot)
    {
        lastPos = Pos;
        lastRot = Rot;
    }
}
