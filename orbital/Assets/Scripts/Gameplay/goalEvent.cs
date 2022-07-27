using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goalEvent : MonoBehaviour
{
    public GameObject WinUI;
    public Timer timer;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            Debug.Log("collide");
            timer.StopTime();
            Time.timeScale = 0;
            WinUI.SetActive(true);
        } 
    }
}
