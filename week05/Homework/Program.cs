using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        MathAssignment ma1 = new MathAssignment("7.3", "8-19", "Martha Sanchez", "Fractions");
        Console.WriteLine(ma1.GetSummary());
        Console.WriteLine(ma1.GetHomeworkList());

        WritingAssignment wa1 = new WritingAssignment("Mary Waters", "History","What Caused WWI");
        Console.WriteLine(wa1.GetSummary());
        Console.WriteLine(wa1.GetWritingInfo());
    }
}