using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    [SerializeField] private IntrumentSound intrumentSound;
    public int drumNumber;

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="DrumStick"){
            intrumentSound.PlayDrum(drumNumber);
        }
    }
}
