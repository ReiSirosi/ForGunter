using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdLvlNOButton : MonoBehaviour
{
    [SerializeField] private GameObject questionCanvas;
    public GameObject player;
    public GameObject hintObject;
    public KeyCode keyToPress;
    public Transform target;

    private GameObject[] objectsWithTag3;
    private bool inTrigger;


    void Start()
    {
        objectsWithTag3 = GameObject.FindGameObjectsWithTag("3"); // получить все объекты с тэгом "3"
    }

        private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inTrigger = true;
            hintObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inTrigger = false;
            hintObject.SetActive(false);
        }
    }

    private void Update()
    {
        if (inTrigger && Input.GetKeyDown(keyToPress))
        {
            foreach (GameObject obj in objectsWithTag3)
            {
                obj.SetActive(false);
            }
            questionCanvas.SetActive(false);
        }
    }
}
