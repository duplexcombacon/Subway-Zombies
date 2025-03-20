using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float speed = 5f; // Velocidade de movimento
    public float spawnRangeX = 5f;  // Faixa de movimentação aleatória no eixo X
    private float resetPositionY;  // Posição Y para reiniciar o obstáculo

    void Start()
    {
        // Salva a posição Y inicial do obstáculo
        resetPositionY = transform.position.y;

        // Gera uma posição aleatória no eixo X dentro do intervalo definido
        float randomX = Random.Range(-spawnRangeX, spawnRangeX); // Ajuste o valor conforme necessário
        transform.position = new Vector3(randomX, transform.position.y, transform.position.z);
    }

   void Update()
{
    // Aumenta a velocidade gradualmente
    speed += Time.deltaTime * 0.1f;  // Ajuste o valor conforme necessário

    // Move o obstáculo para baixo
    transform.position += Vector3.down * speed * Time.deltaTime;

    // Quando o obstáculo sair da tela, reposiciona-o no topo com nova posição aleatória
    if (transform.position.y <= -10f)
    {
        transform.position = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), resetPositionY, transform.position.z);
    }
}

}
