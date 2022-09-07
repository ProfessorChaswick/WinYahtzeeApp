using System.Security.Cryptography.X509Certificates;

namespace ScoreTwos;

public class Score2
{
    public static int AddTwos(int[] dots)
    {
        int twos = 0;
        foreach (int dot in dots)
        {
            if(dot == 2)
                twos  += 2;
        }
        return twos;
    }
}