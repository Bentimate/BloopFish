using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatMovement : MonoBehaviour
{
    public Rigidbody2D boat;
    private Vector2 forward = new Vector2(0, 1);
    public float speed;
    public float rotation;
    private bool akey;
    private bool dkey;
    
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
            //transform.Rotate(0, 0, rotation);
            boat.AddTorque(rotation);
            boat.AddRelativeForce(forward * speed);
        }

        if (Input.GetKeyDown(KeyCode.D)) {
            //transform.Rotate(0, 0, -rotation);
            boat.AddTorque(-rotation);
            boat.AddRelativeForce(forward * speed);
        }
    }
}
