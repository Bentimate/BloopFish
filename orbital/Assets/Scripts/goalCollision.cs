using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goalCollision : MonoBehaviour
{
    Timer timer;
    [SerializeField] GameObject player;

    private void Awake()
    {
        timer = player.GetComponent<Timer>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            Debug.Log("collide");
            //GameObject explode = Instantiate(explosion) as GameObject;
            //explode.transform.position = transform.position;

            // stop timer
            timer.timerActive = false;
            SceneManager.LoadScene("You Win");
        } 
        // Debug.Log("collide1");
        // SceneManager.LoadScene(1);
        // SceneManager.SetActiveScene(SceneManager.GetSceneByName("You Win"));
    }
}
