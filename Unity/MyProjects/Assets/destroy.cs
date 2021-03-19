using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class destroy : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    public GameObject yoooText;

    float xInput;
    float zInput;

    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //rb.AddForce(Vector3.up * 500);
            rb.velocity = Vector3.forward * 2000f;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Scene 2");
        }

        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");

        rb.AddForce(xInput * speed, 0, zInput * speed);
        
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);

            yoooText.SetActive(true);
        }
    }
}
