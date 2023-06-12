using UnityEngine;

public class SoundTypeChanger : MonoBehaviour
{
    public void ChangeSoundType(int soundType)
    {
        DrumTypeSelector.SelectedDrum = soundType;
    }

    
}