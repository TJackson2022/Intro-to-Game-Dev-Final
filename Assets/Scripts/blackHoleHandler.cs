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
    public AudioSource Explosion;
    private UnityEngine.Object explosionRef;

    void Start()
    {
        explosionRef = Resources.Load("Explosion");
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

            GameObject explosion = (GameObject)Instantiate(explosionRef);
            explosion.transform.position = new Vector3(other.transform.position.x, other.transform.position.y, other.transform.position.z);
            Destroy(explosion, 5f);

            Killed++;
            enemiesKilled.text = Killed.ToString();
            Explosion.Play();
        }

    }
  
}
