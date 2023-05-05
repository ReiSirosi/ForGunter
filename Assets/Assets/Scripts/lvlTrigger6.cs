using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvlTrigger6: MonoBehaviour
{
    [SerializeField] private GameObject six;
    [SerializeField] private GameObject one;
    [SerializeField] private GameObject two;
    [SerializeField] private Canvas tryMore;
    [SerializeField] private Canvas nice;
    private GameObject remove;
    [SerializeField] private Canvas sixCanvas;
    private bool countYes = true;
    private bool countNo = false;

    void Start()
    {
        remove = GameObject.Find("PLAYER");
    }

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
            _myscript4.enabled = false;

            var _myscript5 = remove.GetComponent<RotateMovement5>();
            _myscript5.enabled = false;

            var _myscript6 = remove.GetComponent<RotateMovement6>();
            _myscript6.enabled = true;

            if (GameManager.collectedCount >= 2)
            {
                GameManager.count = countYes;
                one.SetActive(true);
                two.SetActive(true);
                nice.gameObject.SetActive(true);
                tryMore.gameObject.SetActive(false);
            }
            else if (GameManager.collectedCount < 2)
            {
                GameManager.count = countNo;
                tryMore.gameObject.SetActive(true);
                nice.gameObject.SetActive(false);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            six.transform.Rotate(0f, 180f, 0);
            sixCanvas.gameObject.SetActive(false);
            nice.gameObject.SetActive(false);
            tryMore.gameObject.SetActive(false);
        }
    }
}
