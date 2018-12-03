using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMovement : MonoBehaviour
{
    //Denna råttan har Kinematic på rigidbody. Kinematic gör så att den är statisk, fast den kan fortfarande röra sig i riktningar men inte påverkas av fysiska krafter.
    //Static har jag på t.ex. ground. Static gör så att den är statisk och då inte rör på sig.
    public float moveSpeed = 2f;
    public bool isLeft = true;

    private Rigidbody2D rbody;
    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        Move(false);
    }

    // Update is called once per frame
    

    void Move(bool flip)
    {
        if (flip == true)
        {
        isLeft = !isLeft;
        }
        //Om isLeft är true så ska den röra sig till vänster (-moveSpeed)
        if (isLeft == true)
        {
            rbody.velocity = new Vector2(-moveSpeed, rbody.velocity.y);
            transform.localScale = new Vector3(1, 1, 1);
        }
        //Om isLeft är false så ska den röra sig till höger (moveSpeed
        else
        {
            rbody.velocity = new Vector2(moveSpeed, rbody.velocity.y);
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
    //OnTriggerEnter2D betyder när den kolliderar med något i spelet så ska den göra något. Jag sätter så när den kolliderar med något med taggen "InvisibleWall" så ska Move vara true, vilket aktiverar funktionen 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "InvisibleWall")
        {
            Move(true);
        }
    
    }





}
