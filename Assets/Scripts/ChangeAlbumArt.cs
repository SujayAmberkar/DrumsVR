using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeAlbumArt : MonoBehaviour
{
    private Image albumArt;
    public AudioManager audioManager;
    // Start is called before the first frame update
    void Start()
    {
        albumArt = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        albumArt.sprite = audioManager.albumArt[audioManager.GetCurrentSong()];
    }
}
