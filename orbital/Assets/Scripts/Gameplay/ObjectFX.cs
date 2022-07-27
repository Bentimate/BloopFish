using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectFX : MonoBehaviour
{
    public AudioSource sound;
    // Start is called before the first frame update
    private void Start()
    {
        // audio
        sound = GetComponent<AudioSource>();
    }

   // public GameObject explosion;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            Debug.Log("sound");
            sound.Play();
        } 
    }
}
