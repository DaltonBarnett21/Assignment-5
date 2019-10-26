using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowRounds : MonoBehaviour
{
    public Text rounds;

    void Awake()
    {
        
        rounds.text = "Rounds: " + PlayerPrefs.GetInt("rounds");

    }
}
