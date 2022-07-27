using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIpopupManager : MonoBehaviour
{
    public GameObject UIPanel;

    public void Appear() {
        UIPanel.SetActive(true);
    }

    public void Disappear() {
        UIPanel.SetActive(false);
    }
}
