using Xunit;
using BillSplitter.Lib;
using System;

namespace BillSplitter.Tests;

public class SplitterTest
{
    [Fact]
    public void Test_Using_Valid_Values_Must_Return_Correct_SplitAmount()
    {
        decimal amount = 100m;
        int numberOfPeople = 2;
        decimal expected = 50m;

        decimal result = Splitter.Split(amount, numberOfPeople);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test_Using_One_Person_Must_Return_SameAmount()
    {
        decimal amount = 100m;
        int numberOfPeople = 1;
        decimal expected = 100m;

        decimal result = Splitter.Split(amount, numberOfPeople);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test_Using_Zero_Person_Must_Throw_ArgumentException()
    {
        decimal amount = 100m;
        int numberOfPeople = 0;

        Assert.Throws<ArgumentException>(() => Splitter.Split(amount, numberOfPeople));
    }
}