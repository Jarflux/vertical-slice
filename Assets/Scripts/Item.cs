using System;
using System.Text;
using UnityEngine;

public class Item : ScriptableObject
{
    [Header("Basic Info")]
    [SerializeField] private new string name;
    [SerializeField] private string quality;
    [SerializeField] private int level;
    [SerializeField] private int value;
    [SerializeField] private Sprite icon;

    public static Item CreateInstance(string name, string quality, int level) {
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

    private void Init(string name, string quality, int level) {
        this.name = name;
        this.level = level;
        this.quality = quality;
    }

    public string GetName() {
        return name;
    }

    public string GetQuality() {
        return quality;
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
        StringBuilder stringBuilder = new StringBuilder(quality).Append(" ").Append(name);
        if (level > 0) {
            stringBuilder.Append(" ( +").Append(level).Append(" )");
        }
        return stringBuilder.AppendLine().Append("Sell Price:" ).Append(getValue()).ToString();
    }

}
