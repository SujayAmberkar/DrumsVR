using UnityEngine;
using System.Collections;

public class DrumBounce : MonoBehaviour
{
    public Transform objectToScale;
    public float scaleIncreaseFactor = 1.2f;
    public float scaleDecreaseFactor = 0.8f;

    private Vector3 startingScale;
    private Coroutine scaleCoroutine;

    private void Start()
    {
        startingScale = objectToScale.localScale;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DrumStick"))
        {
            if (scaleCoroutine != null)
                StopCoroutine(scaleCoroutine);

            scaleCoroutine = StartCoroutine(ScaleObject());
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
