using System;

namespace firstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int first=int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter second number");
            int second=int.Parse(Console.ReadLine());
            
            if (first<second){
                Console.WriteLine("Enter a first number greater than the second");}
                else
                {
                int result = first-second;
                Console.WriteLine("Result:"+result);
            }
        }
    }
}
