Console.WriteLine("=== Поиск максимального элемента ===");

int[] array = {1, 51, 34, 812, 21};

int max = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    } 
}
Console.WriteLine($"Максимальный элемент: {max}");