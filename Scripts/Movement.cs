using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb2d;
    [SerializeField]bool isGrounded;
    [SerializeField]float runSpeed;
    float JumpSpeed = 20f;
    Animator playerAnim;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    private void PlayerMove()
    {
        float moveHori = Input.GetAxisRaw("Horizontal");

        isGrounded = Physics2D.Raycast(transform.position, -Vector2.up, 1f, 1 << 8);
        Debug.DrawRay(transform.position, -Vector2.up * 1f, Color.red);
        
        rb2d.velocity = new Vector2(moveHori * runSpeed, rb2d.velocity.y);

        if(moveHori < 0 || moveHori > 0 && runSpeed < 15) {
            runSpeed += 0.25f;
        }
        
        else if(runSpeed >= 15 && moveHori == 0) {
            runSpeed = runSpeed / runSpeed * 0;
        }
        playerAnim.SetFloat("Speed", runSpeed);

        if(Input.GetKeyDown(KeyCode.Space) && isGrounded) {
            rb2d.velocity = new Vector2(moveHori * runSpeed, JumpSpeed);
        }
    }


}
