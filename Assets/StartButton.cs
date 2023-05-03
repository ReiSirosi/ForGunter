using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    [SerializeField] private GameObject historyImg;
    [SerializeField] private GameObject menuImg;
    [SerializeField] private GameObject menuCanvas;
    public void StartHistory()
    {
        menuImg.SetActive(false);
        historyImg.SetActive(true);
    }

    public void PlayGame()
    {
        menuCanvas.SetActive(false);
    }
}
