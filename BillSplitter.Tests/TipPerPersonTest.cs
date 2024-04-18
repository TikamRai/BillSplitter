using Xunit;
using BillSplitter.Lib;
using System;

namespace BillSplitter.Tests;

public class TipPerPersonTest
{
    [Fact]
    public void Test1()
    {
        decimal price = 150m;
        int numberOfPatrons = 5;
        float tipPercent = 10f;
        decimal expected = 3m;

        decimal result = Splitter.CalcTipPerPerson(price, numberOfPatrons, tipPercent);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test2()
    {
        decimal price = 150m;
        int numberOfPatrons = 5;
        float tipPercent = 0f;
        decimal expected = 0m;

        decimal result = Splitter.CalcTipPerPerson(price, numberOfPatrons, tipPercent);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test3()
    {
        decimal price = 150m;
        int numberOfPatrons = 0;
        float tipPercent = 10f;

        Assert.Throws<ArgumentException>(() => Splitter.CalcTipPerPerson(price,numberOfPatrons, tipPercent));
    }
}