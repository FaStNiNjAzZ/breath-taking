using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeechEndgame : MonoBehaviour
{
    public GameObject speechAllUnlocks;
    public GameObject speechAllUnlocks1;
    public GameObject speechAllUnlocks2;
    public GameObject speechMilitaryUnlocks;
    public GameObject speechMilitaryUnlocks1;
    public GameObject speechMilitaryUnlocks2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
          //  speechUI1.SetActive(false);
           // speechUI1Path1.SetActive(false);
           // speechUI1Path2.SetActive(false);
        }
    }

    public void option1SpeechButton()
    {
       // speechUI1.SetActive(false);
       // speechUI1Path1.SetActive(true);
    }

    public void option2SpeechButton()
    {
       // speechUI1.SetActive(false);
        //speechUI1Path2.SetActive(true);
    }
}
