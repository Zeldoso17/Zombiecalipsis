using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class qualityScript : MonoBehaviour
{
    
    public TMP_Dropdown dropdown;
    public int calidad;

    void Start()
    {
        calidad = PlayerPrefs.GetInt("qualityNumber", 3);
        dropdown.value = calidad;
        qualityManage();
    }

    public void qualityManage()
    {
        QualitySettings.SetQualityLevel(dropdown.value);
        PlayerPrefs.SetInt("qualityNumber", dropdown.value);
        calidad = dropdown.value;
    }
}
