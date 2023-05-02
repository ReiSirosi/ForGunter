using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YesButton : MonoBehaviour
{
    [SerializeField] private GameObject questionCanvas;
    public GameObject player;
    public GameObject nextLvl;
    public GameObject hintObject;
    public KeyCode keyToPress;
    public Transform target;

    private bool inTrigger;

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
            player.transform.position = nextLvl.transform.position;
            questionCanvas.SetActive(false);
            player.transform.LookAt(target);
        }
    }
}
