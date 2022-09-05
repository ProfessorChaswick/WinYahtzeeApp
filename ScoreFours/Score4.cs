namespace ScoreFours;

public class Score4
{
    public static int AddFours(int[] dots)
    {
        int fours = 0;
        foreach(int x in dots)
        {
            if (x == 4)
                fours += 4;
        }
        return fours;
    }
}