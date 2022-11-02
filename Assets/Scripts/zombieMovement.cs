using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieMovement : MonoBehaviour
{
    
    public float speedMove = 13f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speedMove * Time.deltaTime;
    }
}
