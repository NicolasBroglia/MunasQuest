using UnityEngine;

public class RecoverHp : MonoBehaviour
{
    public ParticleSystem Heart;
    public ParticleSystem Light;
    public AudioClip RecoverHealth;
    private void OnTriggerEnter(Collider other)
    {

        bool isDead = false;
        if (other.tag == "Player")
        {
            PlayerHP.playerHP = 100;
            AudioSource ac = GetComponent<AudioSource>();
            ac.PlayOneShot(RecoverHealth);
            isDead = true;
            if (isDead == true)
            {
                Destroy(gameObject, 0.7f);
            }
        }
    }
}
