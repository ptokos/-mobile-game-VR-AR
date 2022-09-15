using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class zwalk_1_cjs : MonoBehaviour
{
    private Transform targetTr; //목표지점
    private NavMeshAgent nma; //자율주행자동차
    void Start()
    {   //최종목적지
        targetTr = GameObject.Find("Cylinder").GetComponent<Transform>();
        nma = GetComponent<NavMeshAgent>();//자율주행 장착
    }
    void Update()
    {
        nma.destination = targetTr.position;//목표지점을 향해 출발
    }
}