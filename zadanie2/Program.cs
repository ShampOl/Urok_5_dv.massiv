using System;

class Program
{
    static void Main()
    {
        // Создаем двумерный массив
        int[,] array = {
            {10, 20, 30},
            {40, 50, 60},
            {70, 80, 90}
        };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Меняем местами первую и последнюю строки
        SwapRows(array, 0, array.GetLength(0) - 1);

        Console.WriteLine("\nМассив после замены:");
        PrintArray(array);
    }

    static void SwapRows(int[,] array, int row1, int row2)
    {
        int colCount = array.GetLength(1);

        for (int col = 0; col < colCount; col++)
        {
            int temp = array[row1, col];
            array[row1, col] = array[row2, col];
            array[row2, col] = temp;
        }
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
