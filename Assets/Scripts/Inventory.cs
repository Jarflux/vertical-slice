using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

    [SerializeField] private Item _item;
    public InventoryUI inventoryUI;

    public Item WitdrawItem() {
        Item item = _item;
        _item = null;
        inventoryUI.SetText(string.Empty);
        return item;
    }

    public void SetItem(Item item) {
        _item = item;
        inventoryUI.SetText(item.getTooltipDisplayText(), item.GetRarityColor());
    }

}
