using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class malofinal : MonoBehaviour
{
    public float health = 100f;

    private MeshCollider meshCollider; // Reference to the MeshCollider component

    private void Start()
    {
        // Get the MeshCollider component attached to the GameObject
        meshCollider = GetComponent<MeshCollider>();

        // Enable the mesh collider
        meshCollider.enabled = true;
    }

    public void TakeDamage(float amount)
    {
        health -= amount;

        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        // Disable the mesh collider before destroying the GameObject
        meshCollider.enabled = false;

        Destroy(gameObject);
    }
}