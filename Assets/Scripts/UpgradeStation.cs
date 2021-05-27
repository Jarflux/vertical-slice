using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeStation : Interactable
{
    public AudioSource successAudio;
    public AudioSource FailureAudio;

    public override void Interact() {
        Inventory inventory = player.GetComponent<Inventory>();
        Item item = inventory.WitdrawItem();

        if (IsUpgradeSuccesful()) {
            Debug.Log("Upgrade Success");
            successAudio.Play();
            item.IncrementLevel();
            player.GetComponent<Experience>().AddExperience(100);
        } else {
            Debug.Log("Upgrade Failure");
            FailureAudio.Play();
            item.ResetLevel();
        }

        inventory.SetItem(item);
    }

    private bool IsUpgradeSuccesful() { 
        return (Random.value > 0.5f);
    }

}
