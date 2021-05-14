using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour
{
    public GameObject winScreen;
    public GameObject timeDisplay;
    public GameObject gamePanels;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gamePanels.SetActive(false);
            winScreen.SetActive(true);
            timeDisplay.GetComponent<UnityEngine.UI.Text>().text = "Your Result: " + TimeControler.time;
            Time.timeScale = 0f;
        }

    }

    void Update()
    {
        
    }

}
