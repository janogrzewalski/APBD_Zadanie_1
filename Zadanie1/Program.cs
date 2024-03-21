public class Task1
{
    
    public static void Main()
    {
        Console.WriteLine("APBD Zadanie 1");
        List<int> numbers = [1, 2, 4];
        foreach (var number in numbers)
        {
            number = +number;
            number = number/numbers.length();
        }

        Console.WriteLine({number});
    }
}

using System;

public class ArrayProcessor
{
    public static void FindMaxValue(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            Console.WriteLine("Tablica jest pusta lub null.");
            return;
        }

        int maxValue = numbers[0];

        foreach (int number in numbers)
        {
            if (number > maxValue)
            {
                maxValue = number;
            }
        }

        Console.WriteLine($"Największa liczba to: {maxValue}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 3, 5, 7, 9 };
        ArrayProcessor.FindMaxValue(array);
    }
}