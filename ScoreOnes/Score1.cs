namespace ScoreOnes;

public class Score1
{
    public static int AddOnes(int[] dots)
        { 
            int ones = 0;
            foreach(int dot in dots)
            {
                if(dot == 1)
                    ones++;
            }
            return ones; 
        }
}