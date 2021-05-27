using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Experience : MonoBehaviour
{

    [SerializeField] private int level = 0;
    [SerializeField] private int currentExp = 0;
    public ExperienceBarUI experienceBarUI;

    private void Start() {
        experienceBarUI.SetLevel(level);
        experienceBarUI.SetMaxExp(CurrentLevelMaxExp());
        experienceBarUI.SetCurrentExp(currentExp);
    }

    public void AddExperience(int amount) {
        if ((currentExp + amount) >= CurrentLevelMaxExp()) {
            currentExp = (amount - (CurrentLevelMaxExp() - currentExp));
            LevelUp();
        } else {
            currentExp += amount;
        }
        experienceBarUI.SetCurrentExp(currentExp);   
    }

    public void LevelUp() {
        level++;
        experienceBarUI.SetLevel(level);
        experienceBarUI.SetMaxExp(CurrentLevelMaxExp());
    }

    public int CurrentLevelMaxExp() {
        return (level + 1) * 1000;
    }


}
