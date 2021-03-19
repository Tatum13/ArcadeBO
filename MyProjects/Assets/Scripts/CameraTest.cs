using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTest : MonoBehaviour
{
    public float cameraSmoothingFactor = 1;

    public float maxUp = 45;
    public float maxDown = -45;

    private Quaternion camRotation;
    // Start is called before the first frame update
    void Start()
    {
        camRotation = transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
        camRotation.x += Input.GetAxis("Mouse Y") * cameraSmoothingFactor * (-1);
        camRotation.y += Input.GetAxis("Mouse X") * cameraSmoothingFactor;

        camRotation.x = Mathf.Clamp(camRotation.x, maxDown, maxUp); // Dit is de camera clamp (limiteerd de up/down angles)

        transform.localRotation = Quaternion.Euler(camRotation.x, camRotation.y, camRotation.z);        
    }
}
