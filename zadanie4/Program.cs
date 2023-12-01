using System;

class Program
{
    static void Main()
    {
        // Создаем двумерный массив
        int[,] array = {
            {8, 6, 22},
            {7, 38, 9},
            {15, 84, 2}
        };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Находим индексы наименьшего элемента
        FindMinElementIndices(array, out int minRowIndex, out int minColIndex);

        // Удаляем строку и столбец с наименьшим элементом
        int[,] newArray = RemoveRowAndColumn(array, minRowIndex, minColIndex);

        Console.WriteLine("\nМассив после удаления строки и столбца:");
        PrintArray(newArray);
    }

    static void FindMinElementIndices(int[,] array, out int minRowIndex, out int minColIndex)
    {
        int rowCount = array.GetLength(0);
        int colCount = array.GetLength(1);

        int minElement = int.MaxValue;
        minRowIndex = -1;
        minColIndex = -1;

        for (int row = 0; row < rowCount; row++)
        {
            for (int col = 0; col < colCount; col++)
            {
                if (array[row, col] < minElement)
                {
                    minElement = array[row, col];
                    minRowIndex = row;
                    minColIndex = col;
                }
            }
        }
    }

    static int[,] RemoveRowAndColumn(int[,] array, int rowToRemove, int colToRemove)
    {
        int rowCount = array.GetLength(0);
        int colCount = array.GetLength(1);

        int[,] newArray = new int[rowCount - 1, colCount - 1];

        for (int row = 0, newRow = 0; row < rowCount; row++)
        {
            if (row == rowToRemove)
                continue;

            for (int col = 0, newCol = 0; col < colCount; col++)
            {
                if (col == colToRemove)
                    continue;

                newArray[newRow, newCol] = array[row, col];
                newCol++;
            }

            newRow++;
        }

        return newArray;
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
