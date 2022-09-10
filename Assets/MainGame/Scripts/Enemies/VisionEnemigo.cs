using UnityEngine;

public class VisionEnemigo : MonoBehaviour
{
    public float range = 100f;
    public Camera enemyCam;

    void Update()
    {
        Look();
    }
    void Look()
    {
        RaycastHit hit;

        if (Physics.Raycast(enemyCam.transform.position, enemyCam.transform.forward, out hit, range))
        {
            if (hit.transform.tag == "Player")
            {
                Debug.Log("has entrado en la vision del enemigo!");

            }
        }
    }
}
