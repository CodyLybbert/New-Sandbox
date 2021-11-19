using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lever : MonoBehaviour
{
    HingeJoint hinge;
    [SerializeField]

    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hinge.angle == hinge.limits.min)
        {
            ScoreCount.score = 0;
        }
    }
}
