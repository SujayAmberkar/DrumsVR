using UnityEngine;

public class Drum : MonoBehaviour
{
    [SerializeField] private IntrumentSound intrumentSound;
    public int drumNumber;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DrumStick"))
        {
            intrumentSound.PlayDrum(drumNumber);
        }
    }
}
