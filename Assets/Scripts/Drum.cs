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

    private Vector3 startingScale;
    private Coroutine scaleCoroutine;
    private Rigidbody rb;

    private void Start()
    {
        if (objectToScale == null)
        {
            Debug.LogError("Object to scale not assigned! Please assign the object in the Inspector.");
            enabled = false; // Disable the script to prevent errors
            return;
        }

        startingScale = objectToScale.localScale;
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("DrumStick"))
        {
            if (scaleCoroutine != null)
                StopCoroutine(scaleCoroutine);

            scaleCoroutine = StartCoroutine(ScaleObject());
            rb.AddForce(collision.relativeVelocity.normalized * bounceForce, ForceMode.Impulse);
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
