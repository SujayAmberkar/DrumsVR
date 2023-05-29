using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    [SerializeField] public AudioClip[] songs;
    private int currentSong = 0;

    private void Start(){
        audioSource = GetComponent<AudioSource>();
    }
    
    public void SetCurrentSong(int newSong){
        if(newSong>songs.Length){
            currentSong = 0;
        }
        currentSong = newSong;
        audioSource.clip = songs[currentSong];
    }

    public int GetCurrentSong(){
        return currentSong;
    }


}
