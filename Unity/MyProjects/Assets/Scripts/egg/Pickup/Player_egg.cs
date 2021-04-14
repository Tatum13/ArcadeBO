using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_egg : MonoBehaviour
{
    public AudioClip pickupSound;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag.Equals("Egg"))
        {
            Egg_script.eggsAmount += 1;
            // collision.gameObject.GetComponent<AudioSource>().PlayOneShot();
            AudioSource.PlayClipAtPoint(pickupSound, transform.position);
            Destroy(collision.gameObject);
        }
    }
}
