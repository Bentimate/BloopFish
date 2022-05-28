using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public BoxCollider2D box;
    public Rigidbody2D rb;
    private float height;
    private float scrollSpeed = -2;
    // Start is called before the first frame update
    void Start()
    {
        box = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();
        height = box.size.y; //get width
        box.enabled = false; //idk what this does
        rb.velocity = new Vector2(0, scrollSpeed); //set scroll speed
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -height) {
            Vector2 resetPosition = new Vector2(0, height * 2);
            transform.position = (Vector2) transform.position + resetPosition; //how can you do this??
        }
    }
}
