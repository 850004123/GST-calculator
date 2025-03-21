using System;

namespace GST_calculator
{
    class Program;
    {
        static void Main(string[] args)
    {
        Console.WriteLine("Enter the amount: ");
        double amount = Convert.ToDouble(Console.ReadLine());
        double gst = amount * 0.18;
        Console.WriteLine("GST amount is: " + gst);
    }
}