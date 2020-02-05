using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class JumpSound : MonoBehaviour
{
    //Jump Sound Effect
    public AudioSource jump;

    //If the player jumps, they will hear the jump sound effect
    void Update()
    {
        if (Input.GetButton("Jump"))
        {
            jump.Play();
        }
    }
}
