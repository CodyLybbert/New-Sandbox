using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.InputSystem;
using System;

public class VignetteApplier : MonoBehaviour
{
    [SerializeField]
    public float intensity = 0.75f;
    [SerializeField]
    public float duration = 0.5f;
    [SerializeField]
    private Volume volume;
    Vignette vignette;
    [SerializeField]
    InputActionReference continuousMove;


    private void Awake()
    {
        continuousMove.action.performed += FadeIn;
        continuousMove.action.canceled += FadeOut;

        if (volume.profile.TryGet(out Vignette vignette))
        {
            this.vignette = vignette;
        }
    }

    private void FadeOut(InputAction.CallbackContext obj)
    {
        StartCoroutine(Fade(0, intensity));
    }

    private void FadeIn(InputAction.CallbackContext obj)
    {
        if (obj.ReadValue<Vector2>() != Vector2.zero)
        {
            StartCoroutine(Fade(intensity, 0));
        }
    }
    IEnumerator Fade(float startValue, float endValue)
    {
        float elapsedTime = 0.0f;
        float blend = elapsedTime / duration;
        float intensity = Mathf.Lerp(startValue, endValue, blend);
        ApplyValue(intensity);
        yield return null;
    }
    void ApplyValue(float value)
    {
        vignette.intensity.Override(value);
    }
    
}
