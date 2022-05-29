using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
   // public GameObject explosion;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            Debug.Log("collide");
            //GameObject explode = Instantiate(explosion) as GameObject;
            //explode.transform.position = transform.position;
            SceneManager.LoadScene("Gameplay");
        } 
        // Debug.Log("collide1");
        // SceneManager.LoadScene(1);
        // SceneManager.SetActiveScene(SceneManager.GetSceneByName("You Win"));
    }
}
