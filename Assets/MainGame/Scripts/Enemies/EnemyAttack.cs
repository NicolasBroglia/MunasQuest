using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public Animator anim;
    //public GameObject hitParticle;
    //public AudioClip attackSound;
    public Collider AttackCollider;

    //dps timer
    public float lastAttackTine = 0f;
    private float AttackCooldown = 1.08f;

    private void OnTriggerEnter(Collider AttackCollider)
    {
        if (AttackCollider.tag == "Player")
        {
           
            //PlayerHP.playerHP -= 50;
            anim.SetTrigger("Attack");
            ReduceDmg();
            //Instantiate(hitParticle);
        }
       
    }
    private void OnTriggerExit(Collider other)
    {
        if (AttackCollider.tag == "Player")
        {
            anim.ResetTrigger("Attack");

        }

    }
    private void ReduceDmg()
    {
        if(Time.time - lastAttackTine >= AttackCooldown)
        {
            PlayerHP.playerHP -= 10;
            Debug.Log("Dps Timer started");
            lastAttackTine = Time.time + AttackCooldown;
        }
    }
    
}
