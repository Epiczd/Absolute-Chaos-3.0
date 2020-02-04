using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCheck : MonoBehaviour
{
    public GameObject firstPerson;
    public GameObject thirdPerson;

    private bool firstActive;

    // Start is called before the first frame update
    void Start()
    {
        firstActive = true;
    }

    // Update is called once per frame
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
