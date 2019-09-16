using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    public float speed;
    void Start()
    {
        Rigidbody2D bullet_rigidbody = new Rigidbody2D();
        bullet_rigidbody = GetComponent<Rigidbody2D>();

        bullet_rigidbody.velocity = transform.right * speed;
    }

    void Update()
    {
        
    }
}
