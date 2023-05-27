using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    [SerializeField] private IntrumentSound intrumentSound;
    public int drumNumber;
    private float hitForce = 100f;
    private void OnCollisionEnter(Collision other)
    {
        float collisionForce = other.relativeVelocity.magnitude;
        Debug.Log(collisionForce);
        if(other.gameObject.tag=="DrumStick"){
            if(collisionForce>hitForce){
                intrumentSound.PlayDrum(drumNumber);
            }
            
        }
    }
}
