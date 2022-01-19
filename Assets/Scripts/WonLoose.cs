using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WonLoose : MonoBehaviour
{
    public Text PlayerName;
    public Text WonLose;
    public Text Score;
    public DataSaver data;

    void Start()
    {
        PlayerName.text = data.PlayerName;
        Score.text = data.score.ToString();
        if (data.Lost)
        {
            WonLose.text = "Verloren";
        }
        else
        {
            WonLose.text = "Gewonnen";
        }
    }

    
}
