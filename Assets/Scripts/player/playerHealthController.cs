using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHealthController : MonoBehaviour
{
   
   private int playerHealth = 100;
    void Start()
    {
        Debug.Log(playerHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playerDamage(int playerDamage, GameObject player, Slider life){
        playerHealth = playerHealth - playerDamage;
        life.value = playerHealth;
        if(life.value == 0){
            Debug.Log("Player Death");
            Destroy(player);
        }
    }
}
