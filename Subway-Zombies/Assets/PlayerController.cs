using UnityEngine;

public class MovimentoJogador : MonoBehaviour
{
    public float velocidadeMovimento = 5f; // Velocidade do movimento
    private Vector2 direcaoMovimento;

    void Update()
    {
        // Captura a entrada do teclado (Makey Makey usa setas do teclado)
        float movimentoX = 0;
        if (Input.GetKey(KeyCode.LeftArrow)) movimentoX = -1;
        if (Input.GetKey(KeyCode.RightArrow)) movimentoX = 1;

        direcaoMovimento = new Vector2(movimentoX, 0).normalized;
    }

    void FixedUpdate()
    {
        // Aplica o movimento na horizontal
        transform.Translate(direcaoMovimento * velocidadeMovimento * Time.fixedDeltaTime);
    }
}