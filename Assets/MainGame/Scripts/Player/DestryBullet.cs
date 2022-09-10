using UnityEngine;

public class DestryBullet : MonoBehaviour
{
    public float timeDestroy = 5f;
    void Start()
    {
        Destroy(gameObject, timeDestroy);//destuye el gameobject con la varable "timeDestroy"
    }
}
