using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footsteps : MonoBehaviour
{
    
    public AudioSource stepSound;
    CharacterController man;
    // Start is called before the first frame update
    void Start()
    {
        man = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (man.velocity.magnitude > 2f & stepSound.isPlaying == false)
        {
            stepSound.Play();
        }
    }
}
