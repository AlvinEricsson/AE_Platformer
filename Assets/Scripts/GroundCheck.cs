using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public bool isGrounded;
    public int touches;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //när man gör en collision så ökar touches variabeln.
        touches++;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        //när man lämnar en collision så minskar touches variabeln.
        touches--;
    }
    //detta scriptet har jag på min lilla collider under min Player som håller koll på touches så jag inte kan hoppa i luften. Utan bara när jag är på marken.
}
