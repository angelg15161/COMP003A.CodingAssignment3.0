/*
    Author: Angel Gomez
    Course: COMP003A
    Faculty: Jonathan Cruz
    Purpose: Budget management application demonstrating control flow.
*/
namespace COMP003A.CodingAssignment3._0;

class Program
{
    static void Main(string[] args)
    {
        // Welcome the user to the application
        Console.WriteLine("Hello! Welcome to the Budget Managing Tool! \n");
        
        // Give variables default values so that the user inputs within the loops can be accessed
        string expenseName = "";
        double expenseAmount = 0;
        double monthlyIncome = 0;
        bool exit = true;
        
        // Prompt the user for their monthly income 
        Console.Write("Enter your monthly income: ");
        monthlyIncome = double.Parse(Console.ReadLine());
        
        // Menu loop until user chooses to exit
        while (exit)
        {
            // Menu choices 1-4
            Console.WriteLine("\nMenu:\n1. Add Expense\n2. View Expense and Budget\n3. Remove Expense\n4. Exit");
            Console.Write("Enter your choice (1-4): ");
            string menuChoice = Console.ReadLine();
            
            // try catch if user inputs something invalid 
            try
            {
                switch (menuChoice) // Actions based on menu choice selected
                {
                    case "1":   // Prompts user for expense name and amount
                        Console.Write("\nEnter the Expense name: "); 
                        expenseName = Console.ReadLine(); 
                        Console.Write("Enter the Expense amount: "); 
                        expenseAmount = double.Parse(Console.ReadLine()); 
                        Console.WriteLine("Expense added successfully!");
                        break;
                    case "2":   // Displays the expense name and amount, total expense, and the remaining budget 
                        Console.Write("\nExpenses:"); 
                        Console.WriteLine($"- {expenseName}: ${expenseAmount}"); 
                        Console.WriteLine("Total expenses: $" + expenseAmount);
                        Console.WriteLine($"Remaining Budget: ${monthlyIncome - expenseAmount}");
                        break;
                    case "3":   // Removes the expense name and the amount 
                        if (menuChoice != "")
                        {
                            expenseName = "";
                            expenseAmount = 0;
                            Console.WriteLine("\nThe Expense has been removed successfully! ");
                        }
                        else    // Displays if there is nothing to remove 
                        {
                            Console.WriteLine("No Expense to remove!");
                        }
                        break;
                    case "4":   // Exit loop
                        Console.Write("\nGoodbye! ");
                        exit = false;
                        break;
                    default:    // Prompts user to select a number 1-4 if they selected anything else 
                        Console.WriteLine("\nInvalid input, please select a number 1-4. ");
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input, please try again.");
            }
        }
    }
}