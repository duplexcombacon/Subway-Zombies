using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private Vector3 initialPosition;  // Posição inicial do jogador

    void Start()
    {
        // Salva a posição inicial do jogador
        initialPosition = transform.position;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        // Verifica se o jogador colidiu com um obstáculo
        if (other.gameObject.CompareTag("Obstacle"))
        {
            // Volta o jogador à posição inicial
            transform.position = initialPosition;
            Debug.Log("Colidiu com o obstáculo! Jogador retornando à posição inicial.");
        }
    }
}
