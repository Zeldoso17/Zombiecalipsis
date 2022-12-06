using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoJugador : MonoBehaviour
{
    [SerializeField] private Transform controladorDisparo;
    [SerializeField] private GameObject bala;



    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Disparar();
        }
    } 





    private void Disparar()
    {
        //le decimos que queremos  crear un nuevo obejto dentro del jugo, le colocamos el objeto , y donde estara 
        Instantiate(bala,controladorDisparo.position,controladorDisparo.rotation);
    }
}
