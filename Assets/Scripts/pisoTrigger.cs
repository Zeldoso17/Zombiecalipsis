using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pisoTrigger : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "PLAYER"){
            Debug.Log("colisionó jejeje");
        }
    }
}
