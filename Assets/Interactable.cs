using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactable : MonoBehaviour
{
    public float radius = 4f;
    public Text text;
    public AudioSource audioSource;
    public bool playerInRangeToInteract = false;

    public void OnTriggerEnter(Collider other)
    {
        text.enabled = true;
        if (other.CompareTag("Player"))
        {
            playerInRangeToInteract = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        text.enabled = false;
        if (other.CompareTag("Player"))
        {
            playerInRangeToInteract = false;
        }
    }

    private void FixedUpdate()
    {
        if (playerInRangeToInteract && Input.GetKey(KeyCode.E))
        {
            Interact();
        }
    }

    public void Interact()
    {
        audioSource.Play();
    }


    void OnDrawGizmosSelected() {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
