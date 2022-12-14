Console.Write("Введите колличество чисел: ");
int countNumbers = int.Parse(Console.ReadLine()!);
int[] array = new int[countNumbers];

void CreateMassive(int[] mass)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите число под индексом {i}: ");
        array[i] = int.Parse(Console.ReadLine()!);
    }
    Console.WriteLine();
    Console.Write("Вы ввели: ");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]} | ");
    }
}

int GetPositiveNumbers(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count ++;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Колличество положительных чисел {count}");
    return count;

}

CreateMassive(array);
Console.WriteLine();
GetPositiveNumbers(array);