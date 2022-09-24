using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;

    public float speed;
    private float moveInput;

    public bool facingRigth = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        if (facingRigth == false && moveInput > 0)
            Flip();
        else if (facingRigth == true && moveInput < 0)
            Flip();
    }

    void Flip()
    {
        facingRigth = !facingRigth;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
