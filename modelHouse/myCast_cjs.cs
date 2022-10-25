using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myCast_cjs : MonoBehaviour
{
    public GameObject head;
    public GameObject pos1;
    void Update()
    {
        RaycastHit hit;
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 1000;
        Debug.DrawRay(transform.position, forward, Color.green);
        if(Physics.Raycast(transform.position, forward, out hit))
        {
            if (hit.collider.tag == "reTag")
            {
                StartCoroutine(moveCo());
            }
            Debug.Log(hit.transform.name);
        }
        
    }
    
    IEnumerator moveCo()
    {
        while(head.transform.position != pos1.transform.position)
        {
            head.transform.position = Vector3.MoveTowards(head.transform.position, pos1.transform.position, Time.deltaTime * 0.08f);
            yield return null;
        }
    }
}