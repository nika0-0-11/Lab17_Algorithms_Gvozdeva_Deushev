Console.WriteLine("=== Подъём по лестнице ===");

Console.Write("На какой этаж нужно подняться?: ");
int targerFloor = Convert.ToInt32(Console.ReadLine());

int currentFloor = 1;
Console.WriteLine("Начинаем подъём!");

while (currentFloor < targerFloor)
{
    currentFloor++;
    Console.WriteLine($"Поднялись на {currentFloor}-й этаж");
}

Console.WriteLine($"Вы достигли {targerFloor}-го этажа!");
Console.WriteLine("Конец программы");