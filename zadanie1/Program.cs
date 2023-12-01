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

        int row, col;

        Console.Write("Введите номер строки: ");
        if (int.TryParse(Console.ReadLine(), out row))
        {
            Console.Write("Введите номер столбца: ");
            if (int.TryParse(Console.ReadLine(), out col))
            {
                // Получаем значение элемента или выводим сообщение о его отсутствии
                int result = GetElementValue(array, row, col);
                if (result != int.MinValue)
                {
                    Console.WriteLine($"Значение элемента ({row}, {col}): {result}");
                }
                else
                {
                    Console.WriteLine($"Элемента ({row}, {col}) не существует в массиве.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода для столбца. Введите корректное числовое значение.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка ввода для строки. Введите корректное числовое значение.");
        }
    }

    static int GetElementValue(int[,] array, int row, int col)
    {
        int rowCount = array.GetLength(0);
        int colCount = array.GetLength(1);

        // Проверяем, существуют ли указанные позиции в массиве
        if (row >= 0 && row < rowCount && col >= 0 && col < colCount)
        {
            // Возвращаем значение элемента
            return array[row, col];
        }
        else
        {
            // Возвращаем минимальное значение int, чтобы показать отсутствие элемента
            return int.MinValue;
        }
    }
}