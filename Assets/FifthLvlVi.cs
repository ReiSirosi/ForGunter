using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FifthLvlVi : MonoBehaviour
{
    private GameObject[] objectsWithTag6; // массив объектов с тэгом "6"
    private Vector3 playerPositionOnEnter; // позиция игрока при входе в триггер
    [SerializeField] private GameObject fifthCanvas;
    [SerializeField] private GameObject sixthCanvas;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerPositionOnEnter = other.transform.position; // сохраняем позицию игрока
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
                // игрок вышел из триггера по оси Y вверх
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