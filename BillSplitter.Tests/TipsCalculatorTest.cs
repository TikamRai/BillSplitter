using Xunit;
using BillSplitter.Lib;
using System;
using System.Collections.Generic;

namespace BillSplitter.Tests;

public class TipsCalculatorTest
{
    [Fact]
    public void Test1()
    {
        var mealCost = new Dictionary<string, decimal>
        {
            {"Nguyen", 120m},
            {"Lee", 100m}
        };
        float tipPercent = 10f;
        var expected = new Dictionary<string, decimal>
        {
            {"Nguyen", 12m},
            {"Lee", 10m}
        };

        var tips = Splitter.CalcTips(mealCost, tipPercent);

        Assert.Equal(expected, tips);
    }

    [Fact]
    public void Test2()
    {
        var mealCost = new Dictionary<string, decimal>
        {
            {"Nguyen", 120m},
            {"Lee", 100m}
        };
        float tipPercent = 0f;
        var expected = new Dictionary<string, decimal>
        {
            {"Nguyen", 0m},
            {"Lee", 0m}
        };

        var tips = Splitter.CalcTips(mealCost, tipPercent);

        Assert.Equal(expected, tips);
    }

    [Fact]
    public void Test3()
    {
        var mealCost = new Dictionary<string, decimal>
        {
            {"Nguyen", 120m},
            {"Lee", 100m}
        };
        float tipPercent = -10f;

        Assert.Throws<ArgumentException>(() => Splitter.CalcTips(mealCost, tipPercent));
    }
}