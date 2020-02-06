using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerSelect : MonoBehaviour
{
    //Level that loads when pressed
    public string newLevel;

    //Determines which player is being pressed
    public Button player;

    //Required for the button to work
    void Start()
    {
        player.onClick.AddListener(taskOnClick);
    }

    /* Depending on which button the player presses,
     * it will load the corresponding character,
     * and will load the newLevel
     */
    void taskOnClick()
    {
        switch (player.tag)
        {
            case "Cowboy":
                {
                    PlayerCheck.ozulActive = false;
                    PlayerCheck.cowboyActive = true;
                    PlayerCheck.exloreActive = false;
                    PlayerCheck.hackerActive = false;
                    PlayerCheck.scientistActive = false;
                    SceneManager.LoadScene(newLevel);
                }
                break;
            case "Ozul":
                {
                    PlayerCheck.ozulActive = true;
                    PlayerCheck.cowboyActive = false;
                    PlayerCheck.exloreActive = false;
                    PlayerCheck.hackerActive = false;
                    PlayerCheck.scientistActive = false;
                    SceneManager.LoadScene(newLevel);
                }
                break;
            case "Exlore":
                {
                    PlayerCheck.exloreActive = true;
                    PlayerCheck.ozulActive = false;
                    PlayerCheck.cowboyActive = false;
                    PlayerCheck.hackerActive = false;
                    PlayerCheck.scientistActive = false;
                    SceneManager.LoadScene(newLevel);
                }
                break;
            case "Hacker":
                {
                    PlayerCheck.hackerActive = true;
                    PlayerCheck.exloreActive = false;
                    PlayerCheck.ozulActive = false;
                    PlayerCheck.cowboyActive = false;
                    PlayerCheck.scientistActive = false;
                    SceneManager.LoadScene(newLevel);
                }
                break;
            case "Scientist":
                {
                    PlayerCheck.scientistActive = true;
                    PlayerCheck.exloreActive = false;
                    PlayerCheck.ozulActive = false;
                    PlayerCheck.cowboyActive = false;
                    PlayerCheck.hackerActive = false;
                    SceneManager.LoadScene(newLevel);
                }
                break;
        }
    }
}
