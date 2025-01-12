using System;

class Program
{
    static void Main(string[] args)
    {
        
        // Console.Write("What is the magic number? ");
        // string userInput = Console.ReadLine();
        // int magicNumber = int.Parse(userInput); 

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        Console.WriteLine("Can you guess the number between 1 and 100? ");

        

        string keepGoing;


        do  
        {
            Console.Write("What is your guess? ");
            string userInput2 = Console.ReadLine();
            int guess = int.Parse(userInput2);

            if (guess > magicNumber)
            {
                Console.WriteLine("Guess lower. ");
                keepGoing = "yes";
            }

           else if (guess < magicNumber)
            {
              Console.WriteLine("Guess higher. ");
              keepGoing = "yes";
            }

            else
            {
                Console.WriteLine("Congratualations, you guessed it!");
                keepGoing = "no";
            }
        } while (keepGoing == "yes");

    }
}

//alternative
        // Random randomGenerator = new Random();
        //int magicNumber = randomGenerator.Next(1, 101);

        //int guess = -1;

        // We could also use a do-while loop here...
       // while (guess != magicNumber)
        //{
        //     Console.Write("What is your guess? ");
        //     guess = int.Parse(Console.ReadLine());

        //     if (magicNumber > guess)
        //     {
        //         Console.WriteLine("Higher");
        //     }
        //     else if (magicNumber < guess)
        //     {
        //         Console.WriteLine("Lower");
        //     }
        //     else
        //     {
        //         Console.WriteLine("You guessed it!");
        //     }

        // }                    //

