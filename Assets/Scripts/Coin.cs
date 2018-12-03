using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int score = 1;
    //När den kolliderar med taggen "Player" så ska det hända.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            //Skapa en temporär variabel och sätt den till resultatet av sökningen efter objektet med taggen "GameController".
            GameObject controller = GameObject.FindWithTag("GameController");
            if (controller != null)
            {

                //Skapa en temporär variabel "tracker" och sätt den till resultatet av sökningen efter komponenten "ScoreTracker".
                ScoreTracker tracker = controller.GetComponent<ScoreTracker>();
                if (tracker != null)
                {
                    tracker.totalScore += score; //Ökar totala scoret med 1.
                }
                else
                {
                    Debug.LogError("ScoreTracker saknas på GameController");
                }
            }
            else
            {
                Debug.LogError("GameController finns inte.");
            }
            Destroy(gameObject); //Förstör objektet så att coinen inte finns kvar när man har tagit upp den.
        }
    }

}
