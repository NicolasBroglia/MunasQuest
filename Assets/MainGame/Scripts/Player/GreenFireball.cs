using UnityEngine;

public class GreenFireball : MonoBehaviour
{
    public float damage;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<EnemyGoblin>(out EnemyGoblin enemy))
        {
            enemy.TakeDamage(10);
        }

    }
}
