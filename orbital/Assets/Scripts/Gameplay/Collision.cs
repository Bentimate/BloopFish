using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    public GameObject loseUI;
    // public GameObject WinUI;
    // public Timer timer;
   // public GameObject explosion;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Obstacle") {
            Debug.Log("collide");
            Time.timeScale = 0;
            loseUI.SetActive(true);
        } 
        // else if (other.tag == "Finish") {
        //     timer.StopTime();
        //     Time.timeScale = 0;
        //     WinUI.SetActive(true);
        // }
    }
}
