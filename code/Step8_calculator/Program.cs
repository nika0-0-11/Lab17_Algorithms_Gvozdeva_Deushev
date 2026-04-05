double Sum(double a, double b)
{
    return a + b;
}

double Sub(double a, double b)
{
    return a - b;
}

double Mul(double a, double b)
{
    return a * b;
}

double Div(double a, double b)
{
    return a / b;
}

Console.Write("Введите первое число: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите второе число: ");
double b = Convert.ToDouble(Console.ReadLine());

double result1 = Sum(a, b); 
double result2 = Sub(a, b);
double result3 = Mul(a, b);
double result4 = Div(a, b);

Console.WriteLine($"Sum: {result1}");
Console.WriteLine($"Sub: {result2}");
Console.WriteLine($"Mul: {result3}");
Console.WriteLine($"Div: {result4}");


// Console.WriteLine($"Сложение:  {Sum(a, b)}");
// Console.WriteLine($"Вычитание: {Sub(a, b)}");
// Console.WriteLine($"Умножение: {Mul(a, b)}");
// Console.WriteLine($"Деление: {Div(a, b)}");