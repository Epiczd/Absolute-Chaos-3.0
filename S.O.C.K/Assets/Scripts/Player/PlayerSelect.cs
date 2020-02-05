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
                    SceneManager.LoadScene(newLevel);
                }
                break;
            case "Ozul":
                {
                    PlayerCheck.ozulActive = true;
                    PlayerCheck.cowboyActive = false;
                    SceneManager.LoadScene(newLevel);
                }
                break;
        }
    }
}
