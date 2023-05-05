using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementJump : MonoBehaviour
{
    private bool isGrounded;
    private Rigidbody rb;

    void OnCollisionEnter()
    {
        isGrounded = true;
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {

        if (isGrounded)
        {
            isGrounded = false;
            rb.AddForce(new Vector3(0, 500, 0));
        }
    }
}