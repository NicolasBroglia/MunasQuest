using UnityEngine;

public class CanonWeapon : MonoBehaviour
{
    public GameObject prefabHaloBullet;
    public GameObject prefabBullet;
    public Transform posicionCanonWeapon;
    public float time = 10f;
    public float tiempoRestante;
    public float lapsoEntreBalas;
    //boleano para cumplir el reseteo de balas

    private void Start()
    {
     //   ResetearTemporizador();
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
    void CrearHaloBullet()
    {
        Instantiate(prefabHaloBullet, posicionCanonWeapon.position, transform.rotation);
    }
    //temporizdor
    void ResetearTemporizador()
    {
        tiempoRestante = time;
    }

    public void TempoBalas()
    {
        tiempoRestante -= Time.deltaTime;//tiempo entre proyectiles
                                         // timerMonsterLemon -= Time.deltaTime;//tiempo entre aparicion del "monsterLemon"
        if (tiempoRestante <= lapsoEntreBalas)
        {
            //se creo un randomizer para que se disparen distintos tipos de proyectiles
            int numeroRandom = Random.Range(1, 100);
            switch (numeroRandom)
            {
                 case int n when n < 90:
                     CrearBullet();
                     ResetearTemporizador();
                     break;
                 case int n when n < 100:
                     CrearHaloBullet();
                     ResetearTemporizador();
                     break;
                 default:
                     Debug.Log("Error switch random");
                     break;
            }
        }
    }
}

