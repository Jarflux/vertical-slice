using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSpawner : Interactable
{
    public AudioSource audioSource;

    public override void Interact() {
        audioSource.Play();
        Inventory inventory = player.GetComponent<Inventory>();
        inventory.SetItem(Item.CreateInstance("Sword", "Basic", 0));
    }

}
