using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverUI;

    public void ShowGameOver()
    {
        if (gameOverUI != null)
        {
            gameOverUI.SetActive(true);
            Time.timeScale = 0f; // 🔴 Pausa o jogo
        }
        else
        {
            Debug.LogWarning("GameOver UI não atribuído!");
        }
    }

    public void RestartGame()
    {
        Time.timeScale = 1f; // 🟢 Retoma o tempo antes de reiniciar
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Saiu do jogo.");
    }
}
