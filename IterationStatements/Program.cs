using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Exercise 2   
            var numbers = new List<int>();
            int num = 0;


            do
            {
                num++;
                numbers.Add(num);

            } while (num < 100);


            while (num < 200)
            {
                num++;
                numbers.Add(num);
            }


            Console.WriteLine("Increase:");


            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }


            Console.WriteLine("");

            Console.WriteLine("Decrease:");

            {
                for (int i = 199; i <= (numbers.Count) && i >= 0; i--)
                    Console.WriteLine(i);
            }


        }


        //Exercise 3

        //Write a method that will print
        //to the console all numbers 1000 through - 1000


        public static void LukeWarmSection1()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print
        //to the console numbers 3 through 999 by 3 each time

        public static void LukeWarmSection2()
        {
            for (int i =3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameters
        //and check whether they are equal or not

        public static void LukeWarmSection3()
        {
            //I did the random numbers for fun, I hope that's ok...

            Random rnd = new Random();
            int num = rnd.Next(1, 10);
            int num2 = rnd.Next(1, 10);

            var equalOrNot = (num == num2) ? $"{num} and {num2} are equal!" : $"{num} and {num2} are not equal!";

            Console.WriteLine(equalOrNot);
        }

        //Write a method to check whether a given number is even or odd

        public static void LukeWarmSection4()
        {
            Console.WriteLine("Give me a number...");
            int num = Convert.ToInt32(Console.ReadLine());

            var evenOrOdd = (num % 2 == 0) ? "That number is even!" : "That number is odd!";

            Console.WriteLine(evenOrOdd);
        }

        //Write a method to check whether a given number is positive or negative

        public static void LukeWarmSection5()
        {
            Console.WriteLine("Give me a number, positive or negative!");
            int num = Convert.ToInt32(Console.ReadLine());

            var positiveOrNegative = (num >= 0) ? "That number is positive!" : "That number is negative!";
            
            Console.WriteLine(positiveOrNegative);   
        }

        //Write a method to read the age of a candidate and determine whether they can vote.

        public static void LukeWarmSection6()
        {
            Console.WriteLine("Let's find out if you're old enough to vote!" + 
                " How old are you?");
            int userAge = Convert.ToInt32(Console.ReadLine());

            var voterResponse = (userAge >= 18) ? "Great! Go do your civic duty!" : "Sorry, it won't be too much longer!";

            Console.WriteLine(voterResponse);
        }

        //Heatin' Up Section

        //Write a method to check if an integer (from the user) is in the range -10 to 10

        public static void HeatinUp1()
        {
            Console.WriteLine("Give me a number between 10 and -10.");
            int num = Convert.ToInt32(Console.ReadLine());

            var numRange = (num >= -10 && num <= 10) ? "Thank you for following instructions!" : "Can you not read???";

            Console.WriteLine(numRange);
        }

        //Write a method to display the multiplication table (from 1 to 12) of a given integer

        public static void HeatinUp2()
        {
            Console.WriteLine("Let's practice our multiplication tables. Give me a number!");
            int num = Convert.ToInt32(Console.ReadLine());

            var timesTableList = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            foreach(var number in timesTableList)
            {
                var answer = (num * number);
                Console.WriteLine($"{answer}");
            }
        }


    }


}
