using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefab;  // O prefab do tiro
    public Transform shootPoint;  // O ponto onde o tiro vai ser disparado
    public float fireRate = 0.5f;  // A taxa de disparo (em segundos)

    private float nextFireTime = 0f;

    void Update()
{
    if (Input.GetKey(KeyCode.F) && Time.time > nextFireTime)  // Mudado para GetKey, permitindo disparo contínuo
    {
        Shoot();
        nextFireTime = Time.time + fireRate;
    }
}


    void Shoot()
{
    // Cria o tiro na posição do jogador
    GameObject bullet = Instantiate(bulletPrefab, shootPoint.position, Quaternion.identity);
    // Garante que o tiro vai para a direção certa
    bullet.GetComponent<Bullet>().SetDirection(shootPoint.right); // Usando o vetor da direção do shootPoint
}

}
