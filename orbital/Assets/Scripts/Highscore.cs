using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour
{
    public Text highScore;
    Timer timer;
    [SerializeField] GameObject player;

    private void Awake()
    {
        timer = player.GetComponent<Timer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        float number = timer.finalTime;
        if (number > PlayerPrefs.GetFloat("HighScore", 0))
        {
            PlayerPrefs.SetFloat("HighScore", number); // set final time to highscore
            highScore.text = number.ToString();
        }
    }
}
