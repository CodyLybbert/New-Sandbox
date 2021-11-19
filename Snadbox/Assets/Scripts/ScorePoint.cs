using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePoint : MonoBehaviour
{
    [SerializeField]
    AudioSource goodSound;

    void OnTriggerEnter(Collider other)
    {
        goodSound.Play();
        ScoreCount.score += 1;
    }

}
