using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_stanima : MonoBehaviour
{

    public int maxStanima = 100000;
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
            minder(25);
        }
   }

    void minder(int stanima)
    {
        currentStanima -= stanima;

        stanimaBar.SetStanima(currentStanima);
    }
}
