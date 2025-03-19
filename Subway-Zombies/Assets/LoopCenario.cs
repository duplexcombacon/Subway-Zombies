using UnityEngine;

public class LoopCenario : MonoBehaviour
{
    public float velocidade = 3f;  // Velocidade do movimento do cenário
    public float posX = -1.2f;     // Posição X ajustada
    public float limiteY;  // Posição onde o bloco será reciclado
    public float alturaMapa = 10f;  // Altura do bloco do cenário
    public GameObject estrada2;  // Referência à segunda estrada

    private void Start()
    {
        // Definir posição inicial da estrada
        transform.position = new Vector3(posX, alturaMapa, -0.5f); // Primeira estrada
        estrada2.transform.position = new Vector3(posX, alturaMapa - alturaMapa, -0.5f); // Segunda estrada logo abaixo da primeira
    }

    void Update()
    {
        // Move as estradas para baixo
        transform.position += Vector3.down * velocidade * Time.deltaTime;
        estrada2.transform.position += Vector3.down * velocidade * Time.deltaTime;

        // Quando a primeira estrada atinge o limite, reposiciona-a atrás da segunda
        if (transform.position.y <= limiteY)
        {
            // Posiciona a estrada 1 novamente no topo (acima da estrada 2)
            transform.position = new Vector3(posX, estrada2.transform.position.y + alturaMapa, -0.5f);
        }

        // Quando a segunda estrada atinge o limite, reposiciona-a atrás da primeira
        if (estrada2.transform.position.y <= limiteY)
        {
            // Posiciona a estrada 2 novamente no topo (acima da estrada 1)
            estrada2.transform.position = new Vector3(posX, transform.position.y + alturaMapa, -0.5f);
        }
    }
}
