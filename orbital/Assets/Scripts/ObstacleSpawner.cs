using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour {

    public float movementSpeed;

    private float[] _fixedPositionX = new float[] { -8.0f, 0.0f, 8.0f };

    void OnEnable() {
        int randomPositionX = Random.Range(0, 3);
        transform.position = new Vector3(_fixedPositionX[randomPositionX], 6.0f, 0);
    }

    void Update() {
        transform.position += Vector3.down * movementSpeed * Time.deltaTime;
        if(transform.position.y < -5.25) {
            gameObject.SetActive(false);
        }
    }

}