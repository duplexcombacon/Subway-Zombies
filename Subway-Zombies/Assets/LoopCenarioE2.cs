using UnityEngine;

public class LoopCenarioE2 : MonoBehaviour
{
    public float velocidade = 3f;  // Velocidade do movimento da estrada
    public float limiteY = -20f;   // Posição onde a estrada será reciclada
    public float alturaMapa = 10f;  // Altura do bloco do cenário
    public float posX = -1.2f;  // Posição X ajustada para -1.2f

    private void Start()
    {
        // Definir posição inicial da estrada 2 logo abaixo da estrada 1
        transform.position = new Vector3(posX, alturaMapa - alturaMapa, -0.5f);  // Coloca a estrada 2 abaixo da estrada 1
    }

    void Update()
    {
        // Move a estrada 2 para baixo
        transform.position += Vector3.down * velocidade * Time.deltaTime;

        // Quando a estrada 2 atinge o limite, reposiciona-a para cima
        if (transform.position.y <= limiteY)
        {
            transform.position = new Vector3(posX, alturaMapa, -0.5f);  // Move a estrada para cima
        }
    }
}
