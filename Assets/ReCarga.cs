using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReCarga : MonoBehaviour
{
    [SerializeField] private float cantidadMunicion;
    [SerializeField] private Municiones municiones;



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PLAYER"))
        {
            municiones.SumarPuntos(cantidadMunicion);
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
