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
            // Reads the product name
            string product = Console.ReadLine();


            // Asks the user to enter the quantity
            Console.WriteLine("Enter the quantity: ");
            // Converts the entered quantity to integer
            int quantity = Convert.ToInt32(Console.ReadLine());

            // Asks the user to enter the amount
            Console.WriteLine("Enter the product cost: ");

           
            // Converts the entered amount to double
            double amount = Convert.ToDouble(Console.ReadLine());

            //Calculate the quantity and amount
            amount = quantity * amount;

            // Ask user if they would like GST to be added

            Console.WriteLine("Would you like to add GST? (Y/N)");
            string gstChoice = Console.ReadLine();

            // Asks if the user would like to add GST
            if (gstChoice == "Y" || gstChoice == "y") ;
            {
                // Calculate the GST
                double gst = amount * 0.15;
                // Calculate the total amount
                double totalAmount = amount + gst;
                // Display the product name
                Console.WriteLine("Product Name: " + product);
                // Display the quantity
                Console.WriteLine("Quantity: " + quantity);
                // Display the amount
                Console.WriteLine("Amount: " + amount);
                // Display the GST
                Console.WriteLine("GST: " + gst);
                // Display the total amount
                Console.WriteLine("Total Amount: " + totalAmount);

                if (gstChoice == "N")
                {
                    // Display the product name
                    Console.WriteLine("Product Name: " + product);
                    // Display the quantity
                    Console.WriteLine("Quantity: " + quantity);
                    // Display the amount
                    Console.WriteLine("Amount: " + amount);
                    // Display the total amount
                    Console.WriteLine("Total Amount: " + amount);


                }





            }
        }
    }
}
