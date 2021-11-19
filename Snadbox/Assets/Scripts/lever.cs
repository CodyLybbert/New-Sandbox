using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lever : MonoBehaviour
{
    HingeJoint hinge;
    [SerializeField]
    AudioSource pull;

    void Start()
    {
        hinge = GetComponent<HingeJoint>();
    }

    void Update()
    {
        //resets the score to zero and plays sound
        if (hinge.angle == hinge.limits.min)
        {
            pull.Play();
            ScoreCount.score = 0;
        }
    }
}
