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
        if (objectToScale == null)
        {
            Debug.LogError("Object to scale not assigned! Please assign the object in the Inspector.");
            enabled = false; // Disable the script to prevent errors
            return;
        }

        startingScale = objectToScale.localScale;
    }

    private void OnTriggerStay(Collider other)
    {
        // Check if the entering object comes from the top direction
        Vector3 enteringDirection = other.transform.position - transform.position;
        float dotProduct = Vector3.Dot(enteringDirection.normalized, topDirection.normalized);
        float threshold = Mathf.Cos(Mathf.Deg2Rad * 45f); // Adjust the threshold angle as desired

        if (dotProduct >= threshold)
        {
            if (!isTriggered)
            {
                isTriggered = true;
                if (scaleCoroutine != null)
                    StopCoroutine(scaleCoroutine);

                scaleCoroutine = StartCoroutine(ScaleObject());
                intrumentSound.PlayDrum(drumNumber);
            }
        }
        else
        {
            isTriggered = false;
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
