using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwap : MonoBehaviour
{

   // private GameObject Ball;
    private GameObject Cam1;
    public GameObject Cam2;
    public GameObject Kub;
    //public float speed;

    void Start()
    {
        Cam1 = GameObject.Find("Main Camera");
        //Kub = GameObject.Find("CubeUbiytsa");
        //Cam1 = Ball.GetComponent<Camera>();
        //Cam1 = Camera.main;
    }
    void OnTriggerEnter(Collider other)
    {
        Cam1.SetActive(false);
        Cam2.SetActive(true);
        //Kub.transform.Translate(Vector3.forward * speed * Time.deltaTime);

    }
    void Update()
    {

    }
}
