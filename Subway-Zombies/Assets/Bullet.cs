using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f; // A velocidade do tiro
    private Vector2 direction; // Direção do movimento

    void Start()
    {
        // Destruir o tiro após um tempo para evitar lixo na memória
        Destroy(gameObject, 5f);  // O tiro desaparece após 5 segundos
    }

    void Update()
    {
        // Mover o tiro para frente (direção especificada)
        transform.Translate(direction * speed * Time.deltaTime);
    }

    public void SetDirection(Vector2 dir)
    {
        // Define a direção do tiro
        direction = dir;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Verifica se o tiro colidiu com um zumbi
        if (collision.gameObject.CompareTag("Zombie"))
        {
            // Se colidir com um zumbi, destruir ambos
            Destroy(collision.gameObject);  // Destroi o zumbi
            Destroy(gameObject);  // Destroi o tiro
        }
    }
}

