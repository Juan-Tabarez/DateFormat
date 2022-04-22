using NUnit.Framework;
using DateFormat;

namespace DateFormat.Tests;

//Realizar el dotnet test parado en el archivo pricnipal ("DateFormat")
public class Tests
{
    //Tests Parte 1

    [Test]

    public void ChangeFormatTest1()
    {
        string expected = "1977-11-10";
        string actual = FormatDate.ChangeFormat("10/11/1977");
        Assert.AreEqual(expected,actual);
    }

    [Test]
    public void ChangeFormatTest2()
    {
        string expected = "2001-11-30";
        string actual = FormatDate.ChangeFormat("30/11/2001");
        Assert.AreEqual(actual,expected);
    }

    //Tests Parte 2

    [Test]
    public void ChangeFormat2Test1()
    {
        string expected = "10-11-1977";
        string actual = FormatDate.ChangeFormat2("10/11/1977");
        Assert.AreEqual(actual, expected);
    }

    [Test]
    public void ChangeFormat2Test2()
    {
        string expected = "";
        string actual = FormatDate.ChangeFormat2("10/11/97");
        Assert.AreEqual(expected,actual);
    }

    [Test]
    public void ChangeFormat2Test3()
    {
        string expected = "";
        string actual = FormatDate.ChangeFormat2("");
        Assert.AreEqual(expected,actual);
    }

    [Test]
    public void TChangeFormat2Test4()
    {
        string expected = "";
        string actual = FormatDate.ChangeFormat2(" ");
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void ChangeFormat2Test5()
    {
        string expected = "";
        string actual = FormatDate.ChangeFormat2("1977-11-10");
        Assert.AreEqual(expected,actual);
    }

    [Test]
    public void ChangeFormat2Test6()
    {
        string expected = "";
        string actual = FormatDate.ChangeFormat2("1977/11/10");
        Assert.AreEqual(expected,actual);
    }

    [Test]
    public void ChangeFormat2Test7()
    {
        string expected = "";
        string actual = FormatDate.ChangeFormat2("gbfsfbdshagjldfsn");
        Assert.AreEqual(expected,actual);
    }
}