using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        int number = -1;
        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
            
        } 

        int nSum = numbers.Sum();
        Console.WriteLine($"The sum is: {nSum}");
    //alternate
        //int sum = 0;
        // foreach (int number in numbers)
        // {
        //     sum += number;
        // }




        int listSize = numbers.Count;
        float nAvg = ((float)nSum) / listSize;
        Console.WriteLine($"The average is : {nAvg}");

        int nMax = numbers[0];

        foreach (int n in numbers)
        {
            if (n > nMax)
            {
                nMax = n;
            }
        }
        
        Console.WriteLine($"The largest number is : {nMax}");
    }
}