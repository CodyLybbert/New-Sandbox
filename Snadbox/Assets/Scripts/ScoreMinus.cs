using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreMinus : MonoBehaviour
{
    [SerializeField]
    AudioSource badSound;

    void OnTriggerEnter(Collider other)
    {
        badSound.Play();
        ScoreCount.score -= 1;
    }

}
