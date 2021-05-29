using System;
using UnityEngine;

public class UpgradeStation : Interactable
{
    public AudioSource successAudio;
    public AudioSource FailureAudio;

    public override void Interact() {
        Inventory inventory = player.GetComponent<Inventory>();
        Item item = inventory.WitdrawItem();

        if (IsUpgradeSuccesful(item)) {
            Debug.Log("Upgrade Success");
            successAudio.Play();
            item.IncrementLevel();
            player.GetComponent<Experience>().AddExperience(100*item.GetLevel());
        } else {
            Debug.Log("Upgrade Failure");
            FailureAudio.Play();
            item.ResetLevel();
        }

        inventory.SetItem(item);
    }

    private bool IsUpgradeSuccesful(Item item) {
        float chance = GetUpgradeChanceOfSuccess(item);
        Debug.Log("Chance of Success:" + chance);
        return UnityEngine.Random.value <= chance;
    }

    private float GetUpgradeChanceOfSuccess(Item item) {
        int playerLevel = player.GetComponent<Experience>().GetLevel();
        float increasedOddsForExperiencedPlayer = 0.01f * playerLevel;
        float baseChance = GetBaseChanceOfSuccess(item);
        return Math.Min(baseChance + increasedOddsForExperiencedPlayer, 0.95f);
    }

    private static float GetBaseChanceOfSuccess(Item item) {
        return item.GetRarity() switch {
            Item.Rarity.Basic => 0.70f,
            Item.Rarity.Rare => 0.60f,
            Item.Rarity.Epic => 0.50f,
            Item.Rarity.Legendary => 0.40f,
            _ => 0.5f,
        };
    }
}
