using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    public float speedV = 2.0f;
    public float speedH = 2.0f;

    private float rotationX = 0.0f;
    private float rotationY = 0.0f;


    public GameObject objectToRotateAround;
    // Start is called before the first frame update
    void Start()
    {
        //yay!
    }

    // Update is called once per frame
    void Update()
    {
        rotationY += speedV * Input.GetAxis("Mouse X");
        rotationX -= speedH * Input.GetAxis("Mouse Y");

        rotationY = Mathf.Clamp(rotationX, -30f, 30f);

       // transform.RotateAround(objectToRotateAround.transform.position, Vector3.up, 2.0f);
    }
}
