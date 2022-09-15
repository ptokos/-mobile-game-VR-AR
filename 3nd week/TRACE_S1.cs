using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TRACE_S1 : MonoBehaviour
{
    private Transform goal;
    private NavMeshAgent agent;
    void Start()
    {   //도착지를 메인카메라의 위치로 지정
        goal = Camera.main.transform;
        //자율주장자동차 모드
        agent = GetComponent<NavMeshAgent>();
        //목적지를 향해 출발
        agent.destination = new Vector3(goal.position.x, goal.position.y, goal.position.z + 5);
        //걸으면서 움직임
        GetComponent<Animation>().Play("walk");
    }
}