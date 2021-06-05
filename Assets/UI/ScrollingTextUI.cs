using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScrollingTextUI : MonoBehaviour
{
    public TextMeshProUGUI _message;

    public void SetMessage(string message) {
        _message.text = message;
    }
}
