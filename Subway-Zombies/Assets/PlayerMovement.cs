using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;  // Velocidade de movimentação do jogador
    public float boundaryX = 2f;  // Distância da barreira no eixo X (ajustar conforme necessário)
    private bool canMoveLeft = true;  // Pode mover para a esquerda
    private bool canMoveRight = true;  // Pode mover para a direita

    void Update()
    {
        // Detecta se o jogador pode se mover para a esquerda ou direita
        if (transform.position.x < -boundaryX)
        {
            canMoveLeft = false;  // Impede que o jogador da esquerda se mova mais para a esquerda
        }
        else if (transform.position.x > boundaryX)
        {
            canMoveRight = false;  // Impede que o jogador da direita se mova mais para a direita
        }
        else
        {
            canMoveLeft = true;
            canMoveRight = true;
        }

        // Movimento do jogador
        float move = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;

        // Impede o movimento se o jogador estiver tentando atravessar a barreira
        if ((move < 0 && canMoveLeft) || (move > 0 && canMoveRight))
        {
            transform.Translate(move, 0f, 0f);
        }
    }
}
