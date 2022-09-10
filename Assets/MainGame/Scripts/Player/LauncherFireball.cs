using UnityEngine;

public class LauncherFireball : MonoBehaviour
{
    //strong attack
    public Animator anim;

    public Transform spawnPoint;
    public GameObject prefabGranade;
    public float range;

    public AudioClip StrongAtk;
    //lanzar granada:
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ThrowGranade();
        }
    }
    void ThrowGranade()
    {
        anim.SetTrigger("StrongAttack");

        GameObject granadeCopy = Instantiate(prefabGranade, spawnPoint.position, spawnPoint.rotation);
        granadeCopy.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * range, ForceMode.Impulse);

        AudioSource ac = GetComponent<AudioSource>();
        ac.PlayOneShot(StrongAtk);
    }

}
