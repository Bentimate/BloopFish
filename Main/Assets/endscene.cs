using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endscene : MonoBehaviour
{
    public void ButtonClick() 
    {
        SceneManager.LoadScene("Gameplay");
    }
}
