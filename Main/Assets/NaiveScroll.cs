using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaiveScroll : MonoBehaviour
{
    public Rigidbody2D rb;
    private float height;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
