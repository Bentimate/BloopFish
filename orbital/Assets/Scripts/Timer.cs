using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

// Score is calculated from time (stopwatch) (Score = 124 x time on stopwatch)
public class Timer : MonoBehaviour
{
    public TMP_Text timerText;
    private bool timerActive = true;
    private float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        this.ResetTime();
    }

    // Update is called once per frame
    void Update()
    {
        if (timerActive) {
            currentTime += Time.deltaTime;
        }

        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        timerText.text = time.ToString(@"mm\:ss\:ff");
    }

    public void StartTime()
    {
        timerActive = true;
    }

    public void StopTime()
    {
        timerActive = false;
    }

    public void ResetTime()
    {
        currentTime = 0;
    }

    public float CheckTime() 
    {
        return currentTime;
    }
}
