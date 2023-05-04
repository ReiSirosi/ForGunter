using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Harvest : MonoBehaviour
{
    [SerializeField] private GameObject thiss;
    private int count;
    public Canvas canvasToActivate;
    [SerializeField] private Text countText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.collectedCount++;
            countText.text = GameManager.collectedCount.ToString();
            StartCoroutine(ActivateCanvasForThreeSeconds());
        }
    }

    IEnumerator ActivateCanvasForThreeSeconds()
    {
        // Активируем канвас
        canvasToActivate.gameObject.SetActive(true);

        // Ждем три секунды
        yield return new WaitForSeconds(3f);

        // Деактивируем канвас
        canvasToActivate.gameObject.SetActive(false);
        Destroy(thiss);
    }
}
