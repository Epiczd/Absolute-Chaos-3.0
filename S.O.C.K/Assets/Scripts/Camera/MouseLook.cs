using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float sensitivity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookAround = new Vector3(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0f);
        transform.position += lookAround * Time.deltaTime * sensitivity;
    }
}
