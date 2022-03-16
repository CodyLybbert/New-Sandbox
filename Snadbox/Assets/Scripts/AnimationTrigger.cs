using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    public Animator animator;
    public void TransitionAnimation()
    {
        if (!animator.GetBool("toggle"))
        {
            animator.SetBool("toggle", true);
        }
        else
        {
            animator.SetBool("toggle", false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TransitionAnimation();
        }
    }
}
