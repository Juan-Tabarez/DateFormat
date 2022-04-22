using NUnit.Framework;
using DateFormat;

namespace DateFormat.Tests;

public class Tests
{
    //Test Parte 1

    [Test]

    public void Test1()
    {
        string expected = "1977-11-10";
        string actual = FormatDate.ChangeFormat("10/11/1977");
        Assert.AreEqual(expected,actual);
    }

    [Test]
    public void Test2()
    {
        string expected = "2001-11-30";
        string actual = FormatDate.ChangeFormat("30/11/2001");
        Assert.AreEqual(actual,expected);
    }

    //Test Parte 2

    [Test]
    public void Test3()
    {
        string expected = "10-11-1977";
        string actual = FormatDate.ChangeFormat2("10/11/1977");
        Assert.AreEqual(actual, expected);
    }

    [Test]
    public void Test4()
    {
        string expected = "";
        string actual = FormatDate.ChangeFormat2("10/11/97");
        Assert.AreEqual(expected,actual);
    }

    [Test]
    public void Test5()
    {
        string expected = "";
        string actual = FormatDate.ChangeFormat2("");
        Assert.AreEqual(expected,actual);
    }

    [Test]
    public void Test6()
    {
        string expected = "";
        string actual = FormatDate.ChangeFormat2(" ");
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test7()
    {
        string expected = "";
        string actual = FormatDate.ChangeFormat2("1977-11-10");
        Assert.AreEqual(expected,actual);
    }

    [Test]
    public void Test8()
    {
        string expected = "";
        string actual = FormatDate.ChangeFormat2("1977/11/10");
        Assert.AreEqual(expected,actual);
    }

    [Test]
    public void Test9()
    {
        string expected = "";
        string actual = FormatDate.ChangeFormat2("gbfsfbdshagjldfsn");
        Assert.AreEqual(expected,actual);
    }
}