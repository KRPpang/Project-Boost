using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject rocket; // Reference to the rocket (player object)
    public Transform launchPad; // Transform of the launch pad

    public void Respawn()
    {
        rocket.transform.position = launchPad.position;
        rocket.transform.rotation = Quaternion.identity;

        // Reset rocket velocity
        Rigidbody2D rb = rocket.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = Vector2.zero;
            rb.angularVelocity = 0f;
        }
    }
}
