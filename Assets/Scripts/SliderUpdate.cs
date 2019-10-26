using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderUpdate : MonoBehaviour
{
    public Slider targetRotaionSlider;
    public Text targetRotationSpeed;
    public static float TargetRotationSpeed;

    public void Update()
    {
        TargetRotationSpeed = targetRotaionSlider.value;
        targetRotationSpeed.text = "Rotation: " + TargetRotationSpeed;
    }
}
