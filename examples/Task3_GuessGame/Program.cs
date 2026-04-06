Random rand = new Random();

while(true)
{
    int number = rand.Next(1, 101);
    int count = 0;

    Console.WriteLine("Угадайте число от 1 до 100");

    while (true)
    {
        Console.Write("Введите число: ");

        if (!int.TryParse(Console.ReadLine(), out int num))
        {
            Console.WriteLine("Ошибка: Введите целое число");
            continue;
        }

        if (num < 1 || num > 100)
        {
            Console.WriteLine("Ошибка: Диапазон от 1 до 100");
            continue;
        }
        
        count++;

        if (num == number)
        {
            Console.WriteLine($"Вы угадали! Число: {number}");
            Console.WriteLine($"Попыток: {count}");
            
            break;
        }

        if (num < number)
        {
            Console.WriteLine("Больше");
        }
        else
        {
            Console.WriteLine("Меньше");
        }
    }

    Console.Write("Играть снова(y/n): ");
        if (Console.ReadLine() == "n")
        {
            Console.WriteLine("Программа завершена");
            break;
        }
}