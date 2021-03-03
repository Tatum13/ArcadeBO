using UnityEngine;

public class WASDMovement : MonoBehaviour
{
    // This is where the variables are declared
    public float speed = 6f; // de beginsnelheid is 6
    public float rotationSpeed = 200f;
    // Update is called once per frame
    void Update()
    {
        float translation = 0;
        float rotation = 0;

        translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;

        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 15f; // speed gaat van 6 naar 15 wanneer shift is ingedrukt
        }
    }
}
