 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    public void Continue() {
        Time.timeScale = 1;
    }

    public void Stop() {
        Time.timeScale = 0;
    }
}
