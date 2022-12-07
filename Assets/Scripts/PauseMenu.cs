using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;


public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public float volumeSlider;
    public bool isPaused = false;
    public TextMeshProUGUI enemiesKilled;
    static int killed = 0;
    void Start()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
    }
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            Debug.Log("Paused");
            TogglePauseGame();
        }
    }
    public void TogglePauseGame()
    {
        isPaused = !isPaused;
        pauseMenu.SetActive(isPaused);
        if (isPaused)
        {
            Time.timeScale = 0f;
            AudioListener.volume = 0f;
        }
        else
        {
            Time.timeScale = 1f;
            volumeSlider = PlayerPrefs.GetFloat("musicVolume");
            AudioListener.volume = volumeSlider;
            Debug.Log("Volume Back to default");
        }


    }
    public void LoadLevel(string sceneName)
    {
        if (null == enemiesKilled)
        {
            Debug.Log("Aleady at 0");
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            enemiesKilled.text = killed.ToString();
            SceneManager.LoadScene(sceneName);
        }



    }

}
