using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ZombieAtack : MonoBehaviour
{
    [SerializeField] private float tiempoEntreDamage;
    private float tiempoSiguenteDamage;
    // Start is called before the first frame update


    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.collider.CompareTag("PLAYER"))
        {   
            tiempoSiguenteDamage -=Time.deltaTime;
            if(tiempoSiguenteDamage <= 0)
            {
                other.collider.GetComponent<VidaDelJugador>().TakeDamage(10);
                tiempoSiguenteDamage = tiempoEntreDamage;
            }
           
        }
    }
}
