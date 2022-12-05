using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BlackHoleHandler : MonoBehaviour
{
    public DeathScreenHideUntilDeath gameOver;

    // Start is called before the first frame update
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
        }
        Destroy(other.gameObject);
    }
}
