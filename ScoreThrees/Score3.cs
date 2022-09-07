using System.Security.Cryptography.X509Certificates;

namespace ScoreThrees;

public class Score3
{
    public static int AddThrees(int[] dots)
    {
        int threes = 0;
        foreach(int dot in dots)
        {
            if (dot == 3)
                threes += 3;
        }
        return threes;
    }
}