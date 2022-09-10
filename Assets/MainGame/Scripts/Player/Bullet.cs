using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 0;
    public float damage;
    public Vector3 bulletDirection = new Vector3();

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<EnemyGoblin>(out EnemyGoblin enemy))
        {
            enemy.TakeDamage(10);
        }
    }
}
