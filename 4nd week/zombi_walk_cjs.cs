using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class zombi_walk_cjs : MonoBehaviour
{
    private Transform goal;
    private NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        goal = Camera.main.transform;
        agent = GetComponent<NavMeshAgent>();
        agent.destination = new Vector3(goal.position.x, goal.position.y, goal.position.z);
        GetComponent<Animation>().Play("walk");
    }

    void OnTriggerEnter(Collider col)
    {
        GetComponent<CapsuleCollider>().enabled = false;
        Destroy(col.gameObject);
        agent.destination = gameObject.transform.position;
        GetComponent<Animation>().Stop();
        GetComponent<Animation>().Play("back_fall");
        Destroy(gameObject, 6);
    }
}