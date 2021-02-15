using UnityEngine;

public class WASDMovement : MonoBehaviour
{
    public float speed = 6f;
    // Update is called once per frame
    void Update()
    {
        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(xDirection, 0f, zDirection);

        transform.position += moveDirection * speed * Time.deltaTime;
    }
}
