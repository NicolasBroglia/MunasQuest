using UnityEngine;

public class GemRotation : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, 70f) * Time.deltaTime);
    }
}
