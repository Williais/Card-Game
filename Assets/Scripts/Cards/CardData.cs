using UnityEngine;

[CreateAssetMenu(fileName = "NovaCarta", menuName = "Card Game/Carta")]
public class CardData : ScriptableObject
{
    public string cardName;        // Ex: "Fonte de Vida"
    public int manaCost;           // O 'X' no coração superior esquerdo
    public int power;              // O '000' ao lado da espada
    public int health;             // O '000' ao lado do coração inferior
    public Suit suit;
    public Sprite cardArtwork;     // A imagem do frasco de poção
    [TextArea]
    public string effectDescription; // Ex: "Restaura 1 de vida ao final do seu turno."
}

public enum Suit
{
    Copas,
    Paus,
    Ouros,
    Espadas,
    Coringa
}