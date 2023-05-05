using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxToBall : MonoBehaviour
{

    private GameObject remove;
 

    void Start()
    {
        remove = GameObject.Find("PLAYER");
    }
    void OnTriggerEnter(Collider other)
    {
        var _myscript1 = remove.GetComponent<PlayerMovementBox>();
        _myscript1.enabled = false;

        var _myscript2 = remove.GetComponent<PlayerMovementBall>();
        _myscript2.enabled = true;

        var _myscript3 = remove.GetComponent<BoxCollider>();
        _myscript3.enabled = false;

        var _myscript4 = remove.GetComponent<SphereCollider>();
        _myscript4.enabled = true;

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
