using UnityEngine;

public class ObstacleSpawnerE : MonoBehaviour
{
    public GameObject obstaculoPrefab;
    public float tempoInicial = 2f;
    public float tempoMinimo = 0.5f;
    public float dificuldade = 0.05f;
    private float tempoAtual;

    void Start()
    {
        tempoAtual = tempoInicial;
        Invoke("SpawnObstaculo", tempoAtual);
    }

    void SpawnObstaculo()
{
    int obstaculosAtivos = GameObject.FindGameObjectsWithTag("Obstaculo").Length;

    if (obstaculosAtivos < 6)
    {
        Instantiate(obstaculoPrefab, transform.position, Quaternion.identity);
    }

    tempoAtual = Mathf.Max(tempoMinimo, tempoAtual - dificuldade);
    Invoke("SpawnObstaculo", tempoAtual);
}

}
