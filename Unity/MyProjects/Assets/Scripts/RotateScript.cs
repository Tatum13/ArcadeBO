using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    public GameObject character;

    public float speedX = 30f;
    public float speedY = 10f;

    public float minClamp = -45f;
    public float maxClamp = 45f;

    // Start is called before the first frame update
    void Start()
    {
        //yay!
    }

    // Update is called once per frame
    void Update()
    {
        float rotationX = Input.GetAxis("Mouse X");
        transform.RotateAround(character.transform.position, Vector3.up, rotationX * speedX);
        // Debug.Log(rotation);

        float rotationY = Input.GetAxis("Mouse Y");
        if (transform.rotation.eulerAngles.y < 45)
        {
            transform.RotateAround(character.transform.position, Vector3.right, rotationY * speedY);
        }

        // transform.RotateAround(character.transform.position, Vector3.right, rotationY * speedY);

        Mathf.Clamp(rotationY, minClamp, maxClamp);
        //Jesse's advies:
        //Ik raad toch aan dat de camera kind wordt van de player
        //RotateAround(hier komt dan de player, dan om welke as, en dan de Input van de mouse * een snelheid
        //RotateAround andere as
        //Transform.lookAt(speler);
        // transform.RotateAround(objectToRotateAround.transform.position, Vector3.up, 2.0f);
    }
}
