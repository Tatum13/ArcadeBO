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
        if (Input.GetMouseButton(1))
        {
            DecreaseMana(1);
        }
    }

  // void LateUpdate()
  // {
  //     if(currentMana == 0)
  //     {
  //         yield return new WaitForSeconds(15);
  //         IncreaseMana(10);
  //     }
  // }

    void DecreaseMana(int decrease)
    {
        currentMana -= decrease;

        manaBar.SetMana(currentMana);
    }

    void IncreaseMana(int increase)
    {
        currentMana += increase;
        manaBar.SetMana(currentMana);
    }
}
