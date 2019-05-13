using System;

namespace PayrollProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1st User Prompt
            Console.Write("Enter your hourly payrate: $");
            double payRate = Convert.ToDouble(Console.ReadLine());

            // 1st Input Validation
            while (payRate < 7.5 || payRate > 18.25) 
            {
                Console.WriteLine("Pay rate must be between $7.50 and $18.25.");
                Console.Write("Enter the correct pay rate: $");
                payRate = Convert.ToDouble(Console.ReadLine());
            }

            // 2nd User Prompt
            Console.Write("Enter the number of hours worked: ");
            Int32 hours = Convert.ToInt32(Console.ReadLine());

            // 2nd Input Validation
            while (hours < 0 || hours > 40)
            {
                Console.WriteLine("Hours worked must be between 0 and 40.");
                Console.Write("Enter the correct number of hours worked: ");
                hours = Convert.ToInt32(Console.ReadLine());
            }

            // Gross Pay
            Console.WriteLine("Gross Pay: $" + payRate * hours);
        }
    }
}