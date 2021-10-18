using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerPlatform : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speedCharacter = 5;
    public Animator anim;
    public Transform model;
    public bool isGrounded;
    public LayerMask floor;
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(x * speedCharacter * Time.deltaTime, rb.velocity.y);
        anim.SetFloat("speed", Mathf.Abs(rb.velocity.x));
        if (rb.velocity.x < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else if (rb.velocity.x > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        
        if(isGrounded && Input.GetButtonDown("Jump"))
        {
            Jump();
        }

        isGrounded = DetectFloor();
    }
    public void Jump()
    {
        rb.AddForce(Vector2.up * 500);
    }
    public bool DetectFloor()
    {
        Debug.DrawRay(transform.position, Vector2.down*.2f, Color.red);
        return Physics2D.Raycast(transform.position, Vector2.down, .2f, floor);
    }
}
