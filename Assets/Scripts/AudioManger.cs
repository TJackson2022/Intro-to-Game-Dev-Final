using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManger : MonoBehaviour
{
    public bool isDead;
    public static AudioSource myAudio;
    public static AudioManger Instance;
    private float defaultPitch;
    // Start is called before the first frame update
    void Start()
    {
        // protects against two songs playing at once when coming back into the game from the main menu
        if (Instance != null)
        {
            //Destroy(this.gameObject);
        }
        else
        {
            //Instance = this;
        }

        
        
       
    }
    public void PauseMusic()
    {
        myAudio.pitch = 0;
    }
    public void UnPauseMusic()
    {
        myAudio.pitch = defaultPitch;
    }

   
}
