using System;

class Program
{
    static void Main()
    {
        // Task #1
        Console.Write("Enter the deposit amount: ");
        decimal deposit = decimal.Parse(Console.ReadLine());

     
        decimal rate = 0.10m;

        // After 1 year
        deposit = deposit + (deposit * rate);
        Console.WriteLine("Amount after year 1: " + deposit);

        // After 2 years
        deposit = deposit + (deposit * rate);
        Console.WriteLine("Amount after year 2: " + deposit);

        // After 3 years
        deposit = deposit + (deposit * rate);
        Console.WriteLine("Amount after year 3: " + deposit);

      
        Console.WriteLine("Press any key to exit...");
    
    }
}