﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
    [Range(0, 20f)] //variablar som kan ha ett värde mellan 0 till 20. man får alltså en slide setting i unity.
    public float moveSpeed;
    public float jumpHeight;
    public float superJump = 35;
    public Animator anim;
    
    
    

    public GroundCheck groundCheck; //referens till GroundCheck
    private Rigidbody2D rbody; //referens till Rigidbody2D. private kan inte ses i unity och kan inte påverkas av andra scripts.

    // Use this for initialization
    void Start()
    {
        //Hittar en component som heter Rigidbody2D. gör så att rbody refererar till Rigidbody2D
        rbody = GetComponent<Rigidbody2D>();
        //Hämtar component Animator.
        anim = GetComponent<Animator>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //velocity är en Vector2. Jag gör en new Vector2. Gör så att horizontal hastigheten är gångrad med movespeed variabeln. Man styr alltså med Horizontal knapparna som redan finns i spelet. A, D, LeftArrow, RightArrow.
        rbody.velocity = new Vector2
        (Input.GetAxisRaw("Horizontal") * moveSpeed,
            rbody.velocity.y);

        // Om man trycket på space och min groundCheck variabel har mer än en touch. 
        //alltså att den rör marken där hitboxen blir påverkad, så ska den röra sig upåt i y led, alltså hoppa.
        if(Input.GetKeyDown(KeyCode.Space) && groundCheck.touches > 0) 
        {
            //gör samma sak här som i horizantal movespeed, fast jag använder min jumpHeight variabel i y led så att den rör sig i y led.
            rbody.velocity = new Vector2(rbody.velocity.x, jumpHeight);
        }
        //När man trycker på X så kommer Animationen "Roll" starta. Notera, denna komponenten gör skillnad på spelet. När man gör roll animationen så kan man rulla över ett block utan att hoppa. Detta är en genomtänkt mechanic som man senare kan ha hinder som kräver att man rullar istället för att hoppa.
        if (Input.GetKeyDown(KeyCode.X))
        {
            anim.SetTrigger("Roll");
            
        }

    }

   




    //När Spelaren kolliderar med detta objektet med taggen SuperJump så kommer den åka upp i y-led med variabeln superJump
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "SuperJump")
        {
            rbody.velocity = new Vector2(rbody.velocity.x, superJump);
        }
    }

    
}
