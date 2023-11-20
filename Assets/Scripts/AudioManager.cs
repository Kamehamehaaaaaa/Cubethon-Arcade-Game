using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioClip completeLevelSFX;
    [SerializeField] AudioClip crashSFX;
    AudioSource audioSource;

    void Awake() 
    {
        int numMusicPlayers = FindObjectsOfType<AudioManager>().Length;
        if (numMusicPlayers > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void CompleteLevelSFX()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(completeLevelSFX);
    }

    public void CrashSFX()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(crashSFX);
    }
}
