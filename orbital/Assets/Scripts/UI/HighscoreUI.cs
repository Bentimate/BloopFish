using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class HighscoreUI : MonoBehaviour
{
    public int rank;
    private float time;
    public TMP_Text rankTxt;
    public TMP_Text timeText;
    

    public void Start() {
        rankTxt.text = rank.ToString();
        List<Highscore> ls = HighscoreStorage.arr[1];
        time = ls[rank - 1].time;
        TimeSpan display = TimeSpan.FromSeconds(time);
        timeText.text = display.ToString(@"mm\:ss\:ff");   
         
    }
}
