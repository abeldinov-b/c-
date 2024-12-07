using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите элементы массива через пробел: ");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');
        int[] array = Array.ConvertAll(inputArray, int.Parse);

        // Задача 1
        int evenSum = 0;
        foreach (int num in array)
        {
            if (num % 2 == 0)
            {
                evenSum += num;
            }
        }

        // Задача 2
        int maxElement = int.MinValue;
        foreach (int num in array)
        {
            if (num > maxElement)
            {
                maxElement = num;
            }
        }

        // Задача 3
        int minElement = int.MaxValue;
        foreach (int num in array)
        {
            if (num < minElement)
            {
                minElement = num;
            }
        }
        int sumMaxMin = maxElement + minElement;

        Console.WriteLine($"Сумма четных элементов массива: {evenSum}");
        Console.WriteLine($"Наибольший элемент в массиве: {maxElement}");
        Console.WriteLine($"Сумма наибольшего и наименьшего элемента массива: {sumMaxMin}");
    }
}
