using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public Rigidbody2D goal;
    void Start()
    {
        goal = GetComponent<Rigidbody2D>();
        goal.velocity = new Vector2(0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
