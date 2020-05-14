using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speech : MonoBehaviour
{
    public GameObject speechUI1;
    public GameObject speechUI1Path1;
    public GameObject speechUI1Path2;

    PlayerData player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            speechUI1.SetActive(false);
            speechUI1Path1.SetActive(false);
            speechUI1Path2.SetActive(false);
        }
    }

    public void option1SpeechButton()
    {
        speechUI1.SetActive(false);
        speechUI1Path1.SetActive(true);
        //player.factoryUnlock = true;
    }

    public void option2SpeechButton()
    {
        speechUI1.SetActive(false);
        speechUI1Path2.SetActive(true);
    }

    public void Ending1()
    {
        Application.LoadLevel("Ending1");
    }

    public void Ending2()
    {
        Application.LoadLevel("Ending2");
    }

    public void Ending3()
    {
        Application.LoadLevel("Ending3");
    }
}
