using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SaveManager
{
    private static int maxCount = 5;

    public static void Save(int level, string filename)
    {
        FileHandler.SaveToJSON<Highscore>(HighscoreStorage.arr[level - 1], filename);
    }

    public static void Load(int level, string filename)
    {
        HighscoreStorage.arr[level - 1] = FileHandler.ReadListFromJSON<Highscore>(filename);
    }

    public static void Add(int level, Highscore hs, string filename) 
    {
        //best score at position 0
        for (int i = 0; i < maxCount; i++) {
            if (i >= HighscoreStorage.arr[level - 1].Count || hs.time < HighscoreStorage.arr[level - 1][i].time) {
                HighscoreStorage.arr[level - 1].Insert(i, hs);
                break;
            }
        }

        //keeping total entries at 5
        if (HighscoreStorage.arr[level - 1].Count > maxCount) {
            HighscoreStorage.arr[level - 1].RemoveAt(HighscoreStorage.arr[level - 1].Count - 1);
        }

        Save(level, filename);
    }
}
