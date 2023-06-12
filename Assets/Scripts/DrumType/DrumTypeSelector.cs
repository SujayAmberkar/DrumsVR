using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DrumTypeSelector
{
    // acoustic = 0, electric = 1
    public static int SelectedDrum = 0;

    public static int getSelectedType(){
        return SelectedDrum;
    }
}
