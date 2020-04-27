using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndSceneScript : MonoBehaviour
{

    public GameObject Canvas1;
    public GameObject Canvas2;
    public GameObject loadingScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextButton()
    {
        Canvas1.SetActive(false);
        Canvas2.SetActive(true);
    }

    public void ExitButton()
    {
        loadingScreen.SetActive(true);
        Application.LoadLevel("MainMenuScene");
    }
}