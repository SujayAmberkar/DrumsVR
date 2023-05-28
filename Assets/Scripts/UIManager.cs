using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class UIManager : MonoBehaviour
{
    public InputActionProperty keys;
    public GameObject UI;

    // Update is called once per frame
    void Update()
    {
        if(keys.action.IsPressed()){
            UI.SetActive(true);
        }else{
            UI.SetActive(false);
        }
    }
}
