using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Jogar()
    {
        SceneManager.LoadScene("Jogo"); // nome exato da cena
    }

    public void Opcoes()
    {
        Debug.Log("Abrir opções...");
        // ou ativar um painel de opções
    }

    public void Sair()
    {
        Application.Quit();
        Debug.Log("Saiu do jogo."); // só funciona no build
    }
}
