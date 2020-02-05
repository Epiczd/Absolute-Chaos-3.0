using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheck : MonoBehaviour
{
    public static bool ozulActive;
    public static bool cowboyActive;

    public GameObject ozul;
    public GameObject cowboy;
    // Start is called before the first frame update
    void Start()
    {
        if(ozulActive == true)
        {
            ozul.SetActive(true);
            cowboy.SetActive(false);
        }
        else if (cowboyActive == true)
        {
            cowboy.SetActive(true);
            ozul.SetActive(false);
        }
    }
}
