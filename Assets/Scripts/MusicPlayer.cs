using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicPlayer : MonoBehaviour
{
    [SerializeField] private GameObject PlayButton;
    [SerializeField] private GameObject PauseButton;
    [SerializeField] private AudioManager audioManager;
    public Slider slider;

    private void Update(){
        SliderTime();
    }

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
        PlaySong();
        slider.value = 0;
        Debug.Log($"Next");
    }

    public void PreviousSong(){
        audioManager.SetCurrentSong(audioManager.GetCurrentSong() - 1);
        PlaySong();
        Debug.Log($"Previous");
        slider.value = 0;
    }

    public void SliderTime(){
        if(audioManager.audioSource.isPlaying){
            float progress = audioManager.audioSource.time / audioManager.audioSource.clip.length;
            slider.value = progress;
        }
    }

}
