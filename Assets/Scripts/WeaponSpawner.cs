using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class WeaponSpawner : Interactable
{
    public AudioSource audioSource;

    public override void Interact() {
        audioSource.Play();
        Inventory inventory = player.GetComponent<Inventory>();
        inventory.SetItem(Item.CreateInstance("Sword", RandomRarity(), 0));
    }

    private static Item.Rarity RandomRarity() {
        Array values = Item.Rarity.GetValues(typeof(Item.Rarity));
        Random random = new Random();
        return (Item.Rarity)values.GetValue(random.Next(values.Length));
    }
}
