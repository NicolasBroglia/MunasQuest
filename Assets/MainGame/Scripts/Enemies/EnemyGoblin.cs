using UnityEngine;

public class EnemyGoblin : MonoBehaviour
{
    public Transform transformPlayer;

    public float health;
    public float maxHealth = 100f;
    public string nombre;
    public float speed;

    public bool isDead = false;

    public ParticleSystem deadLight;
    public ParticleSystem deadSpark;
    public ParticleSystem deadSmoke;

    public AudioClip goblinAudio;

    public Animator animGoblin;
    Rigidbody rb;

    public void Start()
    {
        health = maxHealth;
        animGoblin.SetBool("Run", false);
    }

    public void Update()
    {
        CheckDistance();
        LookAtPlayer();
        FollowPlayer();
    }

    public void TakeDamage(float damage)
    {
        health -= damage;

        if (health <= 0)
        {
            deadLight.Play();
            deadSpark.Play();
            deadSmoke.Play();

            AudioSource ac = GetComponent<AudioSource>();
            ac.PlayOneShot(goblinAudio);
            //animacion de muerte
            

            isDead = true;
            if (isDead == true)
            {
                Destroy(gameObject, 1f);
            }
        }
    }


    //chequear ditancia entre el enemigo y el jugador. 
    
    void CheckDistance()
    {

        float dist = Vector3.Distance(transform.position, transformPlayer.position);
         if (dist <= 2 || dist >= 20)
         {

             speed = 0;
             animGoblin.SetBool("Run", false);
         }
         else
         {
             speed = 3.5f;
             animGoblin.SetBool("Run", true);
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
