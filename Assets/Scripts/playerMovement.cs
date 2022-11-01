using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [Header("Speed player")]
    public float speedMove = 5;
    public float jumpSpeed = 23;
    [Header("Collision")]
    public bool enPiso = true;
    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer spr;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        spr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.A)){
            spr.flipX = true;
            transform.position += Vector3.left * speedMove * Time.deltaTime;
            anim.SetBool("Walking_Left", true);
        }else{
            anim.SetBool("Walking_Left", false);
        }

        if(Input.GetKey(KeyCode.D)){
            if(spr.flipX){
                spr.flipX = false;
            }
            transform.position += Vector3.right * speedMove * Time.deltaTime;
            anim.SetBool("Walking_right", true);
        } else {
            anim.SetBool("Walking_right", false);
        }

        if(Input.GetKey(KeyCode.W) && enPiso){
            rb.AddForce(new Vector2(0, jumpSpeed), ForceMode2D.Impulse);
            enPiso = false;
        }

        if(Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.AltGr)){
            Debug.Log("CORRER MAS RAPIDO");
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "FLOOR"){
            enPiso=true;
        }
    }
    void OnCollisionExit(Collision other)
    {
     Debug.Log("HA SALTADO");
    }
}
