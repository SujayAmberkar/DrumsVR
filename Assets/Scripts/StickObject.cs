using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickObject : MonoBehaviour
{
    public GameObject objectToStick;

    // Update is called once per frame
    void Update()
    {
        objectToStick.transform.position = transform.position;
        objectToStick.transform.rotation = transform.rotation;
    }
}
