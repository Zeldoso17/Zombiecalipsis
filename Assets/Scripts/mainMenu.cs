using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public GameObject fondoOpciones;
    public GameObject fondoMenu;

    public void jugar(){
        SceneManager.LoadScene(1);
    }

    public void opciones(){
        fondoOpciones.SetActive(true);
        fondoMenu.SetActive(false);
    }

    public void regresar(){
        fondoOpciones.SetActive(false);
        fondoMenu.SetActive(true);
    }

    public void salir(){
        Application.Quit();
    }
}
