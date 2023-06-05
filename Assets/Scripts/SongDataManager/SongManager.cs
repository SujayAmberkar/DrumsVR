using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SongManager : MonoBehaviour
{
    public List<Song> songs = new List<Song>();

    private void Start()
    {
        // Add songs to the list
        Song song1 = new Song();
        song1.name = "The Rumbling";
        song1.artist = "SiM";
        songs.Add(song1);

        Song song2 = new Song();
        song2.name = "New Divide";
        song2.artist = "Linkin Park";
        songs.Add(song2);

        Song song3 = new Song();
        song2.name = "Thunder";
        song2.artist = "Imagine Dragons";
        songs.Add(song3);

        // You can add more songs as needed
    }
}
