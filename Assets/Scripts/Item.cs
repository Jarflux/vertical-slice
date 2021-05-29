using System;
using System.Text;
using UnityEngine;

public class Item : ScriptableObject
{
    [Header("Basic Info")]
    [SerializeField] private new string name;
    [SerializeField] private Rarity rarity;
    [SerializeField] private int level;
    [SerializeField] private int value;
    [SerializeField] private Sprite icon;

    public enum Rarity : ushort {
        Basic = 0,
        Rare = 1,
        Epic = 2,
        Legendary = 3,
    }

    public static Item CreateInstance(string name, Rarity quality, int level) {
        var data = ScriptableObject.CreateInstance<Item>();
        data.Init( name, quality, level);
        return data;
    }

    internal void ResetLevel() {
        level = 0;
    }

    internal void IncrementLevel() {
        level++;
    }

    private void Init(string name, Rarity rarity, int level) {
        this.name = name;
        this.level = level;
        this.rarity = rarity;
    }

    public string GetName() {
        return name;
    }

    public Rarity GetRarity() {
        return rarity;
    }

    public Color GetRarityColor() {
        return rarity switch {
            Rarity.Basic => Color.white,
            Rarity.Rare => Color.blue,
            Rarity.Epic => Color.magenta,
            Rarity.Legendary => Color.red,
            _ => Color.white,
        };
    }

    public int GetLevel() {
        return level;
    }

    public Sprite GetIcon() {
        return icon;
    }
    
    public int getValue() {
        return level*50;    
    }

    public string getTooltipDisplayText() {
        StringBuilder stringBuilder = new StringBuilder(rarity.ToString()).Append(" ").Append(name);
        if (level > 0) {
            stringBuilder.Append(" ( +").Append(level).Append(" )");
        }
        return stringBuilder.AppendLine().Append("Sell Price:" ).Append(getValue()).ToString();
    }

}
