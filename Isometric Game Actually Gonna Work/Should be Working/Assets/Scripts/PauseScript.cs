using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    //variables
    public static bool pauseCheck = false;

    public GameObject pauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Escape key");
            if (pauseCheck == false)
            {
                Debug.Log("Pause on");
                OpenPauseMenu();
            }

            else
            {
                Debug.Log("Pause off");
                ClosePauseMenu();
            }

        }
    }
    public void OpenPauseMenu()
    {
        pauseMenu.SetActive(true);
        pauseCheck = true;
        Time.timeScale = 0.0f;
    }

    public void ClosePauseMenu()
    {
        pauseMenu.SetActive(false);
        pauseCheck = false;
        Time.timeScale = 1f;
    }
}
