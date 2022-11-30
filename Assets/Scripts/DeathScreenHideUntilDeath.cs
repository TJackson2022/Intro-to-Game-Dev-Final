using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreenHideUntilDeath : MonoBehaviour
{
    public bool IsDead;
    public GameObject DeathScreen;
    void Start()
    {
        DeathScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (IsDead == true)
        {
            DeathScreen.SetActive(true);
        }
    }
}
