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
        string expenseName2 = "";
        string expenseName3 = "";
        string expenseName4 = "";
        string expenseName5 = "";
        double expenseAmount = 0;
        double expenseAmount2 = 0;
        double expenseAmount3 = 0;
        double expenseAmount4 = 0;
        double expenseAmount5 = 0;
        double monthlyIncome = 0;
        bool exit = true;
        
        // Prompt the user for their monthly income 
        Console.Write("Enter your monthly income: ");
        monthlyIncome = double.Parse(Console.ReadLine());
        
        // Menu loop until user chooses to exit
        while (exit)
        {
            // Menu choices 1-4
            Console.WriteLine("\nMenu:\n1. Add an Expense\n2. View Expenses and Budget\n3. Remove an Expense\n4. Exit");
            Console.Write("Enter your choice (1-4): ");
            string menuChoice = Console.ReadLine();
            
            // try catch if user inputs something invalid 
            try
            {
                switch (menuChoice) // Actions based on menu choice selected
                {
                    case "1":   // Prompts user for expense name and amount
                        
                        if (expenseName == "" && expenseAmount == 0)
                        {
                            Console.Write("\nEnter the Expense name: ");
                            expenseName = Console.ReadLine(); 
                            Console.Write("Enter the Expense amount: "); 
                            expenseAmount = double.Parse(Console.ReadLine()); 
                            Console.WriteLine("Expense added successfully!");
                        }
                        else if (expenseName2 == "" && expenseAmount2 == 0)
                        {
                            Console.Write("\nEnter the Expense name: ");
                            expenseName2 = Console.ReadLine(); 
                            Console.Write("Enter the Expense amount: "); 
                            expenseAmount2 = double.Parse(Console.ReadLine()); 
                            Console.WriteLine("Expense added successfully!");
                        }
                        else if (expenseName3 == "" && expenseAmount3 == 0)
                        {
                            Console.Write("\nEnter the Expense name: ");
                            expenseName3 = Console.ReadLine();
                            Console.Write("Enter the Expense amount: ");
                            expenseAmount3 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Expense added successfully!");
                        }
                        else if (expenseName4 == "" && expenseAmount4 == 0)
                        {
                            Console.Write("\nEnter the Expense name: ");
                            expenseName4 = Console.ReadLine();
                            Console.Write("Enter the Expense amount: ");
                            expenseAmount4 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Expense added successfully!");
                        }
                        else if (expenseName5 == "" && expenseAmount5 == 0)
                        {
                            Console.Write("\nEnter the Expense name: ");
                            expenseName5 = Console.ReadLine();
                            Console.Write("Enter the Expense amount: ");
                            expenseAmount5 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Expense added successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Maximum expense amount reached!");
                        }
                        
                        break;
                    
                    
                    case "2":   // Displays the expense name and amount, total expense, and the remaining budget 
                        Console.WriteLine("\nExpenses:");

                        if (expenseName != "")
                        {
                            Console.WriteLine($"- {expenseName}: ${expenseAmount}");
                        }

                        if (expenseName2 != "")
                        {
                            Console.WriteLine($"- {expenseName2}: ${expenseAmount2}");
                        }

                        if (expenseName3 != "")
                        {
                            Console.WriteLine($"- {expenseName3}: ${expenseAmount3}");
                        }

                        if (expenseName4 != "")
                        {
                            Console.WriteLine($"- {expenseName4}: ${expenseAmount4}");
                        }

                        if (expenseName5 != "")
                        {
                            Console.WriteLine($"- {expenseName5}: ${expenseAmount5}");
                        }
                        
                        Console.WriteLine($"Total expenses: ${expenseAmount + expenseAmount2 + expenseAmount3 + expenseAmount4 + expenseAmount5}");
                        Console.WriteLine($"Remaining Budget: ${monthlyIncome - expenseAmount - expenseAmount2 - expenseAmount3 - expenseAmount4 - expenseAmount5}");
                        break;
                    
                    
                    case "3":   // Removes the expense name and the amount 
                        // Tells user there is no expenses to be removed and skips asking them to write the name of expense to remove 
                        if (expenseName == "" && expenseName2 == "" && expenseName3 == "" && expenseName4 == "" &&
                            expenseName5 == "")
                        {
                            Console.WriteLine("\nThere are no expenses to remove.");
                            break;
                        }
                        
                        Console.Write("\nEnter the name of the expense you want to remove: ");
                        string remove = Console.ReadLine();

                        if (remove == expenseName)
                        {
                            expenseName = "";
                            expenseAmount = 0;
                            Console.WriteLine("\nThe Expense has been removed successfully! ");
                        }
                        else if (remove == expenseName2)
                        {
                            expenseName2 = "";
                            expenseAmount2 = 0;
                            Console.WriteLine("\nThe Expense has been removed successfully! ");
                        }
                        else if (remove == expenseName3)
                        {
                            expenseName3 = "";
                            expenseAmount3 = 0;
                            Console.WriteLine("\nThe Expense has been removed successfully! ");
                        }
                        else if (remove == expenseName4)
                        {
                            expenseName4 = "";
                            expenseAmount4 = 0;
                            Console.WriteLine("\nThe Expense has been removed successfully! ");
                        }
                        else if (remove == expenseName5)
                        {
                            expenseName5 = "";
                            expenseAmount5 = 0;
                            Console.WriteLine("\nThe Expense has been removed successfully! ");
                        }
                        else
                        {
                            Console.WriteLine("\nTry again, please use the same casing.");
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