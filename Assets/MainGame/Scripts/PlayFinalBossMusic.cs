using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayFinalBossMusic : MonoBehaviour
{
    public AudioClip finalBossMusic;
    public bool IsPlayng = true;

    public bool isActive = false;

    public Animator bossMusicAnim;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            bossMusicAnim.SetTrigger("FadeInMusic");
            isActive = true;
            AudioSource ac = GetComponent<AudioSource>();
            ac.PlayOneShot(finalBossMusic);
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
