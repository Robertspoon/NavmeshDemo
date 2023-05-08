using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerControler : MonoBehaviour
{
    public NavMeshAgent agent;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray MovePosition = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(MovePosition, out var HitInfo))
            {
                agent.SetDestination(HitInfo.point);
            }
        }
    }
}
