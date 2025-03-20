using UnityEngine;

public class InfiniteBackgroundY : MonoBehaviour
{
    public float scrollSpeed = 5f;  // Velocidade do movimento do fundo
    private float height;

    void Start()
    {
        // Obtém a altura do background
        height = GetComponent<SpriteRenderer>().bounds.size.y;
    }

    void Update()
    {
        // Move o fundo para baixo (no eixo Y negativo)
        transform.position += Vector3.down * scrollSpeed * Time.deltaTime;

        // Se o fundo sair da tela (no eixo Y negativo)
        if (transform.position.y <= -height)
        {
            // Reposiciona o fundo para o lado oposto (cria o loop infinito)
            transform.position = new Vector3(transform.position.x, transform.position.y + height * 2, transform.position.z);
        }
    }
}
