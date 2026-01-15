using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int response = -1;
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (response != 0)
        {

            Console.Write("Enter number: ");
            response = int.Parse(Console.ReadLine());

            if(response != 0) numbers.Add(response);
        }

        Console.WriteLine($"The sum is: {numbers.Sum()}");
        Console.WriteLine($"The average is: {numbers.Average()}");
        Console.WriteLine($"The largest is: {numbers.Max()}");
        Console.WriteLine($"The smallest positive number is: {numbers.Where(x => x > 0).Min()}");

        numbers.Sort();
        foreach(int number in numbers)
        {
            
            Console.WriteLine(number);
        }

    }
}