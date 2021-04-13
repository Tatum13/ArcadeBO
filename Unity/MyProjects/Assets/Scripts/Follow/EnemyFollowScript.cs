using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EnemyFollowScript : MonoBehaviour
{
    public Transform Player;
    int MoveSpeed = 5;
    int MaxDist = 10;
    int MinDist = 5;

    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

  
    void Update()
    {
        transform.LookAt(Player);

        if(Vector3.Distance(transform.position, Player.position) >= MinDist)
        {
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;
            animator.SetBool("isWalking", true);

            if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
            {
                animator.SetBool("isWalking", false);
            }
            
        }
    }
}
