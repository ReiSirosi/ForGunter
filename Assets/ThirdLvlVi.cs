using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdLvlVi : MonoBehaviour
{
    private GameObject[] objectsWithTag4; // ������ �������� � ����� "4"
    private GameObject[] objectsWithTag5; // ������ �������� � ����� "5"
    private GameObject[] objectsWithTag6; // ������ �������� � ����� "6"
    private Vector3 playerPositionOnEnter;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerPositionOnEnter = other.transform.position;
            foreach (GameObject obj in objectsWithTag4)
            {
                obj.SetActive(false);
            }
            foreach (GameObject obj in objectsWithTag5)
            {
                obj.SetActive(false);
            }
            foreach (GameObject obj in objectsWithTag6)
            {
                obj.SetActive(false);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Vector3 playerPositionOnExit = other.transform.position;
            if (playerPositionOnExit.y > playerPositionOnEnter.y)
            {
                // ����� ����� �� �������� �� ��� Y �����
                foreach (GameObject obj in objectsWithTag4)
                {
                    obj.SetActive(true);
                }
            }
        }
    }

    void Start()
    {
        objectsWithTag4 = GameObject.FindGameObjectsWithTag("4"); // �������� ��� ������� � ����� "4"
        objectsWithTag5 = GameObject.FindGameObjectsWithTag("5"); // �������� ��� ������� � ����� "5"
        objectsWithTag6 = GameObject.FindGameObjectsWithTag("6"); // �������� ��� ������� � ����� "6"
    }
}