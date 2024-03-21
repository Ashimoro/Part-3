using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIDemo : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public SpriteRenderer spriteRenderer;
    public Color startColor;
    public Color endColor;
    float interpolation;
    public void SliderHasChangedValue(Single value)
    {
        interpolation = value;
    }

    private void Update()
    {
      spriteRenderer.color = Color.Lerp(startColor, endColor, (interpolation / 60));

    }

    public void DropdownHasChangedValue(int value)
    {
        Debug.Log(dropdown.options[value].text);
    }
}
