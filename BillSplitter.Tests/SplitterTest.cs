using Xunit;
using BillSplitter.Lib;
using System;

namespace BillSplitter.Tests;

public class SplitterTest
{
    [Fact]
    public void Test1()
    {
        decimal amount = 100m;
        int numberOfPeople = 2;
        decimal expected = 50m;

        decimal result = Splitter.Split(amount, numberOfPeople);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test2()
    {
        decimal amount = 100m;
        int numberOfPeople = 1;
        decimal expected = 100m;

        decimal result = Splitter.Split(amount, numberOfPeople);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test3()
    {
        decimal amount = 100m;
        int numberOfPeople = 0;

        Assert.Throws<ArgumentException>(() => Splitter.Split(amount, numberOfPeople));
    }
}