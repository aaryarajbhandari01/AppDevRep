// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;
using Year3ConsoleApp.Basics;
using Year3ConsoleApp.Testing;
using Year3ConsoleApp.Week2;



// Display title as the C# console calculator app.
Console.WriteLine("Console Calculator in C#\r");
Console.WriteLine("------------------------\n");

Menu:

//getting input from users
// Declare variables and then initialize to zero.
int num1 = 0; int num2 = 0;

// Ask the user to choose an option.
Console.WriteLine("Choose an option from the following list:");
Console.WriteLine("Press 1 for Addition");
Console.WriteLine("Press 2 for Subtraction");
Console.WriteLine("Press 3 for Multiplication");
Console.WriteLine("Press 4 for Division");
Console.WriteLine("Press 5 for Jagged Arrays");
Console.WriteLine("Press 6 for SingleDimensional Arrays");
Console.WriteLine("Press 7 for ImplicitlyTyped Arrays");
Console.WriteLine("Press 8 for MultiDimensional Arrays");
Console.WriteLine("Press 9 for If-Else Statement Example");
Console.WriteLine("Press 10 for Switch-Case Statement Example");
Console.WriteLine("Press 11 for While Statement Example");
Console.WriteLine("Press 12 for Do-While Statement Example");
Console.WriteLine("Press 13 for For Statement Example");
Console.WriteLine("Press 14 for For-Each Statement Example");
Console.Write("Your option? ");



    var a = Console.ReadLine();
    // Use a switch statement to do the math.
    switch (a)
    {
        case "1":
        Console.WriteLine("Type a number, and then press Enter");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Type another number, and then press Enter");
        num2 = Convert.ToInt32(Console.ReadLine());

        Calculator.Additions(num1, num2);

            break;

        case "2":
        Console.WriteLine("Type a number, and then press Enter");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Type another number, and then press Enter");
        num2 = Convert.ToInt32(Console.ReadLine());

        Calculator.Subtraction(num1, num2);

            break;

        case "3":
        Console.WriteLine("Type a number, and then press Enter");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Type another number, and then press Enter");
        num2 = Convert.ToInt32(Console.ReadLine());
        Calculator.Multiplication(num1, num2);

            break;

        case "4":
        Console.WriteLine("Type a number, and then press Enter");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Type another number, and then press Enter");
        num2 = Convert.ToInt32(Console.ReadLine());

        Calculator.Division(num1, num2);

            break;

        case "5":
            Arrays.JaggedArray();
            break;

        case "6":
            Arrays.SingleDimensionalArray();
            break;

        case "7":
            Arrays.ImplicitlyTypedArray();
            break;

        case "8":
            Arrays.MultiDimensionalArray();
            break;

        case "9":
        Console.WriteLine("Type a number, and then press Enter");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Type another number, and then press Enter");
        num2 = Convert.ToInt32(Console.ReadLine());

        ControlStatement.IfElse(num1, num2);
            break;

        case "10":
            ControlStatement.SwitchCase();
            break;

        case "11":
        Console.WriteLine("Type a number, and then press Enter");
        num1 = Convert.ToInt32(Console.ReadLine());
        
        ControlStatement.WhileStatement(num1);
            break;

        case "12":
        Console.WriteLine("Type a number, and then press Enter");
        num1 = Convert.ToInt32(Console.ReadLine());

        ControlStatement.DoWhileStatement(num1);
            break;

        case "13":
        Console.WriteLine("Type a number, and then press Enter");
        num1 = Convert.ToInt32(Console.ReadLine());

        ControlStatement.ForLoop(num1);
            break;

        case "14":
            ControlStatement.ForEachLoop();
            break;

        default:
            Interpolation.StringInterpolation();
            break;
    }

// to rerun the program

rerun_program:

Console.Write("Press y to restart, n to exit ");
var b = Console.ReadLine();

switch (b)
{
    case "y":
        goto Menu;
        break;

    case "n":
        Console.Write("Press any key to close the Calculator console app...");
        Console.ReadKey();
        break;

    default:
        Console.Write("Invalid option");
        goto rerun_program;
        break;


}


// Wait for the user to respond before closing.

//Console.Write("Press any key to close the Calculator console app...");
//Console.ReadKey();
