using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallToBox : MonoBehaviour
{

    public GameObject remove;
 

    void Start()
    {
        remove = GameObject.Find("PLAYER");
    }
    void OnTriggerEnter(Collider other)
    {
        var _myscript1 = remove.GetComponent<PlayerMovementBox>();
        _myscript1.enabled = true;

        var _myscript2 = remove.GetComponent<PlayerMovementBall>();
        _myscript2.enabled = false;

        var _myscript3 = remove.GetComponent<BoxCollider>();
        _myscript3.enabled = true;

        var _myscript4 = remove.GetComponent<SphereCollider>();
        _myscript4.enabled = false;

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
