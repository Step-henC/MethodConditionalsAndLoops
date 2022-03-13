using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithLoopsAndConditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThousandCounter();
            SkipThreePrint();
            Console.WriteLine(AskIfEqual(1, 5));
            Console.WriteLine(EvenOrOdd(2));
            Console.WriteLine(VoterAgeCheck(22));
            Console.WriteLine(NegToPosTen(3));
            MultplyTable(4);
          
           

        }
        /*Write a method that will print to the console 
         * all numbers 1000 through -1000.*/
        public static void ThousandCounter()
        {
            for (int i = -1000; i <= 1000; i++)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method that will print to the console 
        //numbers 3 through 999 by 3 each time.
        public static void SkipThreePrint()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method to accept two integers as parameters 
          //and check whether they are equal or not.
        public static bool AskIfEqual(int x, int y)
        {
            var check = (x == y) ? true : false;

            return check;
        }
        //Write a method to check whether a given number is 
          //even or odd
        public static bool EvenOrOdd(int a)
        {
            var even = (a % 2 == 0) ? true : false;

            return even;
        }
        //Write a method to check whether a given 
        //number is positive or negative.
        public static void PosOrNeg(int b)
        {
            if (b < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Positive");
            }
        }
        //Write a method to read the age of a candidate and
        //determine whether they can vote.Hint: use Parse()... 
        //or the safer TryParse() for an extra challenge!!
        public static bool VoterAgeCheck(int age)
        {
            age = Convert.ToInt32(Console.ReadLine());
            if (age > 18)
            {
                Console.WriteLine("Go vote!");
                return true;
            }
            else
            {
                Console.WriteLine("Sorry, too yung");
                
            }
            return false;
        }
        //Write a method to check if an integer(from the user) is in the range -10 to 10.
        public static bool NegToPosTen(int user)
        {
           
             user = Convert.ToInt32(Console.ReadLine());
             var numCheck = (user <= 10 || user >= -10) ? true : false;

            return numCheck;
        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer.
        public static void MultplyTable(int given)
        {
            given = Convert.ToInt32(Console.ReadLine());
            int table = 1;
            for (int i = 1; i <= 12; i++)
            {
                
                Console.WriteLine($"{table} x {given} = {table*given}");
                table++;
                
            }

        }
    }

}
