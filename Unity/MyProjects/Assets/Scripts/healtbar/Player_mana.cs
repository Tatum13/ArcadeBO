using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_mana : MonoBehaviour
{

    public int maxMana = 100;
    public int currentMana;

    public ManaBar manaBar;

    void Start()
    {
        currentMana = maxMana;
        manaBar.SetMaxMana(maxMana);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            DecreaseMana(10);
        }
    }
    void DecreaseMana(int decrease)
    {
        currentMana -= decrease;

        manaBar.SetMana(currentMana);
    }

}
