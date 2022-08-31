using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 0;
    public int bulletDamage = 0;
    public Vector3 bulletDirection = new Vector3();
    void Update()
    {
        transform.position += bulletDirection * bulletSpeed; //calcula el movimiento del proyectil
    }
}
