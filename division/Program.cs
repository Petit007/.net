using System;

namespace division
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int first=int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter second number");
            int second=int.Parse(Console.ReadLine());
            
            if (second==0){
                Console.WriteLine("Enter second number greater than 0");}
                else
                {
                int result = (first/second);
                Console.WriteLine("Result:"+result);
            }
        }
    }
}
