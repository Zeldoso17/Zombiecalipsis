using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    [SerializeField] private float cantidadMunicion;

    [SerializeField]  private Municiones municiones;
    // private void OnCollisionEnter2D(Collision2D other)

    private void OnTriggerEnter2D(Collider2D other ) 
    {
        if (other.CompareTag("PLAYER")){
            municiones.SumarPuntos(cantidadMunicion);
            Destroy(gameObject);
        }
    }


}

    
 
