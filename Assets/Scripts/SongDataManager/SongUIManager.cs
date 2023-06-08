using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SongUIManager : MonoBehaviour
{
    public Text songNameText;
    public Text artistNameText;
    public SongManager songManager;
    public AudioManager audioManager;
    Song currentSong;

    private void Start()
    {
        // Access the song data and update the UI
        currentSong = songManager.songs[audioManager.GetCurrentSong()]; // Assuming you want to display the first song in the list
        songNameText.text = currentSong.name;
        artistNameText.text = currentSong.artist;
    }
    
    private void Update(){
        currentSong = songManager.songs[audioManager.GetCurrentSong()];
        songNameText.text = currentSong.name;
        artistNameText.text = currentSong.artist;
    }
}
