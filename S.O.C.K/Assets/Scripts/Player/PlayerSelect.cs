using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerSelect : MonoBehaviour
{
    public string newLevel;

    private void Update()
    {
        OnMouseDown();
        Debug.Log(PlayerCheck.cowboyActive);
    }

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            switch (tag)
            {
                case "Ozul":
                    if (gameObject.CompareTag("Ozul"))
                    {
                        PlayerCheck.ozulActive = true;
                        PlayerCheck.cowboyActive = false;
                        SceneManager.LoadScene(newLevel);
                    }
                    break;
                case "Cowboy":
                    if (gameObject.CompareTag("Cowboy"))
                    {
                        PlayerCheck.cowboyActive = true;
                        PlayerCheck.ozulActive = false;
                        SceneManager.LoadScene(newLevel);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
