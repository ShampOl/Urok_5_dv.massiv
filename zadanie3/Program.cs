using System;

class Program
{
    static void Main()
    {
        // Создаем прямоугольный двумерный массив
        int[,] array = {
            {10, 20, 30},
            {40, 50, 60},
            {70, 80, 90},
            {100, 110, 120}
        };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Находим строку с наименьшей суммой элементов
        int minSumRowIndex = FindRowWithMinSum(array);

        Console.WriteLine($"\nСтрока с наименьшей суммой элементов: {minSumRowIndex + 1}"); // +1, так как индексы начинаются с 0
    }

    static int FindRowWithMinSum(int[,] array)
    {
        int rowCount = array.GetLength(0);
        int colCount = array.GetLength(1);

        int minSum = int.MaxValue; // Используем максимальное значение int как начальное значение для сравнения

        int minSumRowIndex = -1;

        for (int row = 0; row < rowCount; row++)
        {
            int currentSum = 0;

            for (int col = 0; col < colCount; col++)
            {
                currentSum += array[row, col];
            }

            if (currentSum < minSum)
            {
                minSum = currentSum;
                minSumRowIndex = row;
            }
        }

        return minSumRowIndex;
    }

    static void PrintArray(int[,] array)
    {
        int rowCount = array.GetLength(0);
        int colCount = array.GetLength(1);

        for (int row = 0; row < rowCount; row++)
        {
            for (int col = 0; col < colCount; col++)
            {
                Console.Write(array[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}
