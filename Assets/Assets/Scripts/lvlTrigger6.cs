using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvlTrigger6: MonoBehaviour
{

    public GameObject remove;


    void Start()
    {
        //Ball = GameObject.Find("Ball");
    }
    void OnTriggerEnter(Collider other)
    {
        var _myscript1 = remove.GetComponent<RotateMovement1>();
        _myscript1.enabled = false;

        var _myscript2 = remove.GetComponent<RotateMovement2>();
        _myscript2.enabled = false;

        var _myscript3 = remove.GetComponent<RotateMovement3>();
        _myscript3.enabled = false;

        var _myscript4 = remove.GetComponent<RotateMovement4>();
        _myscript4.enabled = false;

        var _myscript5 = remove.GetComponent<RotateMovement5>();
        _myscript5.enabled = false;

        var _myscript6 = remove.GetComponent<RotateMovement6>();
        _myscript6.enabled = true;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
