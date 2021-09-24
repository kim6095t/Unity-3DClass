using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerQ : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;    // 네비게이션 유저.
    [SerializeField] float moveSpeed;       // 이동 속도.

    Vector3 destination;                    // 목적지.

    private void Start()
    {
        destination = transform.position;
    }

    public void SetDestination(Vector3 destination)
    {
        //this.destination = destination;
        agent.SetDestination(destination);
    }

    private void Update()
    {
        /*
        transform.position =
         Vector3.MoveTowards(transform.position, destination, moveSpeed * Time.deltaTime);

        transform.LookAt(destination);
        */
    }
}
