using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;

public class ShootBubblesStudent : MonoBehaviour
{
    private XRGrabInteractable grabInteractable = null;
    [SerializeField]
    GameObject bubblePrefab;
    [SerializeField]
    Transform spawnPoint;
    private int ammoCount = 10;
    [SerializeField]
    private TextMeshProUGUI ammoText;
         

    void Awake()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener(SpawnBubbles);
    }


    private void SpawnBubbles(ActivateEventArgs arg0)
    {
        if (ammoCount > 0)
        {
            Instantiate(bubblePrefab, spawnPoint.transform.position, Quaternion.identity);
            ammoCount--;
            ammoText.text = ammoCount.ToString();
        }
    }
}
