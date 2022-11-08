using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nivelesBrightness : MonoBehaviour
{
    
    private float value;
    public Image brightnessPanel; 

    void Start()
    {
        changeBrightness();
    }

    // Update is called once per frame
    void Update()
    {
        changeBrightness();
    }

    private void changeBrightness()
    {
        value = PlayerPrefs.GetFloat("brightness");
        Debug.Log("Valor: " + value);
        brightnessPanel.color = new Color(brightnessPanel.color.r, brightnessPanel.color.g, brightnessPanel.color.b, value);
    }
}
