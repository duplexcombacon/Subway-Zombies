using UnityEngine;

public class ObstacleMovementE : MonoBehaviour
{
    public float speed = 5f; // a velocidade dos obstaculos, que vai aumentando
    public float resetPositionY; // onde reaparece quando sai do ecrã
    public float[] lanePositions = new float[] { -6.2f, -1.7f }; // coordenadas dos corredores da esquerda

    void Start()
    {
        // guarda o Y de origem 
        resetPositionY = transform.position.y;

        // escolhe aleatoriamente uma das faixas do jogador 1
        float randomX = lanePositions[Random.Range(0, lanePositions.Length)];

        // mete o obstáculo nessa posição
        transform.position = new Vector3(randomX, transform.position.y, transform.position.z);
    }

    void Update()
    {
        // acelera devagarinho
        speed += Time.deltaTime * 0.1f;

        // faz o obstáculo descer
        transform.position += Vector3.down * speed * Time.deltaTime;

        // teleporta os obstáculos devolta para cima
        if (transform.position.y <= -10f)
        {
            float randomX = lanePositions[Random.Range(0, lanePositions.Length)];
            transform.position = new Vector3(randomX, resetPositionY, transform.position.z);
        }
    }
}
