using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoButton : MonoBehaviour
{
    [SerializeField] private GameObject questionCanvas;
    public GameObject player;
    public GameObject goToFirstLvl;
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
            player.transform.position = goToFirstLvl.transform.position;
            questionCanvas.SetActive(false);
            player.transform.LookAt(target);
        }
    }
}
