using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform player;


    private void FixedUpdate() //Gör så att den följer efter spelaren. Jag sätter då på detta skriptet på kameran så att den följer efter spelaren.
    {
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
    }
}
