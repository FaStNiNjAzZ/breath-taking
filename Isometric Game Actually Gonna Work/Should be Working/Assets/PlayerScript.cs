using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    //Variables
    public int moveSpeed = 5;
    public static bool UICheck = false;
    public GameObject containerUI;
    public GameObject speechUI1;
    public GameObject speechUI1Path1;
    public GameObject speechUI1Path2;
    public GameObject intrustionTextOpen;
    public GameObject intrustionTextSpeech;
    public GameObject exitCanvas;
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

    void OnCollisionStay2D(Collision2D other)
    {
        Debug.Log("I guess it's colliding");
        if (other.collider.tag == "Container")
        {
            intrustionTextOpen.SetActive(true);
            Debug.Log("I guess it's detecting a tag");
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (UICheck == false)
                {
                    Debug.Log("Clicking E");
                    openContainerMenu();
                }
            }
        }
        if (other.collider.tag == "GenericNPC1")
        {
            Debug.Log("I guess E");
            intrustionTextSpeech.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (UICheck == false)
                {
                    openSpeech();
                    openExitCanvas();
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
        speechUI1.SetActive(false);
        speechUI1Path1.SetActive(false);
        speechUI1Path2.SetActive(false);
        Time.timeScale = 1f;
        UICheck = false;
        closeExitCanvas();
    }

    public void openSpeech()
    {
        speechUI1.SetActive(true);
        Time.timeScale = 0.0f;
        UICheck = true;
    }
    
    public void openExitCanvas()
    {
        exitCanvas.SetActive(true);
    }

    public void closeExitCanvas()
    {
        exitCanvas.SetActive(false);
    }
}
