using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Speed the player moves at
    private float moveSpeed = 20f;

    //Checks if the player is grounded
    public static bool isGrounded;

    /* The player uses WASD or the arrow keys to move.
     * If the player presses A/leftarrow or D/right/arrow
     * They will move on the x axis left or right.
     * If the player pressed W/uparrow or S/downarrow
     * They will move on the z axis forward or backward
     */
    void Update()
    {
        Jump();
        UpdateMovement();

        if(Input.GetButton("Sprint") && isGrounded == true)
        {
            moveSpeed = 40f;
        }
        else
        {
            moveSpeed = 20f;
        }
    }

    void UpdateMovement()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * -z);
        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed * -x);
    }

    //If the player is grounded, and presses space, they will jump
    void Jump()
    {
        if(Input.GetButtonDown("Jump") && isGrounded == true)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0f, 8f, 0f), ForceMode.Impulse);
        }
    }
}
