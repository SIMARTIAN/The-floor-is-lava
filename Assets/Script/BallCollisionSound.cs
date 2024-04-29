using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BallCollisionSound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClip;
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Lava"))
        {
            if (audioSource != null && audioClip != null)
            {
                audioSource.Play();

            }
        }
    }
}

