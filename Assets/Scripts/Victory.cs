using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //SceneManagement är inte default i C#. Man skriver att man vill använda den för att kunna använda den.

public class Victory : MonoBehaviour
{
    //public variabel som bestämmer vilken värld den ska loada när man vinner/dör. 
    public string levelToLoad = "SampleScene";
    

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.tag == "Player")
        {
            print("Vitory Royale!");
            SceneManager.LoadScene(levelToLoad);
        }
    }
    private void Update()
    {
        //När man trycker på 1, 2, 3 så laddar man den scenen.
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SceneManager.LoadScene("SampleScene");
          
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SceneManager.LoadScene("IceWorld");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SceneManager.LoadScene("SandWorld");
        }
    }
}
