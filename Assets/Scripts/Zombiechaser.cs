using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombiechaser : MonoBehaviour
{
    Animator Zombieanim;

    CharacterController Zombie;

    public Transform target;

    NavMeshAgent Agent;

    public float distance;





    // Start is called before the first frame update
    void Start()
    {
        Zombie = GetComponent<CharacterController>();
        Zombieanim = GetComponent<Animator>();
        Agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Zombieanim.SetFloat("speed", Zombie.velocity.magnitude);

        distance = Vector3.Distance(transform.position, target.position);

        Agent.destination = target.position;

        if (distance <= 10)
        {
            Agent.Enabled = true;
        }

        else
        {
            Agent.Enabled = false;
        }




    }
} 

