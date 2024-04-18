using System;
using System.Collections.Generic;

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

    public static Dictionary<string, decimal> CalcTips(Dictionary<string, decimal> mealCost, float tipPercent)
    {
        if (tipPercent < 0)
        {
            throw new ArgumentException("Tip percentage cannot be negative.", nameof(tipPercent)); 
        }

        var tips = new Dictionary<string, decimal>();
        foreach (var entry in mealCost)
        {
            decimal tipAmount = Math.Round(entry.Value * ((decimal)tipPercent / 100), 2);
            tips.Add(entry.Key, tipAmount);
        }

        return tips;
    }

    public static decimal CalcTipPerPerson(decimal price, int numberOfPatrons, float tipPercent)
    {
        if (numberOfPatrons <= 0)
        {
            throw new ArgumentException("number of patrons must be greaterh than zero.", nameof(numberOfPatrons));
        }

        if (tipPercent < 0)
        {
            throw new ArgumentException("Tip percentage cannot be negative.", nameof(tipPercent)); 
        }

        decimal totalTip = price * (decimal)(tipPercent / 100);
        decimal tipPerPerson = totalTip / numberOfPatrons;

        return Math.Round(tipPerPerson, 2);
    }
}
