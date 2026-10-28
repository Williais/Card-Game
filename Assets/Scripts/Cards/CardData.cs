using UnityEngine;

// Isso permite criar novas cartas direto pelo menu do Unity
[CreateAssetMenu(fileName = "NovaCarta", menuName = "Card Game/Carta")]
public class CardData : ScriptableObject
{
    public string cardName;
    public int value; // 1 a 13 (Ás a Rei)
    
    // Usamos um Enum para os naipes
    public Suit suit;
    
    public Sprite cardArtwork; // A imagem da carta
    public string effectDescription; // O texto do efeito (ex: "Roubo de Vida")
}

public enum Suit
{
    Copas,
    Paus,
    Ouros,
    Espadas,
    Coringa
}