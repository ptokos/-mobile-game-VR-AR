using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_cjs : MonoBehaviour
{
    private GameObject gun;
    private GameObject spawnPoint;
    private bool isShooting;
    void Start()
    {
        gun = gameObject.transform.GetChild(0).gameObject;
        spawnPoint = gun.transform.GetChild(0).gameObject;
        isShooting = false;
    }
    IEnumerator Shoot()
    {
        isShooting = true;
        GameObject bullet = Instantiate(Resources.Load("bullet", typeof(GameObject))) as GameObject;
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        bullet.transform.rotation = spawnPoint.transform.rotation;
        bullet.transform.position = spawnPoint.transform.position;
        rb.AddForce(spawnPoint.transform.forward * 500f);
        GetComponent<AudioSource>().Play();
        gun.GetComponent<Animation>().Play();
        Destroy(bullet, 1);
        yield return new WaitForSeconds(1f);
        isShooting = false;
    }
    void Update()
    {
        RaycastHit hit;
        Debug.DrawRay(spawnPoint.transform.position, spawnPoint.transform.forward, Color.green);
        if (Physics.Raycast(spawnPoint.transform.position, spawnPoint.transform.forward, out hit, 100))
        {
            if (hit.collider.name.Contains("zombie"))
            {
                if (!isShooting)
                {
                    StartCoroutine("Shoot");
                }
            }
        }
    }
}