using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootRaycast : MonoBehaviour
{
    public Transform shootingOrigin;
    public GameObject impactParticles;
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            if(Physics.Raycast(shootingOrigin.position, shootingOrigin.forward, out hit))
            {
                if(hit.collider.CompareTag("Unit"))
                {
                    hit.transform.GetComponent<Rigidbody>().AddForce(500 * shootingOrigin.forward);
                    Instantiate(impactParticles, hit.point, Quaternion.identity);
                }
            }
        }
    }
}
