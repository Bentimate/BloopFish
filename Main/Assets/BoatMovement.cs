using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatMovement : MonoBehaviour
{
    
    public Rigidbody2D boat;
    private float rowVelocityIncrement = 5;
    private Vector2 normal = new Vector2(0, 1);
    // private Vector2 leftVector = new Vector2(5, 1);
    // private Vector2 rightVector = new Vector2(-5, 1);
    
    // Start is called before the first frame update
    void Start()
    {
        boat = GetComponent<Rigidbody2D>();
        boat.velocity = new Vector2(0, 0);
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) {
            boat.AddTorque(rowVelocityIncrement);
        }

        if (Input.GetKeyDown(KeyCode.D)) {
            boat.AddTorque(-rowVelocityIncrement);
        }
    }
}
