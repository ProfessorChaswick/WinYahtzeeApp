using System.Security.Cryptography.X509Certificates;

namespace ScoreTwos;

public class Score2
{
    public static int AddTwos(int[] dots)
    {
        int twos = 0;
        foreach (int x in dots)
        {
            if(x == 2)
                twos  += 2;
        }
        return twos;
    }
}