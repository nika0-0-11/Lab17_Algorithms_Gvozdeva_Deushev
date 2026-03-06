Console.WriteLine("=== Выбор одежды по погоде ===");
Console.Write("Введите текущую температуру (°C): ");
int temp = Convert.ToInt32(Console.ReadLine());

if (temp >= 20)
{
    Console.WriteLine("Наденьте лёгкую одежду");
}
else
{
    Console.WriteLine("Наденьте тёплую одежду");
}

Console.WriteLine("Хорошего дня!");