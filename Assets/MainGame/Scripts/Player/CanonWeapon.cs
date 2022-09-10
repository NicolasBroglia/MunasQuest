using UnityEngine;

public class CanonWeapon : MonoBehaviour
{
    public GameObject prefabBullet;
    public Transform posicionCanonWeapon;
    public float time = 10f;
    public float tiempoRestante;
    public float lapsoEntreBalas;
    //booleano para cumplir el reseteo de balas

    public GameObject impactEffect;

    public AudioSource _clipDisparo;
    public AudioSource _clipHit;

    public Animator anim;

    private void Start()
    {
       ResetearTemporizador();
    }

    private void Update()
    {
        ShootBullet();
    }

    void ShootBullet()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            TempoBalas();
        }
    }
    void CrearBullet()
    {
        Instantiate(prefabBullet, posicionCanonWeapon.position, transform.rotation);
    }
   
    //temporizdor
    void ResetearTemporizador()
    {
        tiempoRestante = time;
    }

    public void TempoBalas()
    {
        tiempoRestante -= Time.deltaTime;

        if (tiempoRestante <= lapsoEntreBalas)
        {
           CrearBullet();
           ResetearTemporizador();
        }
    }
}

