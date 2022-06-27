using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    //public GameObject obstacle;
    public BoxCollider2D box;
    public Rigidbody2D rb;
    private float height;
    private float scrollSpeed = -2;
    // Start is called before the first frame update
    void Start()
    {
        box = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();
        height = box.size.y; //get height
        box.enabled = false;
        rb.velocity = new Vector2(0, scrollSpeed); //set scroll speed
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -height) {
            Vector2 resetPosition = new Vector2(0, height * 2);
            transform.position = (Vector2) transform.position + resetPosition;
            //spawn();
        }
    }

    // private void spawn() 
    // {
    //     GameObject obs = Instantiate(obstacle) as GameObject;
    //     Rigidbody2D obsMovement = obs.GetComponent<Rigidbody2D>();
    //     obs.transform.position = new Vector2(Random.Range(-5, 5), Random.Range(-2, 2));
    //     obsMovement.velocity = new Vector2(0, scrollSpeed);
    // }
}
