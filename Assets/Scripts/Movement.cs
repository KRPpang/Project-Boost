using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float thrust = 3f;
    public float rotationSpeed = 150f;

    private Rigidbody2D rb;
    private AudioSource audioSource;
    public ParticleSystem thrusterParticles;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        ProcessInput();
    }

    void ProcessInput()
    {
        // movements
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(transform.up * thrust);

            // play sound when pressing
            if (audioSource != null && !audioSource.isPlaying)
            {
                audioSource.Play();
            }

            // particles
            if (thrusterParticles != null && !thrusterParticles.isPlaying)
            {
                thrusterParticles.Play();
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.rotation += rotationSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.rotation -= rotationSpeed * Time.deltaTime;
        }

        // stop sound
        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (audioSource != null)
            {
                audioSource.Stop();
            }

            // Stop particles
            if (thrusterParticles != null)
            {
                thrusterParticles.Stop();
            }
        }


    }
}
