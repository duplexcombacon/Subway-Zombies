using UnityEngine;

public class MovimentoJogador : MonoBehaviour
{
    public float velocidadeMovimento = 5f; // Velocidade do movimento
    private Vector2 direcaoMovimento;

    public GameOverManager gameOverManager; // Referência ao GameOverManager

    void Update()
    {
        // Captura a entrada do teclado (Makey Makey usa setas do teclado)
        float movimentoX = 0;
        if (Input.GetKey(KeyCode.LeftArrow)) movimentoX = -1;
        if (Input.GetKey(KeyCode.RightArrow)) movimentoX = 1;

        direcaoMovimento = new Vector2(movimentoX, 0).normalized;
    }

    void FixedUpdate()
    {
        // Aplica o movimento na horizontal
        transform.Translate(direcaoMovimento * velocidadeMovimento * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstaculo"))
        {
            gameOverManager.ShowGameOver();
        }
    }
}
