using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    //Variables
    public int moveSpeed = 5;
    public static bool UICheck = false;
    public GameObject containerUI;
    public GameObject speechUI;
    Rigidbody2D myRigidBody;

    // Start is called before the first frame update
    void Start()
    {

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

       
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Container")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (UICheck == true)
                {
                    exitContainerMenu();
                }
                else
                {
                    openContainerMenu();
                }
            }
        }
        if (other.tag == "GenericNPC1")
        {
            if (UICheck == true)
            {
                exitSpeech();
            }
            else
            {
                openSpeech();
            }
        }

    }


    public void exitContainerMenu()
    {
        containerUI.SetActive(false);
        Time.timeScale = 1f;
        UICheck = false;
    }

    public void openContainerMenu()
    {
        containerUI.SetActive(true);
        Time.timeScale = 0.0f;
        UICheck = true;
    }

    public void exitSpeech()
    {
        containerUI.SetActive(false);
        Time.timeScale = 1f;
        UICheck = false;
    }

    public void openSpeech()
    {
        containerUI.SetActive(true);
        Time.timeScale = 0.0f;
        UICheck = true;
    }
}
