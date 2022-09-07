namespace Score3ofaKind;

public class Score3k
{
    public static int Add3K(int[] dots)
    {
        int threeKind = 0;
        int ones = 0;
        int twos = 0;
        int threes = 0;
        int fours = 0;
        int fives = 0;
        int sixes = 0;

        foreach(int dot in dots)
        {
            if(dot == 1)
                ones++;
            if(dot == 2)
                twos++;
            if(dot ==3)
                threes++;
            if(dot == 4)
                fours++;
            if(dot == 5)
                fives++;
            if(dot == 6)
                sixes++;

            //threeKind += dots[dot - 1];
        }
        if(ones > 2 || twos > 2 || threes > 2 ||
            fours > 2 || fives > 2 || sixes > 2)
        {
            for(int dot = 0; dot < 5; dot++)
                threeKind += dots[dot];
        }else
            threeKind = 0;

        return threeKind;
    }
}