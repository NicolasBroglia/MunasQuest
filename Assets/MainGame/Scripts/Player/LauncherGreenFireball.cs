using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherGreenFireball : MonoBehaviour
{
    //strong attack
    //public Animator anim;

    //public ParticleSystem flashEffectLight;
    //public ParticleSystem flashEffectStarB;

    public Transform spawnPoint;
    public GameObject prefabBullet;
    public float range;

   // public AudioClip StrongAtk;

    //lanzar granada:
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            ShootBullet();
        }
    }
    void ShootBullet()
    {
        //anim.SetTrigger("StrongAttack");

        GameObject granadeCopy = Instantiate(prefabBullet, spawnPoint.position, spawnPoint.rotation);
        granadeCopy.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * range, ForceMode.Impulse);

        //AudioSource ac = GetComponent<AudioSource>();
        //ac.PlayOneShot(StrongAtk);
    }
}
