using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    private void Awake()
    {   
        DontDestroyOnLoad(gameObject);
        if (Instance == null) {
            Instance = this;
        } else {
            GameObject.Destroy(gameObject);
        }
    }
}
