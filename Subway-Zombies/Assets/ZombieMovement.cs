using UnityEngine;

public class ZombieMovement : MonoBehaviour
{
    public float speed = 2f; // Velocidade de movimento do zumbi

    void OnCollisionEnter2D(Collision2D other)
{
    if (other.gameObject.CompareTag("Tiro"))
    {
        Destroy(gameObject);  // Destroi o zumbi
        Destroy(other.gameObject);  // Destroi o tiro
    }
}



    void Update()
    {
        // Movimenta o zumbi para baixo
        transform.position += Vector3.down * speed * Time.deltaTime;
    }
}
