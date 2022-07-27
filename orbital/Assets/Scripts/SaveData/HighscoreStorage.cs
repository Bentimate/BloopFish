using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class HighscoreStorage
{
    public static List<Highscore> hsList = new List<Highscore>();
    public static float getTime(int pos) {
        return hsList[pos].time;
    }
    public static string getName(int pos) {
        return hsList[pos].playerName;
    }
}
