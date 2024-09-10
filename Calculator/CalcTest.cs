
namespace Calculator;

using NUnit.Framework;
using System;

[TestFixture]
public class CalcTest
{
    private IntCalculator _calculator;

    [SetUp]
    public void Setup()
    {
        _calculator = new IntCalculator();
    }

    [Test]
    public void ResetToZero()
    {
        _calculator.Result = 100;
        _calculator.Reset();
        Assert.AreEqual(0, _calculator.Result);
    }

    [Test]
    [TestCase(10, 5, 15)]
    [TestCase(-10, -5, -15)]
    [TestCase(0, 10, 0)]  
    public void AddinNumbers(int initialResult, int value, int expected)
    {
        _calculator.Result = initialResult;
        _calculator.Add(value);
        Assert.AreEqual(expected, _calculator.Result);
    }

    [Test]
    [TestCase(10, 5, 5)]
    [TestCase(10, -5, 15)]  
    [TestCase(-10, -5, -5)]
    public void Substracting(int initialResult, int value, int expected)
    {
        _calculator.Result = initialResult;
        _calculator.Subtract(value);
        Assert.AreEqual(expected, _calculator.Result);
    }

    [Test]
    [TestCase(5, 2, 10)]
    [TestCase(10, 0, 0)]  
    [TestCase(3, -2, -6)] 
    public void Multiply(int initialResult, int value, int expected)
    {
        _calculator.Result = initialResult;
        _calculator.Multiply(value);
        Assert.AreEqual(expected, _calculator.Result);
    }

    [Test]
    public void MultiplyExceedsIntValue()
    {
        _calculator.Result = int.MaxValue;
        var ex = Assert.Throws<OverflowException>(() => _calculator.Multiply(2));
        Assert.AreEqual("overflow exception", ex.Message);
    }

    [Test]
    [TestCase(10, 2, 5)]
    [TestCase(9, 3, 3)]
    [TestCase(-6, 3, -2)]
    public void Division(int initialResult, int value, int expected)
    {
        _calculator.Result = initialResult;
        _calculator.Divide(value);
        Assert.AreEqual(expected, _calculator.Result);
    }

    [Test]
    public void DivideShouldThrowDivideByZeroException()
    {
        _calculator.Result = 10;
        Assert.Throws<DivideByZeroException>(() => _calculator.Divide(0));
    }

    [Test]
    [TestCase(10, 3, 1)]
    [TestCase(9, 2, 1)]
    [TestCase(15, 5, 0)]
    public void Modulus(int initialResult, int value, int expected)
    {
        _calculator.Result = initialResult;
        _calculator.Modulus(value);
        Assert.AreEqual(expected, _calculator.Result);
    }
}