using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle2D : MonoBehaviour
{
    private Spawn spawnManager;

    private void Start()
    {
        spawnManager = FindObjectOfType<Spawn>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // Assuming the rocket has the "Player" tag
        {
            spawnManager.Respawn();
        }
    }
}
