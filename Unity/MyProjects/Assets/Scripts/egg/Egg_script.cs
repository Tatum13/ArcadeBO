using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg_script : MonoBehaviour
{
    public static int eggsAmount;
    public GameObject eggsCounter;

    private void Start()
    {
        eggsAmount = 0;
        eggsCounter = GameObject.Find("Egg_counter");
    }

    void Update()
    {
        transform.Rotate(0, 90 * Time.deltaTime, 0); //ei laten draaien
        eggsCounter.GetComponent<TMPro.TextMeshProUGUI>().text = "Egg's: " + eggsAmount; //dit laat de counter omhoog gaan
    }
}
