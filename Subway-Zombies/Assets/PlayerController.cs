using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;  // Velocidade do jogador
    private float moveInput;  // Entrada de movimento
    public int lane = 1;  // Definir lane inicial (0, 1, 2, 3)

    private void Update()
    {
        // Movimentação para os lados (para esquerda e direita)
        moveInput = Input.GetAxisRaw("Horizontal");  // Detecta as teclas de movimento (A/D ou setas)

        // Movimentar jogador entre as pistas
        if (moveInput != 0)
        {
            int targetLane = lane + (int)moveInput;  // Atualiza a lane
            if (targetLane >= 0 && targetLane <= 3)  // Verifica se a lane está dentro do intervalo
            {
                lane = targetLane;
                Vector3 targetPosition = new Vector3(lane * 2f, transform.position.y, transform.position.z); // A posição final na lane
                transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
            }
        }
    }
}
