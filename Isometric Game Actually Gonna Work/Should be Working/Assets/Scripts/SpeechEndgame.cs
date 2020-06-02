using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeechEndgame : MonoBehaviour
{
    public GameObject speechAllUnlocks;
    public GameObject speechAllUnlocks1;
    public GameObject speechAllUnlocks2;
    public GameObject speechAllUnlocks3;
    public GameObject speechMilitaryUnlocks;
    public GameObject speechMilitaryUnlocks1;
    public GameObject speechMilitaryUnlocks2;
    public GameObject speechFactoryUnlocks;
    public GameObject speechFactoryUnlocks1;
    public GameObject speechFactoryUnlocks2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
          //speechUI1.SetActive(false);
           // speechUI1Path1.SetActive(false);
           // speechUI1Path2.SetActive(false);
        }
    }

    //All Unlock Buttons
    public void option1SpeechAllUnlocksButton()
    {
        speechAllUnlocks.SetActive(false);
        speechAllUnlocks1.SetActive(true);
    }

    public void option2SpeechAllUnlocksButton()
    {
        speechAllUnlocks.SetActive(false);
        speechAllUnlocks2.SetActive(true);
    }

    public void option3SpeechAllUnlocksButton()
    {
        speechAllUnlocks.SetActive(false);
        speechAllUnlocks3.SetActive(true);
    }

    //Military Unlock Buttons
    public void option1SpeechMilitaryUnlocksButton()
    {
        speechMilitaryUnlocks.SetActive(false);
        speechMilitaryUnlocks1.SetActive(true);
    }

    public void option2SpeechMilitaryUnlocksButton()
    {
        speechMilitaryUnlocks.SetActive(false);
        speechMilitaryUnlocks2.SetActive(true);
    }

    //Factory Unlock Buttons
    public void option1SpeechFactoryUnlocksButton()
    {
        speechFactoryUnlocks.SetActive(false);
        speechFactoryUnlocks1.SetActive(true);
    }

    public void option2SpeechFactoryUnlocksButton()
    {
        speechFactoryUnlocks.SetActive(false);
        speechFactoryUnlocks2.SetActive(true);
    }

    //No Option Button
    public void NoOptionButton()
    {
        speechAllUnlocks.SetActive(false);
        speechFactoryUnlocks.SetActive(false);
        speechMilitaryUnlocks.SetActive(false);
        speechAllUnlocks3.SetActive(true);
    }
}
