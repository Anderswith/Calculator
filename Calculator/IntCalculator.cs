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
            Result += x;
        }
    }

    public void Subtract(int x)
    {
            Result -= x;
    }

    public void Multiply(int x)
    {
        if (x > 0)
        {
            if (Result > int.MaxValue / x)
            {
                throw new OverflowException("overflow exception");
            }
        }
        else if (x < 0)
        {
            if (Result < int.MinValue / x)
            {
                throw new OverflowException("overflow exception");
            }
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