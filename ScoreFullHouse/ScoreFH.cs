namespace ScoreFullHouse;

public class ScoreFH
{
    public static int AddFH(int[] dots)
    {
        int Full = 0;
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
        if (ones == 2 && twos == 3) Full = 25;
        if (ones == 2 && threes == 3) Full = 25;
        if (ones == 2 && fours == 3) Full = 25;
        if (ones == 2 && fives == 3) Full = 25;
        if (ones == 2 && sixes == 3) Full = 25;
        if (twos == 2 && ones == 3) Full = 25;
        if (twos == 2 && threes == 3) Full = 25;
        if (twos == 2 && fours == 3) Full = 25;
        if (twos == 2 && fives == 3) Full = 25;
        if (twos == 2 && sixes == 3) Full = 25;
        if (threes == 2 && ones == 3) Full = 25;
        if (threes == 2 && twos == 3) Full= 25;
        if (threes == 2 && fours == 3) Full = 25;
        if (threes == 2 && fives == 3) Full = 25;
        if (threes == 2 && sixes == 3) Full = 25;  
        if (fours == 2 && ones == 3) Full = 25;
        if (fours == 2 && twos == 3) Full = 25;
        if (fours == 2 && threes == 3) Full = 25;
        if (fours == 2 && fives == 3) Full = 25;
        if (fours == 2 && sixes == 3) Full = 25;
        if (fives == 2 && ones == 3) Full = 25;
        if (fives == 2 && twos == 3) Full = 25;
        if (fives == 2 && threes == 3) Full = 25;
        if (fives == 2 && fours == 3) Full = 25;
        if (fives == 2 && sixes == 3) Full = 25;
        if (sixes == 2 && ones == 3) Full = 25;
        if (sixes == 2 && twos == 3) Full = 25;
        if (sixes == 2 && threes == 3) Full = 25;
        if (sixes == 2 && fours == 3) Full = 25;
        if (sixes == 2 && fives == 3) Full = 25;

        return Full;
    }
}