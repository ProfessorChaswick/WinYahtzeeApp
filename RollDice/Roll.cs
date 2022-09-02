namespace RollDice;

public  class Roll
{
    public static int rollEm()
    {
        Random diNumber = new Random();
        //int rollCount = 0;
        int rNumber = diNumber.Next(1, 7);
        return rNumber;
    }
}