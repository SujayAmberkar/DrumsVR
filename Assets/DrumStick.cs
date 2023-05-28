using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrumStick : MonoBehaviour
{
    private Vector3 lastPosition;
    [SerializeField] private float stickSpeed;

    // Start is called before the first frame update
    void Start()
    {
        lastPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        stickSpeed = (transform.position - lastPosition).magnitude / Time.deltaTime;
        
    }
}
