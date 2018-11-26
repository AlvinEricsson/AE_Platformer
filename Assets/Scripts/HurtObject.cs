using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HurtObject : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {

       //Om något kolliderar med taggen Player så laddar man om scenen. Man dör alltså.
        if(collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

}
