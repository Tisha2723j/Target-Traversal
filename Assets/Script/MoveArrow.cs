using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndDespawnArrow : MonoBehaviour
{
    public float speed = 5f; // Speed of the arrow

    void Update()
    {
        // Move the arrow forward
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the arrow collides with another object
        // Destroy the arrow if it collides
        Destroy(gameObject);
    }
}