using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Jogar()
    {
        SceneManager.LoadScene("Jogo"); // substitui pelo nome real da tua cena
    }

    public void Sair()
    {
        Application.Quit();
        Debug.Log("Sair do jogo"); // só funciona no build final
    }
}
