[System.Serializable]
public class Highscore
{
    public string playerName;
    public float time; //float or string??

    public Highscore (string name, float time)
    {
        this.playerName = name;
        this.time = time;
    }
}
