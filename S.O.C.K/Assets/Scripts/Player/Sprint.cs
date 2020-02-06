using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprint : MonoBehaviour
{
    //Speed the player moves while sprinting
    private float sprintSpeed = 40f;

    //Will be used when we implement stamina
    public static bool canSprint;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftShift) && PlayerMovement.isGrounded == true)
        {
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
            transform.position += movement * Time.deltaTime * sprintSpeed;

            Vector3 forwardMovement = new Vector3(0f, 0f, Input.GetAxis("Vertical"));
            transform.localPosition += forwardMovement * Time.deltaTime * sprintSpeed;
        }
    }
}
