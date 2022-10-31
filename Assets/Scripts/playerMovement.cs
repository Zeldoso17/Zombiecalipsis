using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speedMove = 5;
    public float jumpSpeed = 23;
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
        if(Input.GetKey(KeyCode.D)){
            if(spr.flipX){
                spr.flipX = false;
            }
            transform.position += Vector3.right * speedMove * Time.deltaTime;
            anim.SetBool("Walking", true);
        } else {
            anim.SetBool("Walking", false);
        }

        if(Input.GetKey(KeyCode.A)){
            spr.flipX = true;
            transform.position += Vector3.left * speedMove * Time.deltaTime;
            anim.SetBool("Walking", true);
        }else{
            anim.SetBool("Walking", false);
        }

        if(Input.GetKey(KeyCode.W) && enPiso){
            rb.AddForce(new Vector2(0, jumpSpeed), ForceMode2D.Impulse);
            enPiso = false;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "FLOOR"){
            enPiso=true;
        }
    }
}
