using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FifthLvlVi : MonoBehaviour
{
    private GameObject[] objectsWithTag6; // ������ �������� � ����� "6"
    private Vector3 playerPositionOnEnter; // ������� ������ ��� ����� � �������
    [SerializeField] private GameObject fifthCanvas;
    [SerializeField] private GameObject sixthCanvas;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerPositionOnEnter = other.transform.position; // ��������� ������� ������
            foreach (GameObject obj in objectsWithTag6)
            {
                obj.SetActive(false);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        fifthCanvas.SetActive(false);
        sixthCanvas.SetActive(false);
        if (other.CompareTag("Player"))
        {
            Vector3 playerPositionOnExit = other.transform.position;
            if (playerPositionOnExit.y > playerPositionOnEnter.y)
            {
                // ����� ����� �� �������� �� ��� Y �����
                foreach (GameObject obj in objectsWithTag6)
                {
                    obj.SetActive(true);
                }
            }
        }
    }

    void Start()
    {
        objectsWithTag6 = GameObject.FindGameObjectsWithTag("6"); 
    }
}