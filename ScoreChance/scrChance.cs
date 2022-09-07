namespace ScoreChance;

public class scrChance
{
    public static int AddChance(int[] dots)
    {
        int chance = 0;
        for(int dot = 0; dot <= 4; dot++)
        {
            chance += dots[dot];
        }

        return chance;  
    }
}