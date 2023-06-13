using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class BigDrum : MonoBehaviour
{
    public InputActionProperty leftActivate;
    [SerializeField] IntrumentSound intrumentSound;
    public Transform objectToScale;
    public float scaleIncreaseFactor = 1.2f;
    public float scaleDecreaseFactor = 0.8f;
    public float bounceForce = 5f;
    
    private Vector3 startingScale;
    private Coroutine scaleCoroutine;


    private bool once = true;
    
    private void Start()
    {
        startingScale = objectToScale.localScale;

    }
    void Update()
    {
        if(leftActivate.action.IsPressed() && once){
            intrumentSound.PlayDrum(8);
            once = false;
            if (scaleCoroutine != null)
                    StopCoroutine(scaleCoroutine);

            scaleCoroutine = StartCoroutine(ScaleObject());
        }
        if(!leftActivate.action.IsPressed()){
            once = true;
        }
    }

    private IEnumerator ScaleObject()
    {
        // Scale up
        objectToScale.localScale = startingScale * scaleIncreaseFactor;

        yield return new WaitForSeconds(0.1f); // Adjust the duration as desired

        // Scale down
        objectToScale.localScale = startingScale;
    }
}
