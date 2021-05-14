using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrainingMenuControler : MonoBehaviour
{
    public GameObject PausePanel;
    void Start()
    {
        Time.timeScale = 1f;
    }

    public void Update()
    {
        if (Input.GetButtonDown("Reset"))
            SceneManager.LoadScene(2);

        if (Input.GetButtonDown("Pause"))
        {
            Time.timeScale = 0f;
            PausePanel.SetActive(true);
        }
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1f;
    }
    public void Resume()
    {
        Time.timeScale = 1f;
        PausePanel.SetActive(false);
    }
}
