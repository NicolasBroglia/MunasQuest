using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//HERENCIA
public class Enemy : MonoBehaviour
{
    public Transform transformPlayer;

    public float health;
    public float maxHealth = 100f;
    public string nombre;
    public float speed;

    public void Start()
    {
        health = maxHealth;
    }

    public void Update()
    {
        CheckDistance();
        LookAtPlayer();
        FollowPlayer();
    }
    public void BasicAtk()
    {
        Debug.Log("Realizando Ataque Basico");
    }

    public void TakeDamage(float damage)
    {
        health -= damage;

        if(health <= 0)
        //animacion de muerte
            Destroy(gameObject);
    }


    //chequear ditancia entre el enemigo y el jugador. 
    void CheckDistance()
    {
        float dist = Vector3.Distance(transform.position, transformPlayer.position);
        if (dist <= 2)
        {
            speed = 0;
        }
        else
        {
            speed = 2f;
        }
    }
    //para que el enemigo mire al jugador.
    void LookAtPlayer()
    {
        transform.LookAt(transformPlayer.position);
    }
    void FollowPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, transformPlayer.position, speed * Time.deltaTime);
    }
}
