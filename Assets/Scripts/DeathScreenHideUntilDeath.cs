using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreenHideUntilDeath : MonoBehaviour
{
    public static AudioSource myAudio;
    public static AudioManger Instance;
    private float defaultPitch;
    public bool IsDead;
    public GameObject DeathScreen;
   
    public GameObject AudioManager;
    void Start()
    {
        DeathScreen.SetActive(false);
        
    }
    
 
    // Update is called once per frame
    void Update()
    {
      
        if (IsDead == true)
        {
            Debug.Log("Recieved IsDead message");
            DeathScreen.SetActive(true);
            //AudioListener.volume = 0f;
            Time.timeScale = 0f;
            //AudioManager.SetActive(false);
            new WaitForSeconds(1);
            //deadMusic.Play();
            //Debug.Log("PlayedDeathMusic");
        }

 
}

}
