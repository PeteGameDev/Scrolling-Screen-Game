using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownController : MonoBehaviour
{
   
    Rigidbody2D rb2D;
    Vector3 moveDirection;
    bool facingRight = true;
    public float walkSpeed;

    private void Start() 
    {
        rb2D = GetComponent<Rigidbody2D>();    
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        moveDirection = (moveHorizontal * transform.right + moveVertical * transform.up).normalized;
        rb2D.velocity = moveDirection * walkSpeed * Time.deltaTime;

       if(moveHorizontal > 0 && !facingRight)
        {
           Flip();
        }
       else if (moveHorizontal < 0 && facingRight)
        {
           Flip();
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 playerScale = transform.localScale;
        playerScale.x *= -1;
        transform.localScale = playerScale;
    }
}
