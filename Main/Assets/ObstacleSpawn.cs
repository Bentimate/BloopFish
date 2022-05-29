using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    public GameObject obstacle;
    
    public void spawn() 
    {
        GameObject obs = Instantiate(obstacle) as GameObject;
        obs.transform.position = new Vector2(Random.Range(-5, 5), Random.Range(-2, 2));
    }
}
