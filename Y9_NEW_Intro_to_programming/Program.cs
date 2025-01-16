﻿namespace Y9_NEW_Intro_to_programming
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
            double fine = 0.00; //initialises a double "fine" to 0.00
            Console.WriteLine("Enter the number of days your book is overdue"); //prompts the user to enter the number of days their book is overdue
            int overdue_days = int.Parse(Console.ReadLine()); //takes the user;s input and parses it into an integer
            if (overdue_days >= 1 && overdue_days <= 5) //checks if the book is 1-5 days overdue
            {
                fine = 1.00; //sets the fine to £1.00
            } else if (overdue_days >= 6 && overdue_days <= 10) //checks if the book is 6-10 days overdue
            {
                fine = 1.50; //sets the fine to £1.50
            } else if (overdue_days >= 11) //checks if the book is more than 11 days overdue
            {
                fine = 2.00; //sets the fine to £2.00
            } else //if the user didn't enter a valid input (e.g. a string for the number (three))
            {
                Console.WriteLine("Invalid input"); //alerts the user their input was invalid
            }
            Console.WriteLine("Your fine is: £" +fine);
        }
        static void WeatherApp()
        {
            Console.Write("Enter the current temperature: "); //prompts the user to enter the current temperature
            int temp = int.Parse(Console.ReadLine()); //takes the user's input and parses it into an integer, then stores it in a variable
            Console.Write("Enter the weather type (e.g sunny or raining): "); //prompts the user to enter the weather type
            string weather_type = Console.ReadLine(); //takes the user's input and stores it in a variable
            if (temp > 25 && weather_type == "sunny") //checks if it's hot
            {
                Console.WriteLine("Wear light clothing"); //suggests wearing light clothing
            } else if (temp < 15 && weather_type == "raining") //checks if it's cold
            {
                Console.WriteLine("Wear warm clothing and bring an umbrella"); //suggests being warm
            } else //invalid inputs
            {
                Console.WriteLine("Invalid input"); //alerts user that their input is invalid  
            }
        }
        static void DiscountEligibility()
        {
            double discount = 0;
            Console.Write("Enter the total of your purchase: ");
            double purchase = double.Parse(Console.ReadLine());
            if (purchase > 100)
            {
                discount = 0.2;
            } else if (purchase > 50 && purchase < 100)
            {
                discount = 0.1;
            }
            else
            {
                Console.WriteLine("You are not eligible for a discount.");
            }
            purchase = Math.Round(((1 - discount) * purchase), 2);
            Console.WriteLine("Your new total is £" +purchase);
        }
        static void Astronauts()
        {
            Console.WriteLine("Enter the mission name:"); //prompts the user to enter the mission name, which will get stored in variable
            string mission_name = Console.ReadLine();
            Console.WriteLine("Number of astronauts:"); //prompts number of astronauts, which will get parsed and stored in a variable
            int number = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Fuel level (as a %):"); //prompts the fuel level as a %, which will get parsed and stored in a variable
            int fuel_level = int.Parse(Console.ReadLine());
            Console.WriteLine("Equipment status:"); //prompts equipmetn stat, which will get stored in a variable
            string equip_stat = Console.ReadLine();
            if (number >= 3 && fuel_level >= 80 && equip_stat == "ready") //checks if all parameters meet basic expectations
            {
                Console.WriteLine("The mission can launch"); //alerts user they are ready
            } else //if any one of the conditions do not suffice
            {
                Console.WriteLine("The mission can NOT launch"); //alerts the user they are not ready
            }

        }
        static void FoodPriceCalc()
        {
            Console.WriteLine("How many main courses have you had?");
            int main_courses = int.Parse(Console.ReadLine());
            Console.WriteLine("Howmany desserts have you had?");
            int desserts = int.Parse(Console.ReadLine());
            Console.WriteLine("Do you have a membership card?");
            string temp = Console.ReadLine();
            if (temp == "yes")
            {
                bool member_stat = true;
            } else
            {
                bool member_stat = false;
            }
        }
        static void Main(string[] args)
        {
            Astronauts();
        }
    }
}
