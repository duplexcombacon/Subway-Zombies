using UnityEngine;

public class PlayerMovementAD : MonoBehaviour
{
    public float moveSpeed = 5f;  // Velocidade de movimentação do jogador
    public float boundaryX = 2f;  // Distância da barreira no eixo X
    private bool canMoveLeft = true;
    private bool canMoveRight = true;

    public GameOverManager gameOverManager; // Referência ao gestor de Game Over

    void Update()
    {
        // Atualiza se pode mover com base na posição atual
        canMoveLeft = transform.position.x > -boundaryX;
        canMoveRight = transform.position.x < boundaryX;

        float move = 0f;

        // Controlos com A e D
        if (Input.GetKey(KeyCode.A) && canMoveLeft)
            move = -1f;
        else if (Input.GetKey(KeyCode.D) && canMoveRight)
            move = 1f;

        // Aplica o movimento
        transform.Translate(move * moveSpeed * Time.deltaTime, 0f, 0f);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Colidiu com: " + other.gameObject.name);

        if (other.gameObject.CompareTag("Obstaculo"))
        {
            Debug.Log("Game Over!");
            gameOverManager.ShowGameOver();
        }
    }
}
