using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntrumentSound : MonoBehaviour
{
    [SerializeField] private AudioClip[] DrumSounds;
    private AudioSource audioSource;
    public DrumSoundController drumSoundController;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    public void PlayDrum(int drum){
        audioSource.PlayOneShot(drumSoundController.Drums[DrumTypeSelector.SelectedDrum].AudioClips[drum]);
    }
}
