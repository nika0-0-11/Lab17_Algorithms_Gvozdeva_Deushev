// Программа 1
/*
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
*/

// Программа 2

Console.WriteLine("=== Выбор одежды за деньги ===");
Console.Write("Есть деньги (True/False): ");

bool flag = Convert.ToBoolean(Console.ReadLine().ToLower());

if (flag == true)
{
    Console.WriteLine("Купите Martine Rose");
}
else
{
    Console.WriteLine("Работай больше");
}

Console.WriteLine("Хорошего дня!");