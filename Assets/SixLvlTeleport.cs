using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SixLvlTeleport : MonoBehaviour
{
    [SerializeField] private GameObject questionCanvas;
    [SerializeField] private GameObject placeToTP;
    [SerializeField] private GameObject rotateCifra;
    public Transform target;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            rotateCifra.transform.Rotate(0f, 180f, 0f);
            Rigidbody playerRb = other.GetComponent<Rigidbody>();
            playerRb.MovePosition(placeToTP.transform.position);
            playerRb.velocity = Vector3.zero; // установить скорость игрока равной нулю
            playerRb.angularVelocity = Vector3.zero;
            playerRb.transform.LookAt(target);

            if (GameManager.count == false)
            {
                questionCanvas.SetActive(false);
            }
            else
                questionCanvas.SetActive(true);
        }
    }
}
