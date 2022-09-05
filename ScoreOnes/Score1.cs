namespace ScoreOnes;

public class Score1
{
    public static int AddOnes(int[] dots)
        { 
            int ones = 0;
            foreach(int x in dots)
            {
                if(x == 1)
                    ones++;
            }
            return ones; 
        }
}