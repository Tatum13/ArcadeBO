using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveRandomly : MonoBehaviour
{
    NavMeshAgent navMeshAgent;
    public float timeForNewPath;
    bool inCoroutine;
    
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        {
            if (!inCoroutine)
            {
                StartCoroutine(DoSomething());
            }

      
        }
        Vector3 GetNewRandomPosition()
        {
            float x = Random.Range(-1, 1);
            float z = Random.Range(-1, 1);

            Vector3 pos = new Vector3(x, 0, z);
            return pos;
        }

        IEnumerator DoSomething()
        {
            inCoroutine = true;
            yield return new WaitForSeconds(Random.Range(-timeForNewPath, timeForNewPath));
            GetNewPath();
            inCoroutine = false;
        }

        void GetNewPath()
        {
            navMeshAgent.SetDestination(GetNewRandomPosition());
            navMeshAgent.speed = Random.Range(-1, 1);
        }

    }
}
