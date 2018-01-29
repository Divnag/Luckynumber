using System;

namespace LuckyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string action;
            int jackPot=300000;
            do
            {
                Console.WriteLine("Welcome to the Lucky number Game.Good Luck!!!");
                Console.WriteLine("You are Playing for the Jackpot Amount $" + jackPot);
                Console.WriteLine("Please Enter the Starting Number");
                int lowRange = int.Parse(Console.ReadLine());
                Console.WriteLine("Please Enter the Ending Number");
                int highRange = int.Parse(Console.ReadLine());
                 Console.WriteLine("Please Enter 6 Numbers you think it would match with the Luck Numbers");
 
   //Taking input from User- number within the desired range
                int[] num = new int[6];
                
                for (int i = 0; i < num.Length; i++)
                {
                    num[i] = int.Parse(Console.ReadLine());
                    while ((num[i] < lowRange) || (num[i] > highRange))
                    {

                        Console.WriteLine("enter the number within the range" + lowRange + " to " + highRange);
                        num[i] = int.Parse(Console.ReadLine());

                    }

                }
                Console.WriteLine();
                Console.WriteLine("your numbbers {0},{1},{2},{3},{4},{5} ", num[0], num[1], num[2], num[3], num[4], num[5]);
                Console.WriteLine();


//Generating the random numbers
                Random rand = new Random();
                int[] generatedNumber = new int[6];
                int temp;
                for (int i = 0; i < generatedNumber.Length; i++)
                {
                    temp = rand.Next(lowRange,highRange);

 //method caller to check repetative random number
                    while(IsDup(temp,generatedNumber))
                     {
                        temp = rand.Next(lowRange,highRange);
                    }
                    generatedNumber[i] = temp;
                }


 //method caller to print random numbers
                PrintTheArray(generatedNumber);

 //checking for the matching number guessed
                    int correct = 0;
                for (int i = 0; i < generatedNumber.Length; i++)


                {

                    if (num[0] == generatedNumber[i])
                    {
                        correct++;
                    }
                    else if (num[1] == generatedNumber[i])
                    {
                        correct++;

                    }

                    else if (num[2] == generatedNumber[i])
                    {
                        correct++;

                    }
                    else if (num[3] == generatedNumber[i])
                    {
                        correct++;

                    }
                    else if (num[4] == generatedNumber[i])
                    {
                        correct++;

                    }

                    else if (num[5] == generatedNumber[i])
                    {
                        correct++;

                    }


                }
                Console.WriteLine("you guessed "+correct+" numbers correctly!");
                Console.WriteLine();
                Console.WriteLine("you won $"+amountOne(correct)+"!");
                Console.WriteLine();
                Console.WriteLine("Do you want to continue type yes or type no");
                 action = Console.ReadLine();



            }
 //checking if user wants to play the game again
            while (action!= "no");
            Console.WriteLine("Thanks for Playing!");


        }

 //Method to Print Random numbers
        private static void PrintTheArray(int[] generatedNumber)
        {
            foreach(var item in generatedNumber)
            {
                Console.WriteLine("Lucky Number: " + item);
            }

        }

   // Method to check duplicate random numbers

        private static bool IsDup(int temp, int[] generatedNumber)
        {
            foreach(var item in generatedNumber)
            {
                if(item==temp)
                {
                    return true;
                }
            }
            return false;
        }
        
  //Method to check the amount won based on number of correct guess
        static double amountOne(double noOfGuess )
        {
            double lotteryAmount = 300000*(noOfGuess/6);
            return lotteryAmount;
        }
    }
}
            