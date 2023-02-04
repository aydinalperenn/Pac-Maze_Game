using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class move_pacman : MonoBehaviour
{
    public Transform player;
    NavMeshAgent nMesh;

    void Start()
    {
        nMesh= GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        nMesh.destination = player.position;
    }
}
