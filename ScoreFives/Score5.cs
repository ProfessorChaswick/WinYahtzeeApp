namespace ScoreFives;

public class Score5
{
    public static int AddFives(int[] dots)
    {
        int fives = 0;
        foreach(int x in dots)
        {
            if (x == 5)
                fives += 5;

        }
        return fives;
    }
}