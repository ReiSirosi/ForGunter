using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpJoker : MonoBehaviour
{
    [SerializeField] private float x;
    [SerializeField] private float y;
    [SerializeField] private float z;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Rigidbody playerRb = other.GetComponent<Rigidbody>();
            playerRb.AddForce(x, y, z);
            Debug.Log("Сила задана");
        }
    }
}
