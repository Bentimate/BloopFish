using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager
{
    private string filename = "Highscores.txt";
    private int maxCount = 10;
    private List<Highscore> hsList = new List<Highscore>();

    private void Save()
    {
        FileHandler.SaveToJSON<Highscore>(hsList, filename);
    }

    private void Load()
    {
        hsList = FileHandler.ReadListFromJSON<Highscore>(filename);
    }

    public void Add(Highscore hs) 
    {
        //best score at position 0
        for (int i = 0; i < maxCount; i++) {
            if (i >= hsList.Count || hs.time > hsList[i].time) { //sus
                hsList.Insert(i, hs);
            }
        }

        //keeping total entries at 10
        if (hsList.Count > maxCount) {
            hsList.RemoveAt(hsList.Count - 1);
        }

        Save();
    }
    
}
