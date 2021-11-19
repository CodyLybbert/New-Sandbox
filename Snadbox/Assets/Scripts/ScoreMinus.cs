using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class ScoreMinus : MonoBehaviour
{
    [SerializeField]
    AudioSource badSound;

    //decreases the score count by one when the trigger is touched
    void OnTriggerEnter(Collider other)
    {
        badSound.Play();
        ScoreCount.score -= 1;
    }

}
