using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunJump : MonoBehaviour
{
    /*
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
   */

    private GameObject jump;
    public float visota;

    void Start()
    {
        jump = GameObject.Find("PLAYER");
    }
    void OnTriggerEnter(Collider other)
    {
        var _myscript1 = jump.GetComponent<Rigidbody>();
        _myscript1.AddForce(new Vector3(0, visota, 0));

    }
    // Update is called once per frame
    void Update()
    {

    }
}
