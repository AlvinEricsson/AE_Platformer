using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//I detta skripet använder jag samma princip som i EnemyHorizontalMovement, fast jag byter moveSpeed i y-led så att den rör sig i Vertical.
public class EnemyVerticalMovement : MonoBehaviour
{
    public float moveSpeed = 4;
    public bool isUp = true;

    private Rigidbody2D rbody;

    private void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        Move(false);
    }

    void Move(bool flip)
    {
        if (flip == true)
        {
            isUp = !isUp;
        }
        
        if (isUp == true)
        {
            rbody.velocity = new Vector2(rbody.velocity.x, -moveSpeed);
            transform.localScale = new Vector3(1, 1, 1);
        }
        
        else
        {
            rbody.velocity = new Vector2(rbody.velocity.x, moveSpeed);
            transform.localScale = new Vector3(1, -1, 1);
        }
    }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "InvisibleWall")
            {
                Move(true);
            }

        }
    
}

