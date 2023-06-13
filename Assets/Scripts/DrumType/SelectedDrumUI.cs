using UnityEngine;
using UnityEngine.UI;

public class SelectedDrumUI : MonoBehaviour
{
    public Image electric;
    public Image acoustic;
    public int count;

    private void UpdateTransparency()
    {
        float electricAlpha = electric.color.a;
        float acousticAlpha = acoustic.color.a;

        // if (DrumTypeSelector.SelectedDrum == 0)
        // {
        //     // elctric.color.a;
        //     acoustic.color.a = 1f;
        // }
        // else if (DrumTypeSelector.SelectedDrum == 1)
        // {
        //     button1Color.a = 1f;
        //     button2Color.a = 40 / 255f;
        // }

        // elctric.image.color = button1Color;
        // elctric.image.color = button2Color;
    }

    // Call this method whenever count changes
    public void OnCountChanged()
    {
        UpdateTransparency();
    }
}
