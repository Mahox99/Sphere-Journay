using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControler : MonoBehaviour
{
    public GameObject gamePanel;
    public GameObject winPanel;
    public GameObject PausePanel;

    //public AudioSource music;

    void Start()
    {
        Time.timeScale = 1f;
        //music.Play(); Ops I don't have any music for publishing ;)
    }

    public void Update()
    {
        if (Input.GetButtonDown("Reset"))
            SceneManager.LoadScene(1);

        if (Input.GetButtonDown("Pause"))
        {
            Time.timeScale = 0f;
            PausePanel.SetActive(true);
        }
    }
    public void PlayGame()
    {
        gamePanel.SetActive(true);
        Time.timeScale = 1f;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        PausePanel.SetActive(false);
    }

}
