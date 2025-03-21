using System;

namespace GST_Calculator
{
    class Program

    {
        static void Main(string[] args)

            // Written by Jordan.E


        
        {
            // Asks user to enter product name
            Console.WriteLine("Enter the product name: ");

            // Asks the user to enter the amount
            Console.WriteLine("Enter the amount: ");

            // Converts the entered amount to double
            double amount = Convert.ToDouble(Console.ReadLine());

            // Calculates the GST amount
            double gst = amount * 0.18;

            // Displays the GST amount
            Console.WriteLine("GST amount is: " + gst);
        }
    }
}
