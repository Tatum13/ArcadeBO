using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg_script : MonoBehaviour
{
    public static int eggsAmount;
    public GameObject eggsCounter;
    private bool goUp = true;
    private bool isUp = false;
    public float speed = 0.004f;

    private void Start()
    {
        eggsAmount = 0;
        eggsCounter = GameObject.Find("Egg_counter");
    }

    void Update()
    {
        transform.Rotate(0, 90 * Time.deltaTime, 0); //ei laten draaien
        eggsCounter.GetComponent<TMPro.TextMeshProUGUI>().text = "Eggs: " + eggsAmount; //dit laat de counter omhoog gaan

        if (goUp)
        {
            transform.Translate(Vector3.up * speed * 4f);
            isUp = true;
            goUp = false;
        }
        
        if (isUp)
        {
            transform.Translate(Vector3.down * speed * 4f);
            goUp = true;
            isUp = false;
        }

    }
}
