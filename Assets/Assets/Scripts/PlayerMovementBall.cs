using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBall : MonoBehaviour
{
    public float speed;
    Rigidbody rb;
    Transform mainCamera;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mainCamera = Camera.main.transform;
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(h, 0, v);
        direction = mainCamera.TransformDirection(direction);
        direction.y = 0;
        rb.AddForce(direction.normalized * speed);
    }
}
