using System;
using NUnit.Framework;

[TestFixture]
public static class MinNbDivTests
{

    [Test]
    public static void test1()
    {
        Assert.AreEqual(1, MinNbDiv.FindMinNum(1));
        Assert.AreEqual(64, MinNbDiv.FindMinNum(7));
        Assert.AreEqual(24, MinNbDiv.FindMinNum(8));
        Assert.AreEqual(36, MinNbDiv.FindMinNum(9));
        Assert.AreEqual(12, MinNbDiv.FindMinNum(6));
    }
}

