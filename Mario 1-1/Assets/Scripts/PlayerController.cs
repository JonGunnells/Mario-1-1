using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D rb;

    public float speed, height = 2.0f;

    void Start()
    {
        speed = 100;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, rb.velocity.y);
        if(Input.GetKey(KeyCode.UpArrow) || (Input.GetKey(KeyCode.W)) || Input.GetKey(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, height);
        }
    }
}
