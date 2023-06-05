using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SongUIManager : MonoBehaviour
{
    public TextMeshProUGUI songNameText;
    public TextMeshProUGUI artistNameText;
    public SongManager songManager;
    public AudioManager audioManager;

    private void Start()
    {
        // Access the song data and update the UI
        Song currentSong = songManager.songs[audioManager.GetCurrentSong()]; // Assuming you want to display the first song in the list
        songNameText.text = currentSong.name;
        artistNameText.text = currentSong.artist;
    }
}
