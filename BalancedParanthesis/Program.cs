using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancedParanthesis
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(CheckBalancedBalancedbrackets("()[]{}(([])){[()][]}"));
            Console.WriteLine(CheckBalancedBalancedbrackets("())[]{}"));
            Console.WriteLine(CheckBalancedBalancedbrackets("()[]{}"));
            Console.WriteLine(CheckBalancedBalancedbrackets(""));
            Console.ReadLine();
        }


        /// <summary>
        /// A function to check if the string has balanced brackets or not
        /// </summary>
        /// <param name="input">string from the main func , which needs to be asserted </param>
        /// <returns>true if the string is balanced and false if the string is not a well formed one</returns>
        public static bool CheckBalancedBalancedbrackets(string input)
        {
            //stack to store the values of the opening brackets
            var stack = new Stack<char>();
            //dictionary of name value pairs with the allowed characters -- different start and end brackets
            var allowedValues = new Dictionary<char, char>() {{'(', ')'}, {'[', ']'}, {'{', '}'}};

            var isBalanced = true;
            foreach (var chr in input)
            {
                if (allowedValues.ContainsKey(chr))
                {
                    //if the char has a key in the allowedValues then push the value into the stack
                    stack.Push(chr);
                }

                //if the char does not have a key then check the stack value --poped on with this char for any key val pair 
                //in the allowedValues
                else if (allowedValues.ContainsValue(chr))
                {
                    //if there are no values to pop then its not well formed.
                    isBalanced = stack.Any();

                    if (isBalanced)
                    {
                        var startingChar = stack.Pop();
                        //check if the poped value and the curr char has a key val pair in the dictionary
                        isBalanced = allowedValues.Contains(new KeyValuePair<char, char>(startingChar, chr));
                    }
                    //if its not well formed then the full string is not well formed 
                    //hence , exit the loop and return false.
                    if (!isBalanced)
                    {
                        break;
                    }
                }
            }
            return isBalanced;
        }
    }
}