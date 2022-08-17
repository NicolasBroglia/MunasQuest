using UnityEngine;

public class LauncherFireball : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject prefabGranade;
    public float range;
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
        GameObject granadeCopy = Instantiate(prefabGranade, spawnPoint.position, spawnPoint.rotation);
        granadeCopy.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * range, ForceMode.Impulse);

    }

}
