using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallUpdate : MonoBehaviour
{
    public Slider BallSpeedSlider;
    public Text BallSpeedtext;
    public static float BallSpeed;

    public void Update()
    {
        BallSpeed = BallSpeedSlider.value;
        BallSpeedtext.text = "Speed: " + BallSpeed;
    }
}
