using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float scoreTotal = 0f,
        scoreCurrent = 0f,
        timeStart = 60f,
        timeLeft = 60f,
        livesStart = 5f,
        livesLeft = 5f;

    public GameObject deathScreen;

    public bool isDead;

    // Start is called before the first frame update
    void Start()
    {
        // Level 1

    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            GameOver();
        }

        if (livesLeft == 0)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        deathScreen.SetActive(true);
        Time.timeScale = 0f;
        AudioListener.volume = 0f;
    }

    public void ToggleIsDead()
    {
        isDead = !isDead;
    }

    public void ScoreIncrease()
    {
        scoreCurrent++;
    }

    public void LoseLife()
    {
        livesLeft--;
    }
}
