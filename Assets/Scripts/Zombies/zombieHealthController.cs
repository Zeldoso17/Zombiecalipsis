using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zombieHealthController : MonoBehaviour
{
    
    private int zombieHealth = 100;
    private int zombieHealth2 = 0;
    private Slider zombieLife;
    void Start()
    {
        //zombie = GameObject.FindGameObjectWithTag("ZOMBIE");
        zombieLife = GameObject.FindGameObjectWithTag("zombieLife").GetComponent<Slider>();

        //zombieLife.maxValue = 100;
        //zombieLife.minValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void FixedUpdate()
    {
        Debug.Log("ogfjoijf -> " + zombieHealth);
    }

    public void zombieDamage(int zombieDamage){
        Debug.Log("Antes de bajar la vida -> "+zombieHealth);
        zombieHealth = zombieHealth - zombieDamage;
        zombieHealth2 = zombieHealth - zombieDamage;
        Debug.Log("Despues de bajar la vida -> "+zombieHealth2);
        zombieLife.value = zombieHealth;
        /*if(zombieLife.value == 0){
            Debug.Log("Zombie Death");
            Destroy(zombie);
        }*/
    }
}
