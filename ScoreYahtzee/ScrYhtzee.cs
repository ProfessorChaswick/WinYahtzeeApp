namespace ScoreYahtzee
{
    public class ScrYhtzee
    {
        public static int AddYahtzee(int[] dots)
        {
            //int yahtzee = 0;
            if (dots[0] == dots[1] && dots[1] == dots[2] && dots[2] == dots[3] && dots[3] == dots[4])
                return 50;
            else
                return 0;
        }
    }
}