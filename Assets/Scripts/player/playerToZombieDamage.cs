using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerToZombieDamage : MonoBehaviour
{
    
    private zombieHealthController zombieHealthController = new zombieHealthController();
    public int damageToZombie = 10;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "ZOMBIE"){
            Debug.Log("La bala tocó al zombie");
            Destroy(gameObject);
            zombieHealthController.zombieDamage(damageToZombie);
        }
    }
}
