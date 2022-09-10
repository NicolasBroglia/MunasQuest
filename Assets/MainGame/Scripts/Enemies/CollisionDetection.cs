using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public AtackLogic al;
    public GameObject hitParticle;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag != "Enemy" && al.isAttacking)
        {
            Debug.Log(other.name);
            other.GetComponent<Animator>().SetTrigger("Hit");
            Instantiate(hitParticle);
        }
    }
}
