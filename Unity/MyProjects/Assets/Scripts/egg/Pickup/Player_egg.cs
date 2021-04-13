using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_egg : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag.Equals("Egg"))
        {
            Egg_script.eggsAmount += 1;
            Destroy(collision.gameObject);
        }
    }
}
