namespace ScoreSixes;

public class Score6
{
    public static int AddSixes(int[] dots)
    {
        int sixes = 0;
        foreach(int x in dots)
        {
            if (x == 6)
                sixes += 6;
        }
        return sixes;
    }
}