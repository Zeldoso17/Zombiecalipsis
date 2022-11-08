using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class optionsScript : MonoBehaviour
{
    
    public ControladorOpciones panelOpciones;

    void Start()
    {
        panelOpciones = GameObject.FindGameObjectWithTag("Options").GetComponent<ControladorOpciones>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.O))
        {
            mostrarOpciones();
        }
    }

    public void mostrarOpciones()
    {
        panelOpciones.OptionsScreen.SetActive(true);
    }
}
