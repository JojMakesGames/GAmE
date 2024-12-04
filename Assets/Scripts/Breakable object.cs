using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplaceWithBreakable : MonoBehaviour
{
    public GameObject breakableObjectPrefab; // Prefab for the breakable object
    public Transform spawnPoint; // Location to spawn the breakable object (optional)
    public KeyCode interactionKey = KeyCode.E; // Interaction key (default is E)
    public float interactionDistance = 2f; // Max distance for interaction

    private Transform player; // Reference to the player

    void Start()
    {
        // Find the player by tag (assuming the player has the "Player" tag)
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (IsPlayerInRange() && Input.GetKeyDown(interactionKey))
        {
            ReplaceWithBreakableObject();
        }
    }

    bool IsPlayerInRange()
    {
        return Vector3.Distance(player.position, transform.position) <= interactionDistance;
    }

    void ReplaceWithBreakableObject()
    {
        // Spawn the breakable object at the specified location
        if (breakableObjectPrefab != null)
        {
            Vector3 spawnPosition = spawnPoint ? spawnPoint.position : transform.position;
            Quaternion spawnRotation = spawnPoint ? spawnPoint.rotation : transform.rotation;

            Instantiate(breakableObjectPrefab, spawnPosition, spawnRotation);
        }

        // Destroy the current object
        Destroy(gameObject);
    }
}
