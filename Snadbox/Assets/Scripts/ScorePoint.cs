using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ScorePoint : MonoBehaviour
{

    [SerializeField]
    AudioSource goodSound;

    //increases the score count by one when the trigger is touched
    void OnTriggerEnter(Collider other)
    {
        goodSound.Play();
        ScoreCount.score += 1;
    }

}
