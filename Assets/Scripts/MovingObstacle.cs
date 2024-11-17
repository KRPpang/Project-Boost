using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacle : MonoBehaviour
{
    public Vector3 moveDirection = new Vector3(1, 0, 0);
    public float speed = 2f;
    public float distance = 3f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        transform.position = startPosition + moveDirection * Mathf.Sin(Time.time * speed) * distance;
    }
}
