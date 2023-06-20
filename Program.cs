using road_to_C_.Math;
using System;

namespace road_to_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var John = new Person();
            John.FirstName = "John";
            John.LastName = "Smith";
            John.Introduce();
            var calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
             
        }
    }
}



