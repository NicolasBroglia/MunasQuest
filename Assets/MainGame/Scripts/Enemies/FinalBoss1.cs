using UnityEngine;

public class FinalBoss1 : MonoBehaviour
{

    public Transform transformPlayer;

    public bool isDead = false;

    public float hp;
    public float weaponDmg;
    public Animator anim;

    public ParticleSystem deadLight;
    public ParticleSystem deadSpark;
    public ParticleSystem deadSmoke;

    public AudioClip bossAudio;

    //quest for Boss
    public GameObject questMenu;

    private void Update()
    {
        LookAtPlayer();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "weaponImpact")
        FinalBossHp.bossHP -= 50;
        hp -= weaponDmg;
       // isDead = true;
        if (hp <= 0)
        {
            deadLight.Play();
            deadSpark.Play();
            deadSmoke.Play();

            AudioSource ac = GetComponent<AudioSource>();
            ac.PlayOneShot(bossAudio);


            Destroy(gameObject, 1.7f);
            CompleteQuest();

        }
    }
    private void CompleteQuest()
    {
        questMenu.SetActive(false);
    }

    void LookAtPlayer()
    {
        transform.LookAt(transformPlayer.position);
    }
}
