using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;

public class BlackHoleHandler : MonoBehaviour
{
    public DeathScreenHideUntilDeath gameOver;
    static int Killed = 0;
    public TextMeshProUGUI enemiesKilled;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            gameOver.IsDead = true;
            Debug.Log("IsDead is true");
        }
        Destroy(other.gameObject);
        if (other.tag == "Enemy")
        {
            Debug.Log("Enemy kill");
            Killed++;
            enemiesKilled.text = Killed.ToString();
        }

    }
  
}
