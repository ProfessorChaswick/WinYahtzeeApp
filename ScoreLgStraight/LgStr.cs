namespace ScoreLgStraight;

public class LgStr
{
    public static int Large(int[] dots)
    {
        int large = 0;
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

        if (ones == 1 && twos == 1 && threes == 1 && fours == 1 && fives == 1) large = 40;
        if (twos == 1 && threes == 1 && fours == 1 && fives == 1 && sixes == 1) large = 40;

        return large;
    }
}