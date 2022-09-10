using UnityEngine;

public class EnemyGate : MonoBehaviour
{
    public int hp;
    public int weaponDmg;

    public GameObject leftDoor;
    public GameObject RightDoor;

    public ParticleSystem lightFx;
    public ParticleSystem sparkFx;
    public ParticleSystem smokeFx;

    public AudioClip BreakDoor;

    //gate mission
    public GameObject questMenu;

    public Collider impactOnDoor;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "weaponImpact")
        hp -= weaponDmg;

        if (hp <= 0)
        {
            lightFx.Play();
            sparkFx.Play();
            smokeFx.Play();
            Destroy(leftDoor);
            Destroy(RightDoor);
            impactOnDoor.enabled=false;
            AudioSource ac = GetComponent<AudioSource>();
            ac.PlayOneShot(BreakDoor);
            CompleteQuest();
        }
    }

    //quest
    private void CompleteQuest()
    {
        questMenu.SetActive(false);
    }
}
