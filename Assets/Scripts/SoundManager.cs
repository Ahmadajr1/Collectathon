using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private AudioSource audioSource;

    [SerializeField] private AudioClip playerJump, coinCollect, winSound;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    public void PlayPlayerJump()
    {
        audioSource.PlayOneShot(playerJump);
    }

    public void PlayCoinCollect()
    {
        audioSource.PlayOneShot(coinCollect);
    }

    public void PlayWinSound()
    {
        audioSource.PlayOneShot(winSound);
    }
}
