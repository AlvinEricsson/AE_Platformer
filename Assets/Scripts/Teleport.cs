using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    //Gör en variabel där jag kan sätta till en sprite som den ska teleportera till.
    public Transform target;



    //När Player går in i objektet så byter spelaren position till target variabeln.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.transform.position = target.position;
        }

    }
}
