using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScoreManager : MonoBehaviour
{
    public SaveManager save = new SaveManager();
    void Start()
    {
        save.Load();
    }
}
