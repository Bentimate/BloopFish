using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

// Score is calculated from time (stopwatch) (Score = 124 x time on stopwatch)
public class TimerScore : MonoBehaviour
{
    bool stopwatchActive = false;
    float currentTime;
    public Text currentTimeText;

    // Score
    int score;
    public Text scoreText;
    public float multiplier = 124;

    // Start is called before the first frame update
    void Start()
    {
        // so that currentTime is in seconds
        currentTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (stopwatchActive == true)
        {
            currentTime = currentTime + Time.deltaTime; // account for fps diff
        }
        score = Mathf.RoundToInt(currentTime * multiplier);
        scoreText.text = score.ToString();
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        currentTimeText.text = time.ToString(@"mm\:ss\:fff");
    }

    public void StartStopwatch()
    {
        stopwatchActive = true;
    }

    public void StopStopwatch()
    {
        stopwatchActive = false;
    }
}
