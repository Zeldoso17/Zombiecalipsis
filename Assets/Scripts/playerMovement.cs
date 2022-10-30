using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speedMove = 15;
    public float jumpSpeed = 20;
    public bool enPiso = true;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D)){
            transform.position += Vector3.right * speedMove * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.A)){
            transform.position += Vector3.left * speedMove * Time.deltaTime;
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
