using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zombieToPlayerDamage : MonoBehaviour
{

    private playerHealthController playerHealthController = new playerHealthController();
    public int damageToPlayer = 5;
    public GameObject player;
    public Slider Life;
    private Animator anim;

    void Start()
    {
        Life.maxValue = 100;
        Life.minValue = 0;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "PLAYER"){
            anim.SetBool("Beat", true);
            playerHealthController.playerDamage(damageToPlayer, player, Life);
        }
    }
    void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.tag == "PLAYER"){
            anim.SetBool("Beat", false);
        }
    }
}