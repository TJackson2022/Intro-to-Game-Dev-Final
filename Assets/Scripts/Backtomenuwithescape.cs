using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Backtomenuwithescape : MonoBehaviour
{
    void Update()
    {
        if(Input.GetButtonDown("Cancel"))
        {
            LoadMenu();
        }
    }

    // Update is called once per frame
    public void LoadMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
