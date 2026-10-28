using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Vinculado ao Btn_Batalha
    public void IrParaBatalha()
    {
        SceneManager.LoadScene("Batalha"); 
    }

    // Vinculado ao Btn_Config
    public void AbrirConfiguracao()
    {
        Debug.Log("Painel de Configuração acionado."); 
    }

    public void SairDoJogo()
    {
        Debug.Log("Fechando o jogo...");
        Application.Quit();
    }
}