using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeScript : MonoBehaviour
{
    
    public Slider sliderVolume;
    public float sliderValue;
    public Image imageMute;

    void Start()
    {
        sliderVolume.value = PlayerPrefs.GetFloat("audioVolume", 0.5f);
        AudioListener.volume = sliderVolume.value;
        checkMute();
    }

    public void changeVolume(float value)
    {
        sliderValue = value;
        PlayerPrefs.SetFloat("audioVolume", sliderValue);
        AudioListener.volume = sliderVolume.value;
        checkMute();
    }

    public void checkMute()
    {
        if(sliderValue == 0)
        {
            imageMute.enabled = true;
        }
        else
        {
            imageMute.enabled = false;
        }
    }
}
