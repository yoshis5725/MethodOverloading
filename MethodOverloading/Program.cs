using System;

namespace MethodOverloading
{
    class Program
    {

        public static void Add(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }


        public static void Add(int num1, int num2, bool isTrue)
        {
            var statement = isTrue == true ? $"{num1 + num2} dollars" : "0 dollars";
            Console.WriteLine(statement);
        }


        static void Main(string[] args)
        {
            Add(2, 4);
            Add(5, 5, true);
        }
    }
}

