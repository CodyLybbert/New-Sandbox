using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeChange : MonoBehaviour
{
    [SerializeField]
    AudioSource audioSource;
    private Slider slider;

    void Start()
    {
        slider = GetComponent<Slider>();
    }

    public void VolManager()
    {
        audioSource.volume = slider.value;
    }

}
