using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public abstract class Interactable : MonoBehaviour
{
    private const string Player = "Player";
    private const string HelperMessage = "Press {0} to Interact"; 
    public KeyCode InteractKeyBind = KeyCode.E;

    public TextMeshProUGUI text;
    public float radius = 2f;
    private bool playerInRangeToInteract = false;
    protected Collider player = null;

    public void OnTriggerEnter(Collider other)
    {
        text.enabled = true;
        text.text = string.Format(HelperMessage, InteractKeyBind);  ;
        if (other.CompareTag(Player))
        {
            playerInRangeToInteract = true;
            player = other;
        }
    }

    public void OnTriggerExit(Collider other) {
        RemovePrompt();
        if (other.CompareTag(Player)) {
            playerInRangeToInteract = false;
            player = null;
        }
    }

    private void RemovePrompt() {
        text.enabled = false;
        text.text = string.Empty;
    }

    private void Update()
    {
        if (playerInRangeToInteract && Input.GetKeyDown(InteractKeyBind))
        {
            RemovePrompt();
            Interact();
        }
    }

    public abstract void Interact();

    void OnDrawGizmosSelected() {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
