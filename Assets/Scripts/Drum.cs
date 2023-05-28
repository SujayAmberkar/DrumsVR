using UnityEngine;
using System.Collections;

public class Drum : MonoBehaviour
{
    [SerializeField] private IntrumentSound intrumentSound;
    public int drumNumber;
    public Transform objectToScale;
    public float scaleIncreaseFactor = 1.2f;
    public float scaleDecreaseFactor = 0.8f;
    public float bounceForce = 5f;
    public Vector3 topDirection = Vector3.up; // Specify the top direction

    private Vector3 startingScale;
    private Coroutine scaleCoroutine;
    private bool isTriggered = false;

    private void Start()
    {
        startingScale = objectToScale.localScale;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("DrumStick")){
                isTriggered = true;
                if (scaleCoroutine != null)
                    StopCoroutine(scaleCoroutine);

                scaleCoroutine = StartCoroutine(ScaleObject());
                intrumentSound.PlayDrum(drumNumber);

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
