using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScoreManager : MonoBehaviour
{
    public int level;
    public string filename;
    void Start()
    {
        SaveManager.Load(level, filename);
    }
}
