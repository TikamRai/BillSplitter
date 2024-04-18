using Xunit;
using BillSplitter.Lib;
using System;

namespace BillSplitter.Tests;

public class TipPerPersonTest
{
    [Fact]
    public void Test_Using_Valid_Values_Must_Return_Correct_Tip_Amount()
    {
        decimal price = 150m;
        int numberOfPatrons = 5;
        float tipPercent = 10f;
        decimal expected = 3m;

        decimal result = Splitter.CalcTipPerPerson(price, numberOfPatrons, tipPercent);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test_Using_Zero_TipPercent_Must_Return_Zero_For_TipAmount()
    {
        decimal price = 150m;
        int numberOfPatrons = 5;
        float tipPercent = 0f;
        decimal expected = 0m;

        decimal result = Splitter.CalcTipPerPerson(price, numberOfPatrons, tipPercent);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test_Using_Zero_NumberOfPatrons_Must_Throw_ArgumentException()
    {
        decimal price = 150m;
        int numberOfPatrons = 0;
        float tipPercent = 10f;

        Assert.Throws<ArgumentException>(() => Splitter.CalcTipPerPerson(price,numberOfPatrons, tipPercent));
    }
}