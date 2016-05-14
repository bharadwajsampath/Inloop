using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling the funtion
            PrintNumbers(100);
            Console.Read();
        }


      /// <summary>
      /// A func which takes the max value and then prints a fizz buzz based on a given requirement
      /// </summary>
      /// <param name="num">max num for the loop</param>
        private static void PrintNumbers(int num)
        {


            for (var i = 1; i <= num; i++)
            {
                // multiples of 3 and multiples of 5 means multiples of 15
                if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                //multiples of 3 
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                //multiples of 5
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                //if its not multiples of any of the given number then print the number as it is
                else
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
