using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
    private float speed = 7f;
    private float jmpSpeed = 7f;
    private Rigidbody2D rg;
    private bool isGrounded;
    private float timeCounter = 15f;
    private float timeCounterJ = 15f;
    private Vector3 move;
    private Animator anim;
    protected Joystick joystick;
    protected JoyButtonJump joyButtonJump;
    private bool jump;

    
    // Start is called before the first frame update
    void Start()
    {
        jump = false;
        joystick = FindObjectOfType<Joystick>();
        joyButtonJump = FindObjectOfType<JoyButtonJump>();
        rg = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {

        JumpRG();
        GameSpeed();
        jumpHeight();
   

    }
   
    private void FixedUpdate()
    {
        MoveRG();
    }
   
    void jumpHeight()
    {
        if (Time.time > timeCounterJ && jmpSpeed <= 8.5f)
        {
            jmpSpeed += 0.1f;
            timeCounterJ = Time.time + 15f;
        }
    }
    void GameSpeed()
    {
        if (Time.time > timeCounter)
        {
            speed += 0.5f;
            timeCounter = Time.time + 15f;
        }
    }

    private void MoveRG()
    {
        move= new Vector3(joystick.Horizontal, 0f, 0f);
        if (move!= Vector3.zero )
        {
            anim.SetBool("isWalk", true);
            flip(move);
            transform.position += move * Time.deltaTime * speed;
        }
        else
        {
            anim.SetBool("isWalk", false);

        }
        
    }
    
    private void JumpRG()
    {
        
        if ( !jump &&joyButtonJump.Pressed && isGrounded)
        {
            jump = true;
            isGrounded = false;
            rg.AddForce(new Vector2(0f, jmpSpeed),ForceMode2D.Impulse);
            
            
        }
        if(jump && !joyButtonJump.Pressed)
        {
            jump = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "platform")
        {
            isGrounded = true;
            anim.SetBool("isJump", false);
        }
        
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.transform.tag == "platform")
        {
            isGrounded = true;
            anim.SetBool("isJump", false);
        }
        
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.tag == "platform")
        {
            isGrounded = false;
            anim.SetBool("isJump", true);

        }
    }
    void flip(Vector3 moveFlip)
    {
        if (moveFlip.x > 0)
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }else if (moveFlip.x < 0) {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
    }


}
