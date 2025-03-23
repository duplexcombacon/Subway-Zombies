using UnityEngine;

// igual ao da esquerda mas agora para o jogador 2, que também merece obstáculos exclusivos
public class ObstacleMovementD : MonoBehaviour
{
    public float speed = 5f; // a velocidade dos obstaculos, que vai aumentando
    public float resetPositionY; // coordenadas de spawn
    public float[] lanePositions = new float[] { 2.5f, 6.75f }; // coordenadas dos corredores da direita

    void Start()
    {
        // Y inicial
        resetPositionY = transform.position.y;

        // escolher faixa de forma random
        float randomX = lanePositions[Random.Range(0, lanePositions.Length)];

        // mete o obstáculo lá
        transform.position = new Vector3(randomX, transform.position.y, transform.position.z);
    }

    void Update()
    {
        // acelera aos poucos
        speed += Time.deltaTime * 0.1f;

        // faz o obstáculo cair
        transform.position += Vector3.down * speed * Time.deltaTime;

        // resetar a posição Y
        if (transform.position.y <= -10f)
        {
            float randomX = lanePositions[Random.Range(0, lanePositions.Length)];
            transform.position = new Vector3(randomX, resetPositionY, transform.position.z);
        }
    }
}
