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
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;

        Vector3 forwardMovement = new Vector3(0f, 0f, Input.GetAxis("Vertical"));
        transform.localPosition += forwardMovement * Time.deltaTime * moveSpeed;
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
