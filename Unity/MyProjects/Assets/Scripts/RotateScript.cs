using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    public GameObject objectToRotateAround;
    // Start is called before the first frame update
    void Start()
    {
        //yay!
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(objectToRotateAround.transform.position, Vector3.up, 2.0f);
    }
}
