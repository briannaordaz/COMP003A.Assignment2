namespace COMP003A.Assignment2;

internal class Program
{
    static void Main(string[] args)
    {   
        
        
        // declared variables
        string userFirstName;
        string userLastName;
        string student;
        int addAge;
        int userAge;
        double userPrice;
        double newPrice;
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
       
       


    }
}