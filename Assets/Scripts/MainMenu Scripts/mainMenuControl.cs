using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainMenuControl : MonoBehaviour
{
    private float value;
    public Image brightnessPanel;
    
    void Start()
    {
        changeBrightness();
    }

    void FixedUpdate()
    {
        changeBrightness();
    }

    private void changeBrightness()
    {
        value = PlayerPrefs.GetFloat("brightness");
        brightnessPanel.color = new Color(brightnessPanel.color.r, brightnessPanel.color.g, brightnessPanel.color.b, value);
    }
}
