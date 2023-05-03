using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMovement2 : MonoBehaviour
{
    private Rigidbody rb;
    public Transform target;

    void OnCollisionEnter()
    {

    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {

            rb.velocity = Vector3.zero; // ���������� �������� ������ ������ ����
            rb.angularVelocity = Vector3.zero; // ���������� ������� �������� ������ ������ ����
            rb.transform.LookAt(target);
        }
    }
}
