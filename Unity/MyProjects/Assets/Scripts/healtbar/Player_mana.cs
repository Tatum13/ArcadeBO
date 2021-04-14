using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_mana : MonoBehaviour
{
    Animator animator;

    public int maxMana = 100;
    public int minMana = 0;
    public int currentMana;

    public ManaBar manaBar;

    void Start()
    {
        currentMana = maxMana;
        manaBar.SetMaxMana(maxMana);

        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            DecreaseMana(1);
        }

        if(currentMana > 0)
        {
            if (Input.GetMouseButtonDown(1))
            {
                animator.SetBool("isAttackingMagic", true);
            }
            else
            {
                animator.SetBool("isAttackingMagic", false);
            }
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag.Equals("Egg"))
        {
            IncreaseMana(Random.Range(1, 20));
        }
    }

    void DecreaseMana(int decrease)
    {
        currentMana -= decrease;
        manaBar.SetMana(currentMana);

        if(currentMana < minMana)
        {
            currentMana = minMana;
        }
    }

    void IncreaseMana(int increase)
    {
        currentMana += increase;
        manaBar.SetMana(currentMana);

        if (currentMana > maxMana)
        {
            currentMana = maxMana;
        }
    }
}
