using System;
using System.Collections.Generic;


    public class Expense //new class
    {
        public string Name {get; set;} //created properties
        public int Amount {get; set;} //created properties
        
        // expense(....) is constructor here
        public Expense(string EName, int EAmount)
    {
        //assigns the constructor parameter to the object's property
        this.Name = EName;
        this.Amount = EAmount;
    }
    }
    

class Program
{
    
    public static void Main()
    {
    /*List<Expense> shopping = new List<Expense>();

        shopping.AddRange(new Expense[]{new Expense("tisha", 23), new Expense("subhajit", 25)});
        foreach(Expense shopped in shopping)
        {
            Console.WriteLine($" {shopped.Name} spent : {shopped.Amount}");
        }
        */

        List<Expense> expenses = new List<Expense>();

        Console.WriteLine("How many expenses do you want to enter?");

        // reading expenses count
        int newExpense =Convert.ToInt32(Console.ReadLine());
        // declared for total calculation
        int total = 0;
        int highestExpense = 0;
        
        for(int i=1; i<=newExpense; i++)
        {
            // reading expense name
            Console.WriteLine("Please enter the Product name : ");
            string newName = Console.ReadLine();

            //ready expense amount
            Console.WriteLine("Please enter the product value :");
            int newAmount = Convert.ToInt32(Console.ReadLine());

            //adding expenses to the list
            expenses.Add( new Expense(newName, newAmount));
        }

        for(int expenseIndex = 0; expenseIndex < expenses.Count; expenseIndex++)
        {
            int currentIndex = expenses[expenseIndex].Amount;

            if(currentIndex>highestExpense)
            { highestExpense= currentIndex;}
            
        }
        Console.WriteLine("your highest expense is : " + highestExpense);

        

        // printing expenses list with amount
        foreach(Expense newExpenses in expenses)
        {
            Console.WriteLine($"Product : {newExpenses.Name},amount :{ newExpenses.Amount}");
            total+=newExpenses.Amount;
        }
        Console.WriteLine("Total Expense is : " + total);



        
        
        

    }
}