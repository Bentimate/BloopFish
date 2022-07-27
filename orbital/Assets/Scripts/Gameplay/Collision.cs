using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    public AudioSource sound;

    private void Start()
    {
        // audio
        sound = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("play sound");
            // play crash audio
            sound.Play();
        }
    }

    // public GameObject explosion;
    // when collide, repeat that stage
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            Debug.Log("collide");
            SceneManager.LoadScene("Gameplay");
        } 
    }
}
