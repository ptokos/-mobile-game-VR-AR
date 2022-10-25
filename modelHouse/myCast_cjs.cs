using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myCast_cjs : MonoBehaviour
{
    void Update()
    {
        RaycastHit hit;
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 1000;
        Debug.DrawRay(transform.position, forward, Color.green);
        if(Physics.Raycast(transform.position, forward, out hit))
        {
            Debug.Log(hit.transform.name);
        }
        
    }
}