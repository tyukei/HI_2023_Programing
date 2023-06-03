using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkSE : MonoBehaviour
{
    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (KeyDef.ALLStick())
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }

    }
}
