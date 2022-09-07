namespace ScoreFours;

public class Score4
{
    public static int AddFours(int[] dots)
    {
        int fours = 0;
        foreach(int dot in dots)
        {
            if (dot == 4)
                fours += 4;
        }
        return fours;
    }
}