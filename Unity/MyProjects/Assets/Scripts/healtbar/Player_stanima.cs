using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_stanima : MonoBehaviour
{

    public int maxStanima = 100;
    public int minStanima = 0;
    public int currentStanima;

    public StanimaBar stanimaBar;

    void Start()
    {
        currentStanima = maxStanima;
        stanimaBar.SetMaxStanime(maxStanima);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Minder(5);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag.Equals("Egg"))
        {
            Meer(Random.Range(1, 20));
        }
    }

    void Minder(int minder)
    {
        currentStanima -= minder;
        stanimaBar.SetStanima(currentStanima);

        if (currentStanima < minStanima)
        {
            currentStanima = minStanima;
        }
    }

    void Meer(int meer)
    {
        currentStanima += meer;
        stanimaBar.SetStanima(currentStanima);

        if (currentStanima > maxStanima)
        {
            currentStanima = maxStanima;
        }
    }
}
