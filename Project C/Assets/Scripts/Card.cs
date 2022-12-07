using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Cards/Card")]
public class Card : ScriptableObject
{
    [Header("Card Info")] 
    public string cardName;
    [TextArea] public string cardDescription;

    [Header("Base Stats")] 
    public int baseAttack;
    public int baseHealth;
    public int baseCost;

    private void Awake()
    {
        cardName = "Card Name";
        cardDescription = "This is a description.";
        baseAttack = 0;
        baseHealth = 1;
        baseCost = 0;
    }
}
