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
            Rigidbody playerRb = other.GetComponent<Rigidbody>();
            playerRb.MovePosition(placeToTP.transform.position);
            playerRb.velocity = Vector3.zero; // установить скорость игрока равной нулю
            playerRb.angularVelocity = Vector3.zero;
            questionCanvas.SetActive(true);
        }
    }
}
