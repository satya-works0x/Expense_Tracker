using System;
using System.Collections.Generic;

class Expense
{
    public string Name{ get; set;}
    public int Amount{ get; set;}
    public Expense(string Ename, int Eamout)
    {
        this.Name = Ename;
        this.Amount = Eamout;
    } 
}

class Program
{
    public static void Main()
    {
        List<Expense> expenses = new List<Expense>();
        int total = 0;
        int highestExpense = 0;


        Console.WriteLine("How many expenses, do you want to add?");
        int countOfExpenses = Convert.ToInt32(Console.ReadLine());

        for(int i=1; i<=countOfExpenses; i++)
        {
            Console.WriteLine("Please enter the Product Name:");
            string product = Console.ReadLine();

            Console.WriteLine("Please enter the amount of this product:");
            int amount = Convert.ToInt32(Console.ReadLine());

            expenses.Add(new Expense(product, amount));
            total += amount;
        }
        
        for(int j=0; j<expenses.Count; j++)
        {   
            if(highestExpense<expenses[j].Amount)
            {
            highestExpense = expenses[j].Amount;
            }      
        }

        foreach(Expense expense in expenses)
        {
            Console.WriteLine($"Product: {expense.Name} Amount is : {expense.Amount}");
            
        }
        
        Console.WriteLine("Total is :" + total);
        Console.WriteLine("Highest expense is :" + highestExpense);
        
    }
}