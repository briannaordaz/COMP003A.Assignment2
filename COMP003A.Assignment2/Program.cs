﻿using System.Runtime;

namespace COMP003A.Assignment2;

internal class Program
{
    static void Main(string[] args)
    {   
        
        
        // declared variables
        string userFirstName;
        string userLastName;
        string student;
        int userAge;
        double userPrice;
        bool studentExists;
        
        
        // prompt user input: 
        
        Console.WriteLine("**************************************************");
        Console.WriteLine("Welcome to the Discount Calculator!");
        Console.WriteLine("**************************************************");
        
       Console.WriteLine("What is your first name?");
       userFirstName = Console.ReadLine();
       
       Console.WriteLine("What is your last name?");
       userLastName = Console.ReadLine();
       
       Console.WriteLine("How old are you?");
       userAge = int.Parse(Console.ReadLine());
       
       Console.WriteLine("What is the price of the item your interested in?");
       userPrice = double.Parse(Console.ReadLine());
       
       Console.WriteLine("Are you a student? (true/false); ");
       studentExists = bool.Parse(Console.ReadLine());
       
       Console.WriteLine("**************************************************");
       
       
       // Perform Operations:
       int addAge = userAge + 5;
       double newPrice = userPrice * 0.9;
       double seniorPrice = userPrice * 0.8;
       
       
       
       //Display Outputs:
       Console.WriteLine($"Hello, {userFirstName} {userLastName}!");
       Console.WriteLine($"Your current age is {userAge}.");
       Console.WriteLine($"In 5 years, you will be {addAge}.");
       Console.WriteLine($"The original price of the item is {userPrice}.");
       Console.WriteLine($"As a student, your discounted price is {newPrice}.");
       Console.WriteLine($"As a senior citizen, your discounted price would be {seniorPrice}.");
       Console.WriteLine("***************************************************");
       
       




    }
}