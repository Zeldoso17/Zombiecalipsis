using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShoot : MonoBehaviour
{
    [Header("Velocidad de disparo")]
    public int shootSpeed;
    [Header("Posición inicial de la bala")]
    public Transform shootPos;
    [Header("Game Object de la bala")]
    public GameObject bullet;

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    void FixedUpdate()
    {
        Shoot();
    }

    private void Shoot(){
        if(Input.GetButtonDown("Fire1"))
        {
            anim.SetBool("isShooting", true);
            GameObject newBullet = Instantiate(bullet, shootPos.position, Quaternion.identity);
            newBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(shootSpeed * Time.deltaTime, 0f);
        }
        else
        {
            anim.SetBool("isShooting", false);
        }
    }
}
