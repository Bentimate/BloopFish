using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public BoxCollider2D box;
    public Rigidbody2D rb;
    private float width;
    private float scrollSpeed = -2;
    // Start is called before the first frame update
    void Start()
    {
        box = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();
        width = box.size.x; //get width
        box.enabled = false; //idk what this does
        rb.velocity = new Vector2(scrollSpeed, 0); //set scroll speed
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -width) {
            Vector2 resetPosition = new Vector2(width * 2, 0);
            transform.position = (Vector2) transform.position + resetPosition; //how can you do this??
        }
    }
}
