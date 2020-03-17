using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

    public GameObject loadingScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Extras()
    {
        Application.LoadLevel("Extras");
    }

    public void MainMenu()
    {
        Application.LoadLevel("MainMenuScene");
    }

    public void Options()
    {
        Application.LoadLevel("Options");
    }
    public void LoadGame()
    {
        Application.LoadLevel("LoadGame");
    }

    public void NewGame()
    {
        loadingScreen.SetActive(true);
        Application.LoadLevel("");
    }

    public void TestScene()
    {
        loadingScreen.SetActive(true);
        Application.LoadLevel("SampleScene");
    }

    public void Exit()
    {
        Application.Quit();
    }

}
