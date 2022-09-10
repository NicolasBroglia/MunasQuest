using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayForestMusic : MonoBehaviour
{
    public AudioClip forestMusic;
    public bool IsPlayng = true;

    public bool isActive = false;

    public Animator musicAnim;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            musicAnim.SetTrigger("FadeInMusic");
            isActive = true;
            AudioSource ac = GetComponent<AudioSource>();
            ac.PlayOneShot(forestMusic);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            AudioSource ac = GetComponent<AudioSource>();
            ac?.Stop();
        }
    }
}
