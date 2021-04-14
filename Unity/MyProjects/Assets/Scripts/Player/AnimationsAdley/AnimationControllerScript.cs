using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControllerScript : MonoBehaviour
{
    Animator animator;
    public bool grounded;
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject)
        {
            grounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Terrain")
        {
            grounded = false;
        }
    }

    void Update()
    {
        //Walk animations
        if (Input.GetKey("w"))
        { 
            animator.SetBool("isWalking", true);
        }
        else if (Input.GetKey("a"))
        {
            animator.SetBool("isWalking", true);
        }
        else if (Input.GetKey("d"))
        {
            animator.SetBool("isWalking", true);
        }
        else 
        { 
            animator.SetBool("isWalking", false);
        }

        //Fall animation
        if (grounded)
        {
            animator.SetBool("isFalling", false);
        }
        else
        {
            animator.SetBool("isFalling", true);
        }

        //Meleeeeeeeeee attack
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetBool("isAttackingPunch", true);
        }
        else
        {
            animator.SetBool("isAttackingPunch", false);
        }
    }
}
