Console.Write("Введите ваш вес (кг): ");
double weight = double.Parse(Console.ReadLine());

Console.Write("Введите ваш рост (м): ");
double height = double.Parse(Console.ReadLine());


double res = weight / Math.Pow(height, 2);

if (res < 18.5)
{
    Console.WriteLine("Недостаточный вес");
    Console.WriteLine("Рекомендуется набрать вес");
}
else if (res >= 18.5 && res <= 24.9)
{
    Console.WriteLine("Нормальный вес");
    Console.WriteLine("Отличный вес удерживайте его");
}
else if (res >= 25 && res <= 29.9)
{
    Console.WriteLine("Избыточный вес");
    Console.WriteLine("Рекомендуется увеличить физ. активность");
}
else if (res >= 30)
{
    Console.WriteLine("Ожирение");
    Console.WriteLine("Рекомендуется обратиться к врачу");
}

