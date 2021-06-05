using TMPro;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{

    public TextMeshProUGUI TextMeshProUGUI;

    public void SetText(string text) {
        SetText(text, Color.white);
    }

    public void SetText(string text, Color color) {
        TextMeshProUGUI.text = text;
        TextMeshProUGUI.color = color;
    }

}
