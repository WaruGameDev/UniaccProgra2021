using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleRayCast : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit) && Input.GetButton("Jump"))
        {
            hit.transform.Rotate(Vector3.up * 200 * Time.deltaTime);
        }
        Debug.DrawLine(transform.position, transform.position + transform.forward * 10, Color.red);
    }
}
