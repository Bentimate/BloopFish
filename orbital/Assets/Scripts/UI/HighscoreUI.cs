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
    public SaveManager save = new SaveManager();
    

    public void Start() {
        save.Load();
        rankTxt.text = rank.ToString();
        time = HighscoreStorage.getTime(rank - 1);
        TimeSpan display = TimeSpan.FromSeconds(time);
        timeText.text = display.ToString(@"mm\:ss\:ff");
    }
}
