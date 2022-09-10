using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall1 : MonoBehaviour
{
    public GameObject explosionEffect; //sist de de particlas
    //public float delay = .5f;
    //float radius = 1;
   // public float explosionForce = 1f;
    public float damage;

    public float time = 1f;
/*
    private void Start()
    {
        Invoke("ExplotarGranada", delay);
    }
    void ExplotarGranada()
    {
        //chequear colliders cercanos
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

        //Aplicar fuerza a cada collider  cercano
        foreach (Collider near in colliders)
        {
            Rigidbody rb = near.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(explosionForce, transform.position, radius, 1f, ForceMode.Impulse);
                

            }

            //instancias sist de particulas...
            Instantiate(explosionEffect, transform.position, transform.rotation);

            explosionEffect.active = false;

            Destroy(gameObject);
        }
    }
    */
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent<EnemyGoblin>(out EnemyGoblin enemy))
        {
            enemy.TakeDamage(50);
        }
    }
}
