using System.Collections;
using UnityEngine;

public class Telepor : MonoBehaviour
{
    public Transform destination;

    public KeyCode interactKey = KeyCode.E;

    private bool playerInside = false;
    private Transform playerTransform;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerInside = true;           
            playerTransform = collision.transform;
        }
    }

    private void Update()
    {
      
    }
  
}

