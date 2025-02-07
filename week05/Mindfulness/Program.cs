using System;

class Program
{
    static void Main(string[] args)
    {
        //could additionally help the user keep track of the 
        //time or frequency they spend in these activities and 
        //give them gentle prompts and reminders.
        //Whenever the application pauses it should show some kind 
        //of animation to the user, 

        Console.Clear();

        //Have a menu system to allow the user to choose an activity.
        Console.WriteLine("Mindfulness Program");
        Console.WriteLine("Choose a number from the following Menu:");
        Console.WriteLine("1- Breathing Activity");
        Console.WriteLine("2- Reflection Activity");
        Console.WriteLine("3- Listing Activity");
        Console.WriteLine("4- Quit");
        int userInput = int.Parse(Console.ReadLine());

        while (userInput != 4)
        {
            //Provide activities: Breathing Activity, 
            if (userInput == 1)
            {
                BreathingActivity ba1 = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                ba1.Run();
            }

            //Reflection Activity,
            if (userInput == 2)
            {
                ReflectionActivity ra1 = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have, and how you can use it in other aspects of your life.");
                ra1.Run();
            }

            //and Listing Activity
            if (userInput == 3)
            {
                ListingActivity la1 = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                la1.Run();
            }

            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("Choose a number from the following Menu:");
            Console.WriteLine("1- Breathing Activity");
            Console.WriteLine("2- Reflection Activity");
            Console.WriteLine("3- Listing Activity");
            Console.WriteLine("4- Quit");
            userInput = int.Parse(Console.ReadLine());

        }Console.WriteLine("Goodbye!");

    }
}