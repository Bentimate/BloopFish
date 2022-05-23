using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D smiley;
    public float speedX;
    public float speedY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("z")) {
            speedX -= 1;
        } else if (Input.GetKeyDown("x")) {
            speedX += 1;
        }

        smiley.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speedX, Input.GetAxisRaw("Vertical") * speedY);
    }
}
