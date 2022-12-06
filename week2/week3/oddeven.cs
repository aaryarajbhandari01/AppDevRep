using System;

public class oddeven
{
	public oddeven()
	{

        Console.WriteLine("Please enter a number: ");
        var num = Convert.ToInt32(Console.ReadLine());
        
		if (num % 2 == 0) 
		{
			Console.WriteLine($"{num} is even");

		}
		else if (num % 2 == 1) {
			Console.WriteLine($"{num} is odd");

		}
		else
		{
            Console.WriteLine($"{num} is zero");

        }


    }
}
