using UnityEngine;
using UnityEngine.UI;

public class SongSlider : MonoBehaviour
{
    public AudioSource audioSource;
    public Slider slider;

    private bool isUserInteracting = false;

    private void Start()
    {
        // Add an event listener to the slider's value changed event
        slider.onValueChanged.AddListener(OnSliderValueChanged);
    }

    private void Update()
    {
        // Check if the audio source is playing and the user is not interacting with the slider
        if (audioSource.isPlaying && !isUserInteracting)
        {
            // Calculate the current progress of the song
            float progress = audioSource.time / audioSource.clip.length;

            // Update the value of the slider
            slider.value = progress;
        }
    }

    private void OnSliderValueChanged(float value)
    {
        if (isUserInteracting)
        {
            // Calculate the new playback position based on the slider value
            float newPosition = value * audioSource.clip.length;

            // Set the playback position of the audio source
            audioSource.time = newPosition;
        }
    }

    public void OnSliderBeginDrag()
    {
        // Set the flag to indicate that the user is interacting with the slider
        isUserInteracting = true;
    }

    public void OnSliderEndDrag()
    {
        // Set the flag to indicate that the user interaction with the slider has ended
        isUserInteracting = false;
    }
}
