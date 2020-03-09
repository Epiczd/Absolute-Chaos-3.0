using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script is unfinished
public class MouseLook : MonoBehaviour
{
    [SerializeField] private float sensitivity = 10f;
    private float xRotation = 0f;
    [SerializeField] private Transform player;

    //Locks the mouse cursor on start
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.fixedDeltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.fixedDeltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        player.Rotate(Vector3.up * mouseX);
    }
}
