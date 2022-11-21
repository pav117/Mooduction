using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private Transform RespawnPoint;
    private bool respawn;

    private void FixedUpdate()
    {
        if (respawn)
        {
            Player.transform.position = RespawnPoint.transform.position;
            respawn = false;
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            respawn = true;
        }
    }
}