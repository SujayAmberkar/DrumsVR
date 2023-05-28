using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class BigDrum : MonoBehaviour
{
    public InputActionProperty leftActivate;
    [SerializeField] IntrumentSound intrumentSound;

    // Update is called once per frame
    void Update()
    {
        if(leftActivate.action.ReadValue<float>() > 0.1f){
            intrumentSound.PlayDrum(6);
        }
    }
}
