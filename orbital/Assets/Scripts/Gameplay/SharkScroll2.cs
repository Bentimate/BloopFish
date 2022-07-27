using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class SharkScroll2 : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    private double var;

    // audio
    public AudioSource sharkSound;

    // Start is called before the first frame update
    void Start()
    {
        var = 0;
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -speed);

        sharkSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        var += (double) Time.deltaTime;
        float xVar = (float) Math.Sin(var * 5);
        rb.velocity = new Vector2(10 * xVar, -speed);
        transform.Rotate(0f, 0f, xVar); //rotation
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("collide");
            SceneManager.LoadScene("Gameplay");
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            sharkSound.Play();
        }
    }
}
