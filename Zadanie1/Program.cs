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