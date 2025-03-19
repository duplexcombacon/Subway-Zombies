using UnityEngine;

public class LoopCenario : MonoBehaviour
{
    public float velocidade = 3f;  // Velocidade do movimento da estrada
    public float limiteY = -15f;   // Posição onde a estrada será reciclada
    public float alturaMapa = 10f;  // Altura do bloco do cenário
    public float posX = -1.2f;  // Posição X ajustada para -1.2f

    private void Start()
    {
        // Definir posição inicial da estrada 1
        transform.position = new Vector3(posX, alturaMapa);
    }

    void Update()
    {
        // Move a estrada 1 para baixo
        transform.position += Vector3.down * velocidade * Time.deltaTime;

        // Quando a estrada atinge o limite, reposiciona-a para cima
        if (transform.position.y <= limiteY)
        {
            transform.position = new Vector3(posX, alturaMapa + alturaMapa, -0.5f);  // Move a estrada para cima
        }
    }
}
