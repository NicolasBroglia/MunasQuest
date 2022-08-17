using UnityEngine;

public class Staff : MonoBehaviour
{
    public float range = 100f;
    public Camera cam;

    public ParticleSystem flashEffectLight;
    public ParticleSystem flashEffectStarB;
    public GameObject impactEffect;

    public AudioSource _audioS;
    public AudioSource _clipDisparo;
    public AudioSource _clipHit;

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        RaycastHit hit;

        flashEffectLight.Play();
        flashEffectStarB.Play();

        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range)) 
        {
            Debug.Log("el raycast colision con: " + hit.transform.name);
            if (hit.transform.tag == "Enemy")
            {
                Debug.Log("has imapctado con un enemigo!");

            }
        }
    }
}
