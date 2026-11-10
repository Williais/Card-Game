using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<CardData> deckJogador; // Arraste os ScriptableObjects aqui no editor
    public List<CardData> deckInimigo;
    
    public GameObject cartaPrefab; // O molde visual da carta
    public Transform maoJogador;   // O Horizontal Layout Group da mão
    public Transform maoInimigo;   // O Horizontal Layout Group do inimigo

    void Start()
    {
        ComprarMaoInicial();
    }

    void ComprarMaoInicial()
    {
        for (int i = 0; i < 7; i++)
        {
            ComprarCarta(deckJogador, maoJogador, true);
            ComprarCarta(deckInimigo, maoInimigo, false); // false = não visível (mostra as costas)
        }
    }

    void ComprarCarta(List<CardData> deck, Transform maoAlvo, bool visivel)
    {
        if (deck.Count == 0) return; // Baralho vazio

        // 1. Sorteia um índice aleatório
        int indexSorteado = Random.Range(0, deck.Count);
        CardData cartaSorteada = deck[indexSorteado];

        // 2. Instancia a carta na mão alvo
        GameObject novaCartaObj = Instantiate(cartaPrefab, maoAlvo);
        
        // 3. Configura os dados e a visibilidade
        CardInstance instancia = novaCartaObj.GetComponent<CardInstance>();
        instancia.ConfigurarCarta(cartaSorteada, visivel);

        // 4. Remove a carta do baralho
        deck.RemoveAt(indexSorteado);
    }
}