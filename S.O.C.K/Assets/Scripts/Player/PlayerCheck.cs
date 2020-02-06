using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheck : MonoBehaviour
{
    //Determines which character is active
    public static bool ozulActive;
    public static bool cowboyActive;
    public static bool exloreActive;
    public static bool hackerActive;
    public static bool scientistActive;

    //Each Character
    public GameObject ozul;
    public GameObject cowboy;
    public GameObject exlore;
    public GameObject hacker;
    public GameObject scientist;

    /* On Start, depending on which character is chosen,
     * the chosen character will become activated,
     * and the other characters will be disabled
     */
    void Start()
    {
        if(ozulActive == true)
        {
            ozul.SetActive(true);
            cowboy.SetActive(false);
            exlore.SetActive(false);
            hacker.SetActive(false);
            scientist.SetActive(false);
        }
        else if (cowboyActive == true)
        {
            cowboy.SetActive(true);
            ozul.SetActive(false);
            exlore.SetActive(false);
            hacker.SetActive(false);
            scientist.SetActive(false);
        }
        else if (exloreActive == true)
        {
            exlore.SetActive(true);
            cowboy.SetActive(false);
            ozul.SetActive(false);
            hacker.SetActive(false);
            scientist.SetActive(false);
        }
        else if (hackerActive == true)
        {
            hacker.SetActive(true);
            ozul.SetActive(false);
            exlore.SetActive(false);
            cowboy.SetActive(false);
            scientist.SetActive(false);
        }
        else if (scientistActive == true)
        {
            scientist.SetActive(true);
            ozul.SetActive(false);
            exlore.SetActive(false);
            hacker.SetActive(false);
            cowboy.SetActive(false);
        }
    }
}
