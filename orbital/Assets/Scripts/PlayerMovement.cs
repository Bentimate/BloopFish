using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private float move;
    private float moveSpeed;
    private float rotation;
    private float rotateSpeed;

    void Start()
    {
        moveSpeed = 5f;
        rotateSpeed = 50f;
    }

    void Update()
    {
        move = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        rotation = Input.GetAxis("Horizontal") * -rotateSpeed * Time.deltaTime;
    }

    private void LateUpdate()
    {
        transform.Translate(0f, -move, 0f);
        transform.Rotate(0f, 0f, rotation);
    }
}
