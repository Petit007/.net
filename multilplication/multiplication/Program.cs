using System;

namespace multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int first=int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter second number");
            int second=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter third number");
            int third=int.Parse(Console.ReadLine());

            int result = first*second*third;
            Console.WriteLine("Result:"+ result);

        }
    }
}
