using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    //Variables
    public float[] position;
    public string scene;
    public bool militaryUnlock;
    public bool factoryUnlock;

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
        PlayerData data = SaveSystem.LoadPlayerAuto();

        militaryUnlock = data.militaryUnlock;
        factoryUnlock = data.factoryUnlock;

        LoadGame2();
    }

    public void LoadGame2()
    {
        PlayerData2 data = SaveSystem.LoadPlayer();

        scene = data.scene;

        Application.LoadLevel(scene);

        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        transform.position = position;
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
