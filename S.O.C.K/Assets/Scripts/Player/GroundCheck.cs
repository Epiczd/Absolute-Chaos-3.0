using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        Debug.Log(PlayerMovement.isGrounded);
    }

    void OnTriggerEnter(Collider collision)
    {

        if (collision.CompareTag("Ground"))
        {
            PlayerMovement.isGrounded = true;
        }
    }

    void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("Ground"))
        {
            PlayerMovement.isGrounded = false;
        }
    }
}
