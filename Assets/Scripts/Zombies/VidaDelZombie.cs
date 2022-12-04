using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaDelZombie : MonoBehaviour
{
    [SerializeField] private float vida;
    [SerializeField] private float maximoVida;
    //referiancia ala barra de vida
    [SerializeField] private BarraDeVida barraDeVida;

    private void Start()
    {
        vida = maximoVida;
        barraDeVida.inicialzarBarraVida(vida);

    }
    public void TakeDamage(float damage)
    {
        vida -= damage;
        barraDeVida.CambiarVidaActual(vida);
        if (vida < 0)
        {
            Destroy(gameObject);
        }
    }

}
