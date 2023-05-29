using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    public AudioSource audioSource;
    public Slider slider;

    private void Start()
    {
        // Set the initial value of the slider to match the audio source volume
        slider.value = audioSource.volume;
    }

    public void OnSliderValueChanged()
    {
        // Update the volume of the audio source based on the slider value
        audioSource.volume = slider.value;
    }
}
