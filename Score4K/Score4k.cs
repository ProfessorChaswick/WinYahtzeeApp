namespace Score4K;

public class Score4k
{
    public static int Add4Kind(int[] dots)
    {
        int fourKind = 0;

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
        if (ones > 3 || twos > 3 || threes > 3 ||
            fours > 3 || fives > 3 || sixes > 3)
        {
            for (int dot = 0; dot < 5; dot++)
                fourKind += dots[dot];
        }
        else
            fourKind = 0;

        return fourKind;
    }
}