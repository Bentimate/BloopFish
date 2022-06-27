using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SharkScroll : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    private double var;
    // Start is called before the first frame update
    void Start()
    {
        var = 0;
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -speed);
    }

    // Update is called once per frame
    void Update()
    {
        var += 0.005;
        float xVar = (float) Math.Sin(var);
        rb.velocity = new Vector2(10 * xVar, -speed);
    }
}
