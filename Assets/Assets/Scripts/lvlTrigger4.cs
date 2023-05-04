using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlTrigger4: MonoBehaviour
{
    [SerializeField] private GameObject four;
    public GameObject remove;
    [SerializeField] private Canvas fourCanvas;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var _myscript1 = remove.GetComponent<RotateMovement1>();
            _myscript1.enabled = false;

            var _myscript2 = remove.GetComponent<RotateMovement2>();
            _myscript2.enabled = false;

            var _myscript3 = remove.GetComponent<RotateMovement3>();
            _myscript3.enabled = false;

            var _myscript4 = remove.GetComponent<RotateMovement4>();
            _myscript4.enabled = true;

            var _myscript5 = remove.GetComponent<RotateMovement5>();
            _myscript5.enabled = false;

            var _myscript6 = remove.GetComponent<RotateMovement6>();
            _myscript6.enabled = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            four.transform.Rotate(0f, 180f, 0);
            fourCanvas.gameObject.SetActive(false);
        }
    }
}
