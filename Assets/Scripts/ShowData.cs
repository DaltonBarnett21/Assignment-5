using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowData : MonoBehaviour
{
    public Text PanelNameText;
    public Text PanelLivesText;
    public Text PanelSpeedText;
    public Text PanelScoreText;
    public Text PanelHighScoreText;
    public Text PanelRoundsPlayedText;

    private void Awake()
    {
        
        PanelLivesText.text = Data.PlayerRounds.ToString();
        PanelSpeedText.text = Data.PlayerSpeed.ToString();
        PanelHighScoreText.text = "High: " + Data.HighScore.ToString();
        PanelRoundsPlayedText.text = "Rounds: " + Data.RoundsPlayed.ToString();
    }
    private void Update()
    {
       // PanelScoreText.text = Score.PinCount.ToString();
    }
}