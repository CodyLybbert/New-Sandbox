using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    public Text scoreboardScore;
    public static int score;
    //[SerializeField]
    //GameObject plusBase;
    //[SerializeField]
    //GameObject minusBase;

    //essentially, this script keeps track of the score
    void Update()
    {
        scoreboardScore.text = score.ToString();
    }

}
