using UnityEngine;
using UnityEngine.SceneManagement;

public class SingletonAudio : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            SceneManager.LoadScene(1);
        }
    }
}
