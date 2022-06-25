using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Score is calculated from time (stopwatch) (Score = 124 x time on stopwatch)
public class Timer : MonoBehaviour
{
    public bool timerActive;

    public float timeStart;
    public Text textBox;
    public float finalTime;

    /* Score
    int score;
    public Text scoreText;
    public float multiplier = 124; */

    // Start is called before the first frame update
    void Start()
    {
        timerActive = true;
        // so that currentTime is in seconds
        textBox.text = timeStart.ToString("F2");
    }

    // Update is called once per frame
    void Update()
    {
        if(timerActive)
        {
            timeStart += Time.deltaTime; // account for fps diff
            textBox.text = timeStart.ToString("F2");
        }
        else
        {
            finalTime = timeStart;
        }

    }

    /* public void StartStopwatch()
    {
        stopwatchActive = true;
    }

    public void StopStopwatch()
    {
        stopwatchActive = false;
    } */
}
