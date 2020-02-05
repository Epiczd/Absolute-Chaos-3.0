using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    //Checks if the player is on the ground or not

    /* If the player is on the ground,
     * isGrounded = true, and the player can jump/sprint
     */
    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Ground"))
        {
            PlayerMovement.isGrounded = true;
        }
    }

    /* If the player is NOT on the ground,
     * isGrounded = false, and the player CANNOT jump/sprint
     */
    void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("Ground"))
        {
            PlayerMovement.isGrounded = false;
        }
    }
}
