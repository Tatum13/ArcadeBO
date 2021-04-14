using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderAIScript : MonoBehaviour
{
    public float moveSpeed = 20f;
    public float rotSpeed = 100f;

    private bool isWandering = false;
    private bool isRotatingLeft = false;
    private bool isRotatingRight = false;
    private bool isWalking = false;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isWandering == false)
        {
            StartCoroutine(Wander());
        }
        if (isRotatingRight == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * rotSpeed);

        }
        if (isRotatingLeft == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * -rotSpeed);
        }
        if (isWalking == true)
        {
            rb.AddForce(transform.forward * moveSpeed);
        }
    }

    IEnumerator Wander()
    {
        int rotTime = Random.Range(1, 3);
        int rotateWait = Random.Range(1, 4);
        int rotateLorR = Random.Range(1, 2);
        int walkWait = Random.Range(1, 4);
        int walkTime = Random.Range(1, 5);

        isWandering = true;

        yield return new WaitForSeconds(walkWait);

        isWalking = true;

        yield return new WaitForSeconds(walkTime);

        isWalking = false;

        yield return new WaitForSeconds(rotateWait);

        if (rotateLorR == 1)
        {
            isRotatingRight = true;
            yield return new WaitForSeconds(rotTime);
            isRotatingRight = false;
        }
        if (rotateLorR == 2)
        {
            isRotatingLeft = true;
            yield return new WaitForSeconds(rotTime);
            isRotatingLeft = false;
        }
        isWandering = false;
    }
}