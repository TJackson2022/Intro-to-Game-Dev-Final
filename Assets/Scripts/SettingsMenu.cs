using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    void Start()
    {
        
    }
    public void EditVolume()
    {
        AudioListener.volume = volumeSlider.value;
    }
}
