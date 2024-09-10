namespace Calculator;

public class IntCalculator : IIntCalculator
{
    public int Result { get; set; }
    
    public void Reset()
    {
        Result = 0;
    }

    public void Add(int x)
    {
        if (Result > 0 && x > 0)
        {
            Result += x;
        }

        if (Result < 0 && x < 0)
        {
            Result -= x;
        }
    }

    public void Subtract(int x)
    {
        if (x < 0)
        {
            Result += x;
        }
        Result -= x;
    }

    public void Multiply(int x)
    {
        if (Result >= 2147483647 && Result <= -2147483647)
        {
            Console.WriteLine("Dit tal er for stort");
        }
        Result *= x;
    }

    public void Divide(int x)
    {
        if (x == 0)
        {
            throw new DivideByZeroException();
        }
        Result /= x;
    }

    public void Modulus(int x)
    {
        Result %= x;
    }
}