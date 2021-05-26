using TMPro;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{

    public TextMeshProUGUI TextMeshProUGUI;

    public void SetText(string text) {
        TextMeshProUGUI.text = text;
    }
}
