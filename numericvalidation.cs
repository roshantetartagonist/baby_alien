using System;

namespace and.or
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Please enter a number between '0' & '10':");
            number = int.Parse(Console.ReadLine());

            if ((number <= 10) || (number >= 0))
                Console.WriteLine("Well done!");
            else
                Console.WriteLine("Hey! Please enter a number between '0' and '10'!");
            
          
        }
    }
}
