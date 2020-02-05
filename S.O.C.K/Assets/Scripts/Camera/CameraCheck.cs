using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCheck : MonoBehaviour
{
    //First person camera
    public GameObject firstPerson;
    //Third person camera
    public GameObject thirdPerson;

    //Boolean that determines wether the game is in first person or not
    private bool firstActive;

    //On Start, the game is in first person
    void Start()
    {
        firstActive = true;
    }

    /* If the player presses F5, the game will switch to first person.
     * If the player presses F6, the game will switch to third person.
     */
    void Update()
    {
        if(firstActive == true)
        {
            firstPerson.SetActive(true);
            thirdPerson.SetActive(false);
        }
        else
        {
            firstPerson.SetActive(false);
            thirdPerson.SetActive(true);
        }

        if (Input.GetKey(KeyCode.F5))
        {
            firstActive = true;
        }
        else if (Input.GetKey(KeyCode.F6))
        {
            firstActive = false;
        }
    }
}
