using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //jag använder TextMeshProUGUI så att jag kan ha bättre text än Unity default text.
//using UnityEngine.UI

public class ScoreTracker : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int totalScore;

    private void Update()
    {
        //En text som visar hur mycket Score jag har. JAg har detta scripet på min Canvas så att det syns på skärmen när man spelar.
        scoreText.text = string.Format("Score: {0}", totalScore);
       
    }

}
