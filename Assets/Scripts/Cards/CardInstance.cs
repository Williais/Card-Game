using UnityEngine;
using TMPro;

public class CardInstance : MonoBehaviour
{
    public CardData cardBaseData; // O arquivo base arrastado aqui
    
    // Valores dinâmicos
    public int vidaAtual;
    public int poderAtual;
    
    // Elementos da Interface (UI)
    public TextMeshProUGUI textoVida;
    public TextMeshProUGUI textoPoder;
    public GameObject arteCostasDaCarta; // Referência para a imagem da águia

    public void ConfigurarCarta(CardData novosDados, bool visivelParaJogador)
    {
        cardBaseData = novosDados;
        vidaAtual = cardBaseData.health;
        poderAtual = cardBaseData.power;
        
        AtualizarTextosUI();
        DefinirVisibilidade(visivelParaJogador);
    }

    public void ReceberDano(int dano)
    {
        vidaAtual -= dano;
        AtualizarTextosUI();
        if (vidaAtual <= 0) { /* Lógica de destruir a carta */ }
    }

    private void AtualizarTextosUI()
    {
        textoVida.text = vidaAtual.ToString();
        textoPoder.text = poderAtual.ToString();
    }

    public void DefinirVisibilidade(bool isVisible)
    {
        // Se for true, desativa a imagem das costas, revelando a carta.
        arteCostasDaCarta.SetActive(!isVisible);
    }
}