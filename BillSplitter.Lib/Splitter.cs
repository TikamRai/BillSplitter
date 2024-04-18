using System;

namespace BillSplitter.Lib;

public class Splitter
{
    public static decimal Split(decimal amount, int numberOfPeople)
    {
        if (numberOfPeople <= 0)
        {
            throw new ArgumentException("Number of people must be greater than zero.", nameof(numberOfPeople));

        }

        return Math.Round(amount / numberOfPeople, 2, MidpointRounding.AwayFromZero);
    }
}
