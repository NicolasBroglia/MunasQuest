using UnityEngine;

public class EnemyTest : MonoBehaviour
{
    public int hp;
    public int weaponDmg;
    public Animator anim;

    //quest for tutorial
    public GameObject questMenu;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "weaponImpact")
        {
            anim.Play("Hit");
        }

        hp -= weaponDmg;

        if (hp <= 0)
        {
            Destroy(gameObject);
            CompleteQuest();

        }
    }
    //quest
    private void CompleteQuest()
    {
        questMenu.SetActive(false);
    }
}