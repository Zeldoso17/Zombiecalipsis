using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class GeneradorNivel : MonoBehaviour

{
    [SerializeField] private GameObject[] partesNivel;

    [SerializeField] private float  distanciaMinima;

    [SerializeField] private Transform  puntoFinal;

    [SerializeField] private int cantidadInicial;


    private Transform jugador;


    // Start is called before the first frame update
    void Start() {
        jugador = GameObject.FindGameObjectWithTag("PLAYER").transform; 
        for(int i=0; i < cantidadInicial; i++)
        {
            GenerarParteNivel();
        }
    
    }
            

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(jugador.position, puntoFinal.position) < distanciaMinima)
        {
            GenerarParteNivel();

        }
    }

    private void GenerarParteNivel()
    {
        int numRandom = Random.Range(0, partesNivel.Length);
        GameObject nivel = Instantiate(partesNivel[numRandom], puntoFinal.position, Quaternion.identity);
        puntoFinal = BuscarPuntoFinal(nivel, "PuntoFinal");
    } 

    private Transform BuscarPuntoFinal(GameObject parteNivel, string etiqueta)
    {
        Transform punto = null;

        foreach(Transform ubicacion in parteNivel.transform) {
            if(ubicacion.CompareTag(etiqueta))
            {
                punto = ubicacion;
                break;
            }
        
        }
        return punto;
          
    }
}
 