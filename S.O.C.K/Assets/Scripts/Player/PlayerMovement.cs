using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float moveSpeed;

    public static bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;

        Vector3 forwardMovement = new Vector3(0f, 0f, Input.GetAxis("Vertical"));
        transform.localPosition += forwardMovement * Time.deltaTime * moveSpeed;
    }

    void Jump()
    {
        if(Input.GetButtonDown("Jump") && isGrounded == true)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0f, 8f, 0f), ForceMode.Impulse);
        }
    }
}
