using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public Rigidbody2D rb;
    public float movespeed;
    public float jumpspeed;
    public bool moveright;
    public bool moveleft;
    public bool jump;
    private bool isJumping;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //keyboard controls
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-movespeed, rb.velocity.y);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(movespeed, rb.velocity.y);
        }

        //touch controls
        if (moveright)
        {
         rb.velocity = new Vector2(movespeed, rb.velocity.y);
        }
         if (moveleft)
         {
         rb.velocity = new Vector2(-movespeed, rb.velocity.y);
         }

         //jumping controlls
         if (jump && !isJumping)
         {
            isJumping = true;

            rb.velocity = new Vector2(rb.velocity.x, jumpspeed); //looks like placement of value in the parameters matters?
                                                                 //well thats not confusing at all...
            jump = false;
         }
         //if (!jump)
         //{
         //   isJumping = false;
         //}

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }
}
