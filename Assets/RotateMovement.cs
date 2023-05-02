using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMovement : MonoBehaviour
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

            //rb.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
            rb.velocity = Vector3.zero; // ���������� �������� ������ ������ ����
            rb.angularVelocity = Vector3.zero; // ���������� ������� �������� ������ ������ ����
            rb.transform.LookAt(target);
        }
    }
}
