using System;

namespace Program

{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter an integer:");
            string num = Console.ReadLine();
            if (int.TryParse(num, out int number))
            {
                Console.WriteLine("You entered a number:" + number);
            }
            else
            {
                Console.WriteLine("The number you entered is not an integer");
            }
        }
    }







}