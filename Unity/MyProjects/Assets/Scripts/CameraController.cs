using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Quaternion camRotation;
    // Start is called before the first frame update
    void Start()
    {
        camRotation = transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
        camRotation.x += Input.GetAxis("Mouse X") * 0.5f;
        transform.localRotation = camRotation;
    }
}
