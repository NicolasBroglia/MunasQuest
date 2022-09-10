using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtackLogic : MonoBehaviour
{
    public ParticleSystem flashEffectLight;
    public ParticleSystem flashEffectStarA;
    //simple attack
    public Animator anim;
    
    public AudioClip SimpleAtk;

    public bool isAttacking = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Atack();
        }   
    }
    public void Atack()
    {
        isAttacking = true;
        anim.SetTrigger("SimpleAttack");
        flashEffectLight.Play();
        flashEffectStarA.Play();
        AudioSource ac = GetComponent<AudioSource>();
        ac.PlayOneShot(SimpleAtk);
    }
}
