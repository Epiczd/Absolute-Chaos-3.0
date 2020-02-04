﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;
    public float zMin;
    public float zMax;

    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.Clamp(player.transform.position.x, xMin, xMax);
        /*
        float y = Mathf.Clamp(player.transform.position.y, yMin, yMax);
        */
        float z = Mathf.Clamp(player.transform.position.z, zMin, zMax);

        gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, z);
    }
}
