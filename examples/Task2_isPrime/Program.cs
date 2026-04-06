bool IsPrime(int n)
{
    if (n <= 1)
    {
        return false;
    }
    
    for (int i = 2; i * i <= n; i++)
    {
        if (n % i == 0)
        {
            return false;
        }
    }

    return true;
}

Console.Write("Введите число: ");

if (IsPrime(int.Parse(Console.ReadLine())))
{
    Console.WriteLine("Число простое");
}
else
{
    Console.WriteLine("Число не простое");
}