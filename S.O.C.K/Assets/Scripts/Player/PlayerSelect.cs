using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerSelect : MonoBehaviour
{
    public string newLevel;

    public Button player;

    private void Start()
    {
        player.onClick.AddListener(taskOnClick);
    }
    private void Update()
    {
        Debug.Log(PlayerCheck.ozulActive);
    }

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
