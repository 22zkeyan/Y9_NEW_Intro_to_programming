namespace Y9_NEW_Intro_to_programming
{
    internal class Program
    {
        static void OddOrEven()
        {
            Console.WriteLine("Enter an integer"); //asks the user to enter an integer
            int num = int.Parse(Console.ReadLine()); //gets an input from the user (a string), and parses it to an integer to store in a variable
            if (num % 2 == 0) //checks if the number divdes into 2 without a remainder
            {
                Console.WriteLine("Your number is even"); //alerts the user their number is even
            } else if (num % 2 != 0) //checks if the number isn't divisible by 2 (leaves a remainder)
            {
                Console.WriteLine("Your answer is odd"); //alerts the user their number is odd
            } else //if the user enters a value that can't be parsed into an integer to compare
            {
                Console.WriteLine("Invalid Input"); //alerts the user their number is invalid
            }
        }
        static void ShippingCost()
        {
            double shipping_cost = 0.00;
            Console.WriteLine("Enter the weight of your item in kg"); //asks the user to enter the weight in kg
            int weight = int.Parse(Console.ReadLine());
            if (weight <= 2)
            {
                shipping_cost = 5.00;
            } else if (weight >= 2 && weight <= 5) 
            {
                shipping_cost = 10.00;
            } else if (weight > 5)
            {
                shipping_cost = 20.00;
            }
            Console.WriteLine("Your shipping cost is £" +shipping_cost);
        }
        static void LibraryManagement()
        {
            double fine = 0.00;
            Console.WriteLine("Enter the number of days your book is overdue");
            int overdue_days = int.Parse(Console.ReadLine());
            if (overdue_days >= 1 && overdue_days <= 5)
            {
                fine = 1.00;
            } else if (overdue_days >= )
            {

            }
        }
        static void Main(string[] args)
        {
            ShippingCost();
        }
    }
}
