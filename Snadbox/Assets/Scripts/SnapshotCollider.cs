using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SnapshotCollider : MonoBehaviour
{
    public AudioMixerSnapshot inside;
    public AudioMixerSnapshot outside; 

    bool isInside = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if (!isInside)
            {
                inside.TransitionTo(0.5f);
                isInside = true;
            }
            else if (isInside)
            {
                outside.TransitionTo(0.5f);
                isInside = false;
            }
        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
