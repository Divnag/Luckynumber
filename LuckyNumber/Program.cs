using System;

namespace LuckyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string action;
            int jackPot=200000;
            do
            {
                Console.WriteLine("Welcome to the Lottery game.Good Luck!!!");
                Console.WriteLine("Please Enter the Starting Number");
                int lowRange = int.Parse(Console.ReadLine());
                Console.WriteLine("Please Enter the Ending Number");
                int highRange = int.Parse(Console.ReadLine());
                Console.WriteLine("Please Enter 6 Numbers you think it would match with the Luck Numbers");
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
                Console.WriteLine("your numbbers {0},{1},{2},{3},{4},{5} ", num[0], num[1], num[2], num[3], num[4], num[5]);


                Random r = new Random();
                int[] rArray = new int[6];
                Console.WriteLine("your Lucky Numbers");
                for (int i = 0; i < rArray.Length; i++)
                {
                    rArray[i] = r.Next(lowRange, highRange); ;

                    Console.WriteLine("Lucky Number: " + rArray[i]);

                }
                int correct = 0;
                for (int i = 0; i < rArray.Length; i++)

                {

                    if (num[0] == rArray[i])
                    {
                        correct++;
                    }
                    else if (num[1] == rArray[i])
                    {
                        correct++;

                    }

                    else if (num[2] == rArray[i])
                    {
                        correct++;

                    }
                    else if (num[3] == rArray[i])
                    {
                        correct++;

                    }
                    else if (num[4] == rArray[i])
                    {
                        correct++;

                    }

                    else if (num[5] == rArray[i])
                    {
                        correct++;

                    }


                }
                Console.WriteLine("you guessed "+correct+" numbers correctly!");
                Console.WriteLine("you won amount of $ "+amountOne(correct));
                Console.WriteLine("Jackpot Amount $"+ jackPot);
                Console.WriteLine("Do you want to continue type yes or type no");
                 action = Console.ReadLine();



            } while(action!= "no");
            Console.WriteLine("Thanks for Playing!");


        }


        static double amountOne(double noOfGuess )
        {
            double lotteryAmount = 200000*(noOfGuess/6);
            return lotteryAmount;
        }
    }
}
            