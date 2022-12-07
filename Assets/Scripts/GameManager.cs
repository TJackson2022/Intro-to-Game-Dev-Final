using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float scoreTotal = 0f,
        scoreCurrent = 0f,
        timeLeft = 0f,
        livesStart = 0f,
        livesLeft = 0f;

    public bool isDead;

    // Start is called before the first frame update
    void Start()
    {
        // Level 1
        // Set score current and total to 0
        // Set time left to 60, or w/e
        // Set lives left to lives start

        // Spawn player
        // Wait few seconds
        // Begin spawning in enemies


    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            //GameOver();
        }

        if (isDead)
        {
            //GameOver();
        }
    }
}
