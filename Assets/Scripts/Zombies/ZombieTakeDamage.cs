using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieTakeDamage : MonoBehaviour
{

    [SerializeField] private float vida;
    [SerializeField] private float maximoVida;
    [SerializeField] private BarraDeVida barraDeVida;


    public void Start()
    {
        vida = maximoVida;
        barraDeVida.inicialzarBarraVida(vida);

    }
    public void TakeDamage(float damage)
    {
        Debug.Log("ENtro esto de da;o");
        vida -= damage;
        barraDeVida.CambiarVidaActual(vida);
        if(vida<=0)
        {
            Muerte();
        }
    }

    private void Muerte()
    {
        Destroy(gameObject);
    }

}
