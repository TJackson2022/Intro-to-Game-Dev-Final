using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryScript : MonoBehaviour
{
    public bool isWon;
    public GameObject VictoryScreen;
    // Start is called before the first frame update
    void Start()
    {
        VictoryScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isWon == true)
        {
            VictoryScreen.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
