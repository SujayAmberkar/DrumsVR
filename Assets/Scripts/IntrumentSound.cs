using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntrumentSound : MonoBehaviour
{
    [SerializeField] private AudioClip[] DrumSounds;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    public void PlayDrum(int drum){
        audioSource.PlayOneShot(DrumSounds[drum]);
    }
}
