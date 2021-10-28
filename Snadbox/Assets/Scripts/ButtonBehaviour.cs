using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class ButtonBehaviour : MonoBehaviour
{
    [SerializeField]
    GameObject ballPrefab;
    [SerializeField]
    Transform launchPoint;
    //made a simple system where when the button is hit, it spawns the ball at the location of the launcher
    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(ballPrefab, launchPoint.position, Quaternion.identity);
    }
}
