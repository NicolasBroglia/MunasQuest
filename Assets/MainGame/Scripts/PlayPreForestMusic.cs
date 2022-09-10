using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayPreForestMusic : MonoBehaviour
{
    public AudioClip preForestMusic;
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
            ac.PlayOneShot(preForestMusic);
        }
    }
}
