using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2
{
    internal class JumpStatement
    {
        public static int Return()
        {
            Console.WriteLine("Please enter a number: ");
            var number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number: ");
            var number2 = Convert.ToInt32(Console.ReadLine());
            return number1 + number2;
        }

        public static void GoTo()
        {
        Start:
            Console.WriteLine("Do you want to rerun the Jump statements? (y/n): ");
            var o = Console.ReadLine();
            switch (o)
            {
                case "y":{
                        goto Start;
                }
                case "n":
                {
                        break;
                }
                default:
                {
                        Console.WriteLine("Invalid option. Please choose from the options");
                        goto Start;
                }

            }

        }
    }
}