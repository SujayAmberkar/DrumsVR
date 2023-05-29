using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    [SerializeField] private GameObject PlayButton;
    [SerializeField] private GameObject PauseButton;
    [SerializeField] private AudioManager audioManager;

    public void PlaySong(){
        Debug.Log($"Play");
        PlayButton.SetActive(false);
        PauseButton.SetActive(true);
        audioManager.audioSource.Play();
        
    }

    public void PauseSong(){
        Debug.Log($"Pause");
        PlayButton.SetActive(true);
        PauseButton.SetActive(false);
        audioManager.audioSource.Pause();
    }

    public void NextSong(){
        audioManager.SetCurrentSong(audioManager.GetCurrentSong() + 1);
        Debug.Log($"Next");
    }

    public void PreviousSong(){
        audioManager.SetCurrentSong(audioManager.GetCurrentSong() - 1);
        Debug.Log($"Previous");
    }

}
