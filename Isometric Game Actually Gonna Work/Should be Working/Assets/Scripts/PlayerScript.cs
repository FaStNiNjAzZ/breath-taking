using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    //Variables
    public int moveSpeed = 5;
    public static bool UICheck = false;
    Rigidbody2D myRigidBody;
    public string scene;
    public bool militaryUnlock = false;
    public bool factoryUnlock = false;

    public AudioClip doorClose;
    public AudioClip boxOpen;

    //Holy shit that's a lot of Game Objects
    public GameObject containerUI;
    public GameObject intrustionTextOpen;
    public GameObject intrustionTextSpeech;
    public GameObject exitCanvas;

    //Speech Game Objects
    public GameObject speechUI;
    public GameObject speechUI1;
    public GameObject speechUI2;

    public GameObject speechAllUnlocks;
    public GameObject speechAllUnlocks1;
    public GameObject speechAllUnlocks2;

    public GameObject speechMilitaryUnlocks;
    public GameObject speechMilitaryUnlocks1;
    public GameObject speechMilitaryUnlocks2;

    public GameObject speechFactoryUnlocks;
    public GameObject speechFactoryUnlocks1;
    public GameObject speechFactoryUnlocks2;

    //Other Game Objects
    public GameObject loadingScreen;

    // Start is called before the first frame update
    void  Start()
    {
        Debug.Log(scene);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            ExitSpeech();
        }
    }

    void OnCollisionStay2D(Collision2D other)
    {
        if (other.collider.tag == "Container")
        {
            intrustionTextOpen.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (UICheck == false)
                {
                    militaryUnlock = true;
                    OpenContainerMenu();
                }
            }
        }
        if (other.collider.tag == "GenericNPC1")
        {
            intrustionTextSpeech.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (UICheck == false)
                {
                    OpenSpeech();
                    OpenExitCanvas();
                }
            }
        }

        if (other.collider.tag == "GenericNPC2")
        {
            LoadPlayer();
            intrustionTextSpeech.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (UICheck == false)
                {
                    if (militaryUnlock == true && factoryUnlock == true)
                    {
                        OpenSpeechAllUnlocks();
                        OpenExitCanvas();
                    }

                    if (militaryUnlock == true && factoryUnlock == false)
                    {
                        OpenSpeechMilitaryUnlocks();
                        OpenExitCanvas();
                    }

                    if (militaryUnlock == false && factoryUnlock == true)
                    {
                        OpenSpeechFactoryUnlocks();
                        OpenExitCanvas();
                    }
                }
            }
        }

        if (other.collider.tag == "Door1")
        {
            intrustionTextOpen.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (UICheck == false)
                {
                    Interior1();
                    
                }
            }
        }

        if (other.collider.tag == "Door2")
        {
            intrustionTextOpen.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (UICheck == false)
                {
                    Interior2();
                }
            }
        }

        if (other.collider.tag == "Door3")
        {
            intrustionTextOpen.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (UICheck == false)
                {
                    Outside();
                }
            }
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.collider.tag == "Container")
        {
            intrustionTextOpen.SetActive(false);
        }

        if (other.collider.tag == "GenericNPC1")
        {
            intrustionTextSpeech.SetActive(false);
        }

        if (other.collider.tag == "GenericNPC2")
        {
            intrustionTextSpeech.SetActive(false);
        }
    }


    public void ExitContainerMenu()
    {
        containerUI.SetActive(false);
        Time.timeScale = 1f;
        UICheck = false;
    }

    public void OpenContainerMenu()
    {
        containerUI.SetActive(true);
        Time.timeScale = 0.0f;
        UICheck = true;
    }

    public void ExitSpeech()
    {
        speechUI.SetActive(false);
        speechUI1.SetActive(false);
        speechUI2.SetActive(false);

        Time.timeScale = 1f;
        UICheck = false;
        CloseExitCanvas();
        SavePlayer();
    }

    public void ExitSpeech1()
    {
        speechAllUnlocks.SetActive(false);
        speechAllUnlocks1.SetActive(false);
        speechAllUnlocks2.SetActive(false);

        speechMilitaryUnlocks.SetActive(false);
        speechMilitaryUnlocks1.SetActive(false);
        speechMilitaryUnlocks2.SetActive(false);

        speechFactoryUnlocks.SetActive(false);
        speechFactoryUnlocks1.SetActive(false);
        speechFactoryUnlocks2.SetActive(false);

        Time.timeScale = 1f;
        UICheck = false;
        CloseExitCanvas();
    }

    public void OpenSpeech()
    {
        speechUI.SetActive(true);
        Time.timeScale = 0.0f;
        UICheck = true;
    }

    public void OpenSpeechAllUnlocks()
    {
        speechAllUnlocks.SetActive(true);
        Time.timeScale = 0.0f;
        UICheck = true;
    }

    public void OpenSpeechMilitaryUnlocks()
    {
        speechMilitaryUnlocks.SetActive(true);
        Time.timeScale = 0.0f;
        UICheck = true;
    }

    //Factory Speech
    public void OpenSpeechFactoryUnlocks()
    {
        speechFactoryUnlocks.SetActive(true);
        Time.timeScale = 0.0f;
        UICheck = true;
    }

    public void Option1SpeechFactoryUnlocks()
    {
        speechFactoryUnlocks.SetActive(false);
        speechFactoryUnlocks1.SetActive(true);
    }

    public void Option2SpeechFactoryUnlocks()
    {
        speechFactoryUnlocks.SetActive(false);
        speechFactoryUnlocks2.SetActive(true);
    }


    public void OpenExitCanvas()
    {
        exitCanvas.SetActive(true);
    }

    public void CloseExitCanvas()
    {
        exitCanvas.SetActive(false);
    }

    public void Outside()
    {
        Application.LoadLevel("MainWorld");
    }

    public void Interior1()
    {
        Application.LoadLevel("Inside1");
        LoadPlayer();
    }

    public void Interior2()
    {
        Application.LoadLevel("Inside2");
        LoadPlayer();
    }

    //Speech
    public void option1SpeechButton()
    {
        speechUI.SetActive(false);
        speechUI1.SetActive(true);
        factoryUnlock = true;
        SavePlayer();
    }

    public void option2SpeechButton()
    {
        speechUI1.SetActive(false);
        speechUI2.SetActive(true);
        militaryUnlock = true;
        SavePlayer();
    }

    //Endings
    public void NoChoiceEnding()
    {
        Application.LoadLevel("Ending3");
    }

    public void FactoryChoiceEnding()
    {
        Application.LoadLevel("Ending2");
    }

    public void MilitaryChoiceEnding()
    {
        Application.LoadLevel("Ending1");
    }


    //Save and Load Functions
    public void SavePlayer()
    {
        SaveSystem.SavePlayerAuto(this);
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayerAuto();

        militaryUnlock = data.militaryUnlock;
        factoryUnlock = data.factoryUnlock;

        //scene = data.scene;

        //Application.LoadLevel(scene);

        //Vector3 position;
        //position.x = data.position[0];
        //position.y = data.position[1];
        //position.z = data.position[2];
        //transform.position = position;
    }



    //Main Menu Stuff

    public void NewGameButton()
    {
        loadingScreen.SetActive(true);
        Debug.Log(scene);
        Application.LoadLevel("MainWorld");

        militaryUnlock = false;
        factoryUnlock = false;
        scene = "MainWorld";
        Debug.Log(scene);
        SaveSystem.SavePlayer(this);
        SaveSystem.SavePlayerAuto(this);
        Debug.Log(scene);
    }

    public void LoadGame()
    {
        PlayerData data = SaveSystem.LoadPlayerAuto();

        militaryUnlock = data.militaryUnlock;
        factoryUnlock = data.factoryUnlock;
    }

    public void LoadGame2()
    {
        PlayerData2 data = SaveSystem.LoadPlayer();

        

        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        transform.position = position;
        scene = data.scene;

        Application.LoadLevel(scene);

        Debug.Log(scene);
    }
}
