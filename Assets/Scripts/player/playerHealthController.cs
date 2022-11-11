using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHealthController : MonoBehaviour
{
   
   private int playerHealth = 100;
   private float r;
   private float g;
   private float b;
   private float a;
   

    void Start()
    {
        Debug.Log(playerHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playerDamage(int playerDamage, GameObject player, Image bloodImage){
        playerHealth = playerHealth - playerDamage;
        r = bloodImage.color.r;
        g = bloodImage.color.g;
        b = bloodImage.color.b;
        a = bloodImage.color.a;
        Color c = new Color(r, g, b, a);
        bloodImage.color = c;
        a += 0.01f;
        a = Mathf.Clamp(a, 0, 1f);
        Debug.Log(a);
        if(playerHealth == 0){
            Debug.Log("Player Death");
            Destroy(player);
        }
    }
}
