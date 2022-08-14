using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager
{
    private string filename = "Highscores.txt";
    private int maxCount = 5;

    public void Save()
    {
        FileHandler.SaveToJSON<Highscore>(HighscoreStorage.hsList, filename);
    }

    public void Load()
    {
        HighscoreStorage.hsList = FileHandler.ReadListFromJSON<Highscore>(filename);
    }

    public void Add(Highscore hs) 
    {
        //best score at position 0
        for (int i = 0; i < maxCount; i++) {
            if (i >= HighscoreStorage.hsList.Count || hs.time < HighscoreStorage.getTime(i)) {
                HighscoreStorage.hsList.Insert(i, hs);
                break;
            }
        }

        //keeping total entries at 10
        if (HighscoreStorage.hsList.Count > maxCount) {
            HighscoreStorage.hsList.RemoveAt(HighscoreStorage.hsList.Count - 1);
        }

        Save();
    }
}
