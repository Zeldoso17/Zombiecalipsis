using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeVida : MonoBehaviour
{

    private Slider slider;




    public void Start()
    {
        slider = GetComponent<Slider>();
    }
    public void CambiarVidaMaxima(float vidaMaxima)
    {
        slider.maxValue= vidaMaxima;
    }
    
    public void CambiarVidaActual(float cantidadVVida) {
        slider.value= cantidadVVida;
    }
    public void inicialzarBarraVida (float cantidadVida) {
        CambiarVidaMaxima(cantidadVida);
        CambiarVidaActual(cantidadVida);

    
    }
}
