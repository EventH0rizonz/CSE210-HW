using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userImput = 1;
        while (userImput !=0)
        {
            Console.Write("Enter a positive number or type 0 to end: ");
            string userResponse = Console.ReadLine();
            userImput =int.Parse(userResponse);
            if (userImput !=0)
            {
                numbers.Add(userImput);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum of the numbers is: {sum}");
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average of the numbers is: {average}");
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max number is: {max}");
    }
}