using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ExperienceBarUI : MonoBehaviour
{

    public TextMeshProUGUI currentLevelLabel;
    public TextMeshProUGUI nextLevelLabel;
    public Slider slider;

    public void SetLevel(int currentLevel) {
        currentLevelLabel.text = currentLevel.ToString();
        nextLevelLabel.text = (currentLevel+1).ToString();
    }

    public void SetMaxExp(int maxExp) {
        slider.maxValue = maxExp;
    }

    public void SetCurrentExp(int currentExp) {
        slider.value = currentExp;
    }
}
