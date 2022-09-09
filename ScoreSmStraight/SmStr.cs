namespace ScoreSmStraight;

public class SmStr
{
    public static int Small(int[] dots)
    {
        int small = 0;
        // Count the number of each dice value
        int ones = 0;
        int twos = 0;
        int threes = 0;
        int fours = 0;
        int fives = 0;
        int sixes = 0;

        foreach (int dot in dots)
        {
            if (dot == 1)
                ones++;
            if (dot == 2)
                twos++;
            if (dot == 3)
                threes++;
            if (dot == 4)
                fours++;
            if (dot == 5)
                fives++;
            if (dot == 6)
                sixes++;
        }

        if (ones > 0 && twos > 0 && threes > 0 && fours > 0) small = 30;
        if (twos > 0 && threes > 0 && fours > 0 && fives > 0) small = 30;
        if (threes > 0 && fours > 0 && fives > 0 && sixes > 0) small = 30;

        return small;
    }
}