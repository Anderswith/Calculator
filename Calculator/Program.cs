namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        IntCalculator _intCalculator = new IntCalculator();
        Add(_intCalculator);
        Substract(_intCalculator);
        Multiply(_intCalculator);
        Divide(_intCalculator);
        Modulus(_intCalculator);
        Reset(_intCalculator);
    }

    private static void Add(IntCalculator _intCalculator)
    {
        _intCalculator.Add(20);
        Console.WriteLine(_intCalculator.Result);
    }

    private static void Substract(IntCalculator _intCalculator)
    {
        _intCalculator.Subtract(10);
        Console.WriteLine(_intCalculator.Result);
    }

    private static void Multiply(IntCalculator _intCalculator)
    {
        _intCalculator.Multiply(10);
        Console.WriteLine(_intCalculator.Result);
    }

    private static void Divide(IntCalculator _intCalculator)
    {
        _intCalculator.Divide(2);
        Console.WriteLine(_intCalculator.Result);
    }

    private static void Modulus(IntCalculator _intCalculator)
    {
        _intCalculator.Modulus(2);
        Console.WriteLine(_intCalculator.Result);
    }

    private static void Reset(IntCalculator _intCalculator)
    {
        _intCalculator.Reset();
        Console.WriteLine(_intCalculator.Result);
    }
}