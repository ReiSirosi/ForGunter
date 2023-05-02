using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastLvlNOBUTTON : MonoBehaviour
{
    [SerializeField] private GameObject questionCanvas;
    [SerializeField] private GameObject afterCanvas;
    public GameObject player;
    public GameObject hintObject;
    public KeyCode keyToPress;

    private GameObject[] objectsWithTag4;
    private GameObject[] objectsWithTag6;
    private bool inTrigger;


    void Start()
    {
        objectsWithTag4 = GameObject.FindGameObjectsWithTag("4"); // получить все объекты с тэгом "4"
        objectsWithTag6 = GameObject.FindGameObjectsWithTag("6");
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
            foreach (GameObject obj in objectsWithTag4)
            {
                obj.SetActive(false);
            }
            foreach (GameObject obj in objectsWithTag6)
            {
                obj.SetActive(false);
            }
            questionCanvas.SetActive(false);

            afterCanvas.SetActive(true);
        }
    }
}
