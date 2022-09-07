namespace ScoreFives;

public class Score5
{
    public static int AddFives(int[] dots)
    {
        int fives = 0;
        foreach(int dot in dots)
        {
            if (dot == 5)
                fives += 5;

        }
        return fives;
    }
}