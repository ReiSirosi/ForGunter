using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeleportController : MonoBehaviour
{
    [SerializeField] private GameObject questionCanvas;
    [SerializeField] private GameObject placeToTP;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = placeToTP.transform.position;
            questionCanvas.SetActive(true);
        }
    }
}
