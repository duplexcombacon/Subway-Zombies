using UnityEngine;

public class ObstacleSpawnerD : MonoBehaviour
{
    public GameObject obstaculoPrefab;
    public float tempoInicial = 4f;
    public float tempoMinimo = 1.5f;
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
