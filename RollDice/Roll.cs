﻿namespace RollDice;

public  class Roll
{
    public static int rollEm()
    {
        Random diNumber = new Random();
        int rNumber = diNumber.Next(1, 7);
        return rNumber;
    }
}