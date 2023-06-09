using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeleportController : MonoBehaviour
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
            playerRb.velocity = Vector3.zero; // ���������� �������� ������ ������ ����
            playerRb.angularVelocity = Vector3.zero;
            questionCanvas.SetActive(true);
            playerRb.transform.LookAt(target);
        }
    }
}
